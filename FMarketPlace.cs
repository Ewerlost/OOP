using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;
using OOPCore;

namespace MainApp
{
    public partial class FMarketPlace : Form
    {
        private List<object> createdObjects = new();
        private IPluginSerializer _plugin;

        public FMarketPlace()
        {
            InitializeComponent();
            RefreshListBox();
        }

        private void UpdateInterface()
        {

        }


        private void rbRole_CheckedChanged(object sender, EventArgs e)
        {
            UpdateInterface();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using fCreate createForm = new fCreate();
            if (createForm.ShowDialog() == DialogResult.OK && createForm.Result != null)
            {
                var cmd = new CreateObjectCommand(createdObjects, createForm.Result);
                Program.CommandManager.ExecuteCommand(cmd);
                RefreshListBox();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Program.CommandManager.Undo();
            RefreshListBox();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            Program.CommandManager.Redo();
            RefreshListBox();
        }

        private void panelItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedItem == null)
            {
                MessageBox.Show("Выберите объект для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object selectedObject = lbProducts.SelectedItem;
            using fCreate editForm = new fCreate(selectedObject);
            if (editForm.ShowDialog() == DialogResult.OK && editForm.Result != null)
            {
                RefreshListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedItem == null)
            {
                MessageBox.Show("Выберите объект для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            object selectedObject = lbProducts.SelectedItem;
            var cmd = new DeleteObjectCommand(createdObjects, selectedObject);
            Program.CommandManager.ExecuteCommand(cmd);
            RefreshListBox();
        }

        private void miDLL_Click(object sender, EventArgs e)
        {
            // Открываем диалог выбора файла
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "DLL files (*.dll)|*.dll";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Type> newTypes = DllLoader.LoadProductTypes(ofd.FileName);

                    if (newTypes.Count > 0)
                    {
                        // Добавляем новые типы в KnownTypes для JSON-конвертера
                        foreach (var t in newTypes)
                        {
                            EntityJsonConverter.RegisterType(t.Name, t);
                        }

                        // Если вы используете аналогичный подход для XML, обновите список известных типов там тоже.
                        // Например, обновите кэш в XmlKnownTypesProvider (если он реализован с кешированием).

                        // Обновляем ComboBox в форме создания объектов:
                        // можно либо перезагрузить всю коллекцию через ReflectiveFactory.GetCreatableTypes(),
                        // либо добавить новые типы в словарь availableTypes в CreateForm.
                        MessageBox.Show("DLL успешно загружена. Найдено новых типов: " + newTypes.Count);
                    }
                    else
                    {
                        MessageBox.Show("В выбранном файле отсутствуют пригодные для создания объекты типы.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка загрузки DLL: " + ex.Message);
                }
            }
        }

        private void miSaveJson_Click(object sender, EventArgs e)
        {
            

            // Готовим список Entity
            var list = createdObjects
                .OfType<Entity>()
                .ToList();
            using var sfd = new SaveFileDialog();
            if (_plugin != null)
            {
                sfd.Filter = "XML через плагин (*.xml)|*.xml";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                // Плагин сам делает JSON→XML
                try
                {
                    _plugin.Save(list, sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении JSON -> XML: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Сохранение выполнено успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                sfd.Filter = "JSON-файлы (*.json)|*.json";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    PersistenceManager.SaveToJson(sfd.FileName, list);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при сохранении JSON: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Сохранение выполнено успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void miLoadJson_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog();
            if (_plugin != null)
            {
                ofd.Filter = "XML через плагин (*.xml)|*.xml";
                if (ofd.ShowDialog() != DialogResult.OK) return;
                var loaded = _plugin.Load(ofd.FileName);
                createdObjects.AddRange(loaded.Cast<object>());
            }

            else
            {
                ofd.Filter = "JSON-файлы (*.json)|*.json";
                if (ofd.ShowDialog() != DialogResult.OK) return;
                var loaded = PersistenceManager.LoadFromJson(ofd.FileName);
                createdObjects.AddRange(loaded.Cast<object>());
            }
            RefreshListBox();  
            MessageBox.Show("Загрузка выполнена успешно.", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void miSaveXml_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog { Filter = "XML (*.xml)|*.xml" };
            if (sfd.ShowDialog() != DialogResult.OK) return;

            var list = createdObjects.OfType<Entity>().ToList();
            PersistenceManager.SaveToXml(sfd.FileName, list);
            MessageBox.Show("Сохранено в XML");
        }

        private void miLoadXml_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog { Filter = "XML (*.xml)|*.xml" };
            if (ofd.ShowDialog() != DialogResult.OK) return;

            var loaded = PersistenceManager.LoadFromXml(ofd.FileName);
            createdObjects.AddRange(loaded);
            RefreshListBox();
            MessageBox.Show($"Загружено {loaded.Count} объектов из XML");
        }

        private void RefreshListBox()
        {
            lbProducts.DataSource = null;
            lbProducts.DisplayMember = "Name";
            lbProducts.DataSource = createdObjects;
        }

        private void FMarketPlace_Load(object sender, EventArgs e)
        {

        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранный объект
            if (lbProducts.SelectedItem is Entity selected)
            {
                // 1) Вывод подробностей
                txtbItems.Text = selected.ToString();

                // 2) Если это Product с ImagePath — грузим картинку
                if (selected is Product prod && !string.IsNullOrEmpty(prod.ImagePath))
                {
                    try
                    {
                        picItemImage.Image = Image.FromFile(prod.ImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка загрузки изображения: " + ex.Message,
                                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        picItemImage.Image = null;
                    }
                }
                else
                {
                    picItemImage.Image = null;
                }
            }
            else
            {
                txtbItems.Text = "";
                picItemImage.Image = null;
            }
        }

        private void miPlugin_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "DLL-файлы (*.dll)|*.dll",
                Title = "Выберите плагин-сериализатор"
            };
            if (ofd.ShowDialog() != DialogResult.OK) return;

            try
            {
                var asm = Assembly.LoadFrom(ofd.FileName);
                // Находим первый тип, реализующий IPluginSerializer
                var pluginType = asm.GetTypes()
                    .FirstOrDefault(t => typeof(IPluginSerializer).IsAssignableFrom(t)
                                         && !t.IsAbstract);
                if (pluginType == null)
                {
                    MessageBox.Show("В DLL нет класса IPluginSerializer.", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _plugin = (IPluginSerializer)Activator.CreateInstance(pluginType);
                MessageBox.Show($"Загружен плагин: {_plugin.Name}", "Плагин",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не удалось загрузить плагин:\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
