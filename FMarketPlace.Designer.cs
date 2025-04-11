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
            lbInfo = new Label();
            panelItems = new Panel();
            cbObjects = new ComboBox();
            btnUndo = new Button();
            btnRedo = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItemImage).BeginInit();
            panelItems.SuspendLayout();
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
            txtbItems.Location = new Point(91, 65);
            txtbItems.Multiline = true;
            txtbItems.Name = "txtbItems";
            txtbItems.ReadOnly = true;
            txtbItems.ScrollBars = ScrollBars.Vertical;
            txtbItems.Size = new Size(234, 133);
            txtbItems.TabIndex = 4;
            // 
            // lbItemInfo
            // 
            lbItemInfo.AutoSize = true;
            lbItemInfo.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbItemInfo.Location = new Point(311, 21);
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
            panelInfo.Location = new Point(3, 123);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(899, 210);
            panelInfo.TabIndex = 6;
            // 
            // picItemImage
            // 
            picItemImage.BorderStyle = BorderStyle.FixedSingle;
            picItemImage.Location = new Point(704, 48);
            picItemImage.Name = "picItemImage";
            picItemImage.Size = new Size(150, 150);
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
            // lbInfo
            // 
            lbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbInfo.AutoSize = true;
            lbInfo.Font = new Font("Ebrima", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbInfo.Location = new Point(359, 10);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(160, 25);
            lbInfo.TabIndex = 3;
            lbInfo.Text = "Выберите товар";
            // 
            // panelItems
            // 
            panelItems.BackColor = Color.MediumOrchid;
            panelItems.Controls.Add(cbObjects);
            panelItems.Controls.Add(lbInfo);
            panelItems.Location = new Point(0, 38);
            panelItems.Name = "panelItems";
            panelItems.Size = new Size(899, 79);
            panelItems.TabIndex = 3;
            panelItems.Paint += panelItems_Paint;
            // 
            // cbObjects
            // 
            cbObjects.FormattingEnabled = true;
            cbObjects.Location = new Point(359, 38);
            cbObjects.Name = "cbObjects";
            cbObjects.Size = new Size(160, 23);
            cbObjects.TabIndex = 4;
            cbObjects.SelectedIndexChanged += cbObjects_SelectedIndexChanged;
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
            // FMarketPlace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(898, 522);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnRedo);
            Controls.Add(btnUndo);
            Controls.Add(btnCreate);
            Controls.Add(panelInfo);
            Controls.Add(panelItems);
            Controls.Add(LabelTitle);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FMarketPlace";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarketPlace";
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItemImage).EndInit();
            panelItems.ResumeLayout(false);
            panelItems.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label LabelTitle;
        private TextBox txtbItems;
        private Label lbItemInfo;
        private Panel panelInfo;
        private PictureBox picItemImage;
        private Button btnCreate;
        private Label lbInfo;
        private Panel panelItems;
        private ComboBox cbObjects;
        private Button btnUndo;
        private Button btnRedo;
        private Button btnEdit;
        private Button btnDelete;
    }
}
