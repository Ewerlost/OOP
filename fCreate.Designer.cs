namespace MainApp
{
    partial class fCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbTypes = new ComboBox();
            lbClasses = new Label();
            panelParameters = new Panel();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // cbTypes
            // 
            cbTypes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbTypes.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cbTypes.FormattingEnabled = true;
            cbTypes.Location = new Point(105, 58);
            cbTypes.Name = "cbTypes";
            cbTypes.Size = new Size(121, 33);
            cbTypes.TabIndex = 0;
            cbTypes.SelectedIndexChanged += cbTypes_SelectedIndexChanged;
            // 
            // lbClasses
            // 
            lbClasses.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbClasses.AutoSize = true;
            lbClasses.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lbClasses.Location = new Point(68, 18);
            lbClasses.Name = "lbClasses";
            lbClasses.Size = new Size(207, 25);
            lbClasses.TabIndex = 1;
            lbClasses.Text = "Выберите тип объекта";
            // 
            // panelParameters
            // 
            panelParameters.Dock = DockStyle.Bottom;
            panelParameters.Location = new Point(0, 105);
            panelParameters.Name = "panelParameters";
            panelParameters.Size = new Size(800, 345);
            panelParameters.TabIndex = 2;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnOK.Location = new Point(451, 52);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(135, 39);
            btnOK.TabIndex = 3;
            btnOK.Text = "Подтвердить";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.Location = new Point(672, 52);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 39);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Отменить";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // fCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(panelParameters);
            Controls.Add(lbClasses);
            Controls.Add(cbTypes);
            Name = "fCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fCreate";
            Load += fCreate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTypes;
        private Label lbClasses;
        private Panel panelParameters;
        private Button btnOK;
        private Button btnCancel;
    }
}