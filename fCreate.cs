using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOPCore;

namespace MainApp
{
    public partial class fCreate : Form
    {

        public object Result { get; private set; }

        private Dictionary<string, Type> availableTypes = new();

        private object editTarget;

        private Type selectedType;

        private ParameterInfo[] currentParameters;

        private Dictionary<string, TextBox> inputControls = new();

        private Dictionary<string, Type> constructorParameterTypes = new();



        public fCreate()
        {
            InitializeComponent();
            InitializeTypeDictionary();
            PopulateTypeComboBox();
        }

        public fCreate(object objToEdit) : this()
        {
            editTarget = objToEdit;
            cbTypes.Enabled = false;
         
            string key = availableTypes.FirstOrDefault(kv => kv.Value == objToEdit.GetType()).Key;
            if (!string.IsNullOrEmpty(key))
            {
                cbTypes.SelectedItem = key;
   
                PopulateParameterFieldsForEditing(objToEdit);
            }
        }

        private void InitializeTypeDictionary()
        {
    
            List<Type> types = ReflectiveFactory.GetCreatableTypes();
            foreach (Type type in types)
            {
                if (type.Name == "Phone")
                    availableTypes["Смартфон"] = type;
                else if (type.Name == "Notebook")
                    availableTypes["Ноутбук"] = type;
                else if (type.Name == "Headphones")
                    availableTypes["Наушники"] = type;
                else
                    availableTypes[type.Name] = type;
            }
        }

        private void PopulateTypeComboBox()
        {
            cbTypes.Items.Clear();
            foreach (var key in availableTypes.Keys)
                cbTypes.Items.Add(key);
            if (cbTypes.Items.Count > 0)
                cbTypes.SelectedIndex = 0;
        }

        private void fCreate_Load(object sender, EventArgs e)
        {

        }

        private void cbTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (editTarget != null)
                return;
            GenerateParameterFields();
        }

        private void GenerateParameterFields()
        {
            panelParameters.Controls.Clear();
            inputControls.Clear();
            constructorParameterTypes.Clear();

            string selectedKey = cbTypes.SelectedItem.ToString();
            if (!availableTypes.ContainsKey(selectedKey))
                return;

            selectedType = availableTypes[selectedKey];
            ConstructorInfo ctor = selectedType.GetConstructors().FirstOrDefault();
            if (ctor == null)
            {
                MessageBox.Show("Выбранный тип не имеет публичного конструктора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentParameters = ctor.GetParameters();
            int top = 10;
            foreach (var param in currentParameters)
            {
                constructorParameterTypes[param.Name] = param.ParameterType;

                Label lbl = new Label
                {
                    Text = $"{param.Name} ({param.ParameterType.Name})",
                    Top = top,
                    Left = 10,
                    Width = 150
                };
                panelParameters.Controls.Add(lbl);

                TextBox txt = new TextBox
                {
                    Name = "param_" + param.Name,
                    Top = top,
                    Left = 170,
                    Width = 150
                };
                panelParameters.Controls.Add(txt);
                inputControls[param.Name] = txt;
                top += 30;
            }
        }

        private void PopulateParameterFieldsForEditing(object obj)
        {
            panelParameters.Controls.Clear();
            inputControls.Clear();
            constructorParameterTypes.Clear();

            selectedType = obj.GetType();
            ConstructorInfo ctor = selectedType.GetConstructors().FirstOrDefault();
            if (ctor == null)
            {
                MessageBox.Show("Выбранный тип не имеет публичного конструктора.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            currentParameters = ctor.GetParameters();
            int top = 10;
            foreach (var param in currentParameters)
            {
                constructorParameterTypes[param.Name] = param.ParameterType;

                Label lbl = new Label
                {
                    Text = $"{param.Name} ({param.ParameterType.Name})",
                    Top = top,
                    Left = 10,
                    Width = 150
                };
                panelParameters.Controls.Add(lbl);

                TextBox txt = new TextBox
                {
                    Name = "param_" + param.Name,
                    Top = top,
                    Left = 170,
                    Width = 150
                };

                PropertyInfo prop = selectedType.GetProperty(param.Name, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                if (prop != null)
                {
                    object value = prop.GetValue(obj);
                    txt.Text = value?.ToString() ?? "";
                }
                panelParameters.Controls.Add(txt);
                inputControls[param.Name] = txt;
                top += 30;
            }
        }
        private object ConvertValueFromControl(TextBox txt, Type targetType)
        {
            return Convert.ChangeType(txt.Text, targetType);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (editTarget != null)
            {
                // Режим редактирования: для каждого контролла проверяем изменения и регистрируем команды изменения
                foreach (var kvp in inputControls)
                {
                    string propName = kvp.Key;
                    TextBox txt = kvp.Value;

                    object newValue;
                    try
                    {
                        newValue = ConvertValueFromControl(txt, constructorParameterTypes[propName]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка преобразования значения для параметра {propName}: {ex.Message}",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Получаем текущее значение свойства
                    PropertyInfo prop = selectedType.GetProperty(propName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                    if (prop != null)
                    {
                        object oldValue = prop.GetValue(editTarget);
                        // Если значение изменилось, создаем и выполняем команду
                        if (!Equals(oldValue, newValue))
                        {
                            var cmd = new ChangePropertyCommand(editTarget, propName, newValue);
                            Program.CommandManager.ExecuteCommand(cmd);
                        }
                    }
                }

                Result = editTarget;
            }
            else
            {
                // Режим создания нового объекта
                if (currentParameters == null)
                {
                    MessageBox.Show("Не выбран тип или не сгенерированы поля для ввода параметров.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                object[] args = new object[currentParameters.Length];
                try
                {
                    for (int i = 0; i < currentParameters.Length; i++)
                    {
                        string paramName = currentParameters[i].Name;
                        if (!inputControls.ContainsKey(paramName))
                            throw new Exception($"Отсутствует значение для параметра {paramName}");

                        args[i] = ConvertValueFromControl(inputControls[paramName], currentParameters[i].ParameterType);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при обработке входных данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Result = Activator.CreateInstance(selectedType, args);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
