namespace MainApp
{
    partial class FMarketPlace
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LabelTitle = new Label();
            txtbItems = new TextBox();
            lbItemInfo = new Label();
            panelInfo = new Panel();
            picItemImage = new PictureBox();
            btnCreate = new Button();
            panelSeparator = new Panel();
            menuStrip1 = new MenuStrip();
            miFile = new ToolStripMenuItem();
            miSaveJson = new ToolStripMenuItem();
            miLoadJson = new ToolStripMenuItem();
            miSaveXml = new ToolStripMenuItem();
            miLoadXml = new ToolStripMenuItem();
            miDLL = new ToolStripMenuItem();
            miPlugin = new ToolStripMenuItem();
            btnUndo = new Button();
            btnRedo = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            pItems = new Panel();
            lbItems = new Label();
            lbProducts = new ListBox();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItemImage).BeginInit();
            panelSeparator.SuspendLayout();
            menuStrip1.SuspendLayout();
            pItems.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.BackColor = Color.SlateBlue;
            LabelTitle.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelTitle.ForeColor = Color.AliceBlue;
            LabelTitle.Location = new Point(0, 0);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(899, 35);
            LabelTitle.TabIndex = 0;
            LabelTitle.Text = "MarketPlace";
            LabelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtbItems
            // 
            txtbItems.Location = new Point(75, 65);
            txtbItems.Multiline = true;
            txtbItems.Name = "txtbItems";
            txtbItems.ReadOnly = true;
            txtbItems.ScrollBars = ScrollBars.Vertical;
            txtbItems.Size = new Size(234, 199);
            txtbItems.TabIndex = 4;
            // 
            // lbItemInfo
            // 
            lbItemInfo.AutoSize = true;
            lbItemInfo.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbItemInfo.Location = new Point(159, 18);
            lbItemInfo.Name = "lbItemInfo";
            lbItemInfo.Size = new Size(264, 27);
            lbItemInfo.TabIndex = 5;
            lbItemInfo.Text = "Информация о предмете";
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.Plum;
            panelInfo.Controls.Add(picItemImage);
            panelInfo.Controls.Add(lbItemInfo);
            panelInfo.Controls.Add(txtbItems);
            panelInfo.Location = new Point(359, 123);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(527, 274);
            panelInfo.TabIndex = 6;
            // 
            // picItemImage
            // 
            picItemImage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picItemImage.BorderStyle = BorderStyle.FixedSingle;
            picItemImage.Location = new Point(342, 65);
            picItemImage.Name = "picItemImage";
            picItemImage.Size = new Size(170, 199);
            picItemImage.SizeMode = PictureBoxSizeMode.Zoom;
            picItemImage.TabIndex = 6;
            picItemImage.TabStop = false;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCreate.Location = new Point(12, 438);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(144, 72);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Добавить товар";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // panelSeparator
            // 
            panelSeparator.BackColor = Color.MediumOrchid;
            panelSeparator.Controls.Add(menuStrip1);
            panelSeparator.Location = new Point(0, 38);
            panelSeparator.Name = "panelSeparator";
            panelSeparator.Size = new Size(898, 79);
            panelSeparator.TabIndex = 3;
            panelSeparator.Paint += panelItems_Paint;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { miFile, miDLL, miPlugin });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(898, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // miFile
            // 
            miFile.DropDownItems.AddRange(new ToolStripItem[] { miSaveJson, miLoadJson, miSaveXml, miLoadXml });
            miFile.Name = "miFile";
            miFile.Size = new Size(48, 20);
            miFile.Text = "Файл";
            // 
            // miSaveJson
            // 
            miSaveJson.Name = "miSaveJson";
            miSaveJson.Size = new Size(163, 22);
            miSaveJson.Text = "Сохранить JSON";
            miSaveJson.Click += miSaveJson_Click;
            // 
            // miLoadJson
            // 
            miLoadJson.Name = "miLoadJson";
            miLoadJson.Size = new Size(163, 22);
            miLoadJson.Text = "Загрузить JSON";
            miLoadJson.Click += miLoadJson_Click;
            // 
            // miSaveXml
            // 
            miSaveXml.Name = "miSaveXml";
            miSaveXml.Size = new Size(163, 22);
            miSaveXml.Text = "Сохранить XML";
            miSaveXml.Click += miSaveXml_Click;
            // 
            // miLoadXml
            // 
            miLoadXml.Name = "miLoadXml";
            miLoadXml.Size = new Size(163, 22);
            miLoadXml.Text = "Загрузить XML";
            miLoadXml.Click += miLoadXml_Click;
            // 
            // miDLL
            // 
            miDLL.Name = "miDLL";
            miDLL.Size = new Size(96, 20);
            miDLL.Text = "Загрузить DLL";
            miDLL.Click += miDLL_Click;
            // 
            // miPlugin
            // 
            miPlugin.Name = "miPlugin";
            miPlugin.Size = new Size(115, 20);
            miPlugin.Text = "Загрузить плагин";
            miPlugin.Click += miPlugin_Click;
            // 
            // btnUndo
            // 
            btnUndo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnUndo.Location = new Point(635, 456);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(97, 56);
            btnUndo.TabIndex = 8;
            btnUndo.Text = "Отменить";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnRedo
            // 
            btnRedo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnRedo.Location = new Point(789, 456);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(97, 56);
            btnRedo.TabIndex = 9;
            btnRedo.Text = "Отменить отмену";
            btnRedo.UseVisualStyleBackColor = true;
            btnRedo.Click += btnRedo_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEdit.Location = new Point(196, 438);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 72);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Изменить объект";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelete.Location = new Point(359, 438);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 72);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Удалить объект";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // pItems
            // 
            pItems.BackColor = Color.Violet;
            pItems.Controls.Add(lbItems);
            pItems.Controls.Add(lbProducts);
            pItems.Location = new Point(3, 123);
            pItems.Name = "pItems";
            pItems.Size = new Size(350, 274);
            pItems.TabIndex = 12;
            // 
            // lbItems
            // 
            lbItems.AutoSize = true;
            lbItems.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lbItems.Location = new Point(136, 18);
            lbItems.Name = "lbItems";
            lbItems.Size = new Size(88, 30);
            lbItems.TabIndex = 1;
            lbItems.Text = "Товары";
            // 
            // lbProducts
            // 
            lbProducts.FormattingEnabled = true;
            lbProducts.ItemHeight = 15;
            lbProducts.Location = new Point(76, 65);
            lbProducts.Name = "lbProducts";
            lbProducts.Size = new Size(215, 199);
            lbProducts.TabIndex = 0;
            lbProducts.SelectedIndexChanged += lbProducts_SelectedIndexChanged;
            // 
            // FMarketPlace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(898, 522);
            Controls.Add(pItems);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnRedo);
            Controls.Add(btnUndo);
            Controls.Add(btnCreate);
            Controls.Add(panelInfo);
            Controls.Add(panelSeparator);
            Controls.Add(LabelTitle);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FMarketPlace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPlace";
            Load += FMarketPlace_Load;
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItemImage).EndInit();
            panelSeparator.ResumeLayout(false);
            panelSeparator.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pItems.ResumeLayout(false);
            pItems.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelTitle;
        private TextBox txtbItems;
        private Label lbItemInfo;
        private Panel panelInfo;
        private PictureBox picItemImage;
        private Button btnCreate;
        private Panel panelSeparator;
        private Button btnUndo;
        private Button btnRedo;
        private Button btnEdit;
        private Button btnDelete;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem miFile;
        private ToolStripMenuItem miDLL;
        private ToolStripMenuItem miSaveJson;
        private ToolStripMenuItem miLoadJson;
        private ToolStripMenuItem miSaveXml;
        private ToolStripMenuItem miLoadXml;
        private ToolStripMenuItem miPlugin;
        private Panel pItems;
        private Label lbItems;
        private ListBox lbProducts;
    }
}
