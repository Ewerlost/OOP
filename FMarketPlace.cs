using System.Windows.Forms;

namespace MainApp
{
    public partial class FMarketPlace : Form
    {
        private List<object> createdObjects = new();

        public FMarketPlace()
        {
            InitializeComponent();
            RefreshComboBox();
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
                RefreshComboBox();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Program.CommandManager.Undo();
            RefreshComboBox();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            Program.CommandManager.Redo();
            RefreshComboBox();
        }

        private void RefreshComboBox()
        {
            cbObjects.DataSource = null;
            cbObjects.DisplayMember = "Name";
            cbObjects.ValueMember = null;
            cbObjects.DataSource = createdObjects;
        }

        private void panelItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (cbObjects.SelectedItem == null)
            {
                MessageBox.Show("Выберите объект для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object selectedObject = cbObjects.SelectedItem;
            using fCreate editForm = new fCreate(selectedObject);
            if (editForm.ShowDialog() == DialogResult.OK && editForm.Result != null)
            {
                RefreshComboBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbObjects.SelectedItem == null)
            {
                MessageBox.Show("Выберите объект для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            object selectedObject = cbObjects.SelectedItem;
            var cmd = new DeleteObjectCommand(createdObjects, selectedObject);
            Program.CommandManager.ExecuteCommand(cmd);
            RefreshComboBox();
        }

        private void cbObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cbObjects.SelectedItem as Product;
            if (selected == null)
            {
                picItemImage.Image = null;
                txtbItems.Text = "";
                return;
            }
            if (selected is Product product)
            {
                if (!string.IsNullOrEmpty(product.ImagePath))
                {
                    try
                    {
                        picItemImage.Image = Image.FromFile(product.ImagePath);
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
                txtbItems.Text = selected.ToString();
            }
            else
            {
                picItemImage.Image = null;
                txtbItems.Text = "";
            }
        }
    }
}
