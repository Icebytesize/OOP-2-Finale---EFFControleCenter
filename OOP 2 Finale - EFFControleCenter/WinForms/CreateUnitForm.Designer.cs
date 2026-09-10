namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    partial class CreateUnitForm
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
            btnCreate = new Button();
            btnCancel = new Button();
            comboBoxUnitType = new ComboBox();
            txtUnitName = new TextBox();
            lblUnitName = new Label();
            lblUnitType = new Label();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(283, 345);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(389, 345);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // comboBoxUnitType
            // 
            comboBoxUnitType.FormattingEnabled = true;
            comboBoxUnitType.Location = new Point(318, 102);
            comboBoxUnitType.Name = "comboBoxUnitType";
            comboBoxUnitType.Size = new Size(121, 23);
            comboBoxUnitType.TabIndex = 2;
            // 
            // txtUnitName
            // 
            txtUnitName.Location = new Point(318, 52);
            txtUnitName.Name = "txtUnitName";
            txtUnitName.Size = new Size(121, 23);
            txtUnitName.TabIndex = 3;
            // 
            // lblUnitName
            // 
            lblUnitName.AutoSize = true;
            lblUnitName.Location = new Point(270, 55);
            lblUnitName.Name = "lblUnitName";
            lblUnitName.Size = new Size(42, 15);
            lblUnitName.TabIndex = 4;
            lblUnitName.Text = "Name:";
            // 
            // lblUnitType
            // 
            lblUnitType.AutoSize = true;
            lblUnitType.Location = new Point(277, 105);
            lblUnitType.Name = "lblUnitType";
            lblUnitType.Size = new Size(35, 15);
            lblUnitType.TabIndex = 5;
            lblUnitType.Text = "Type:";
            // 
            // CreateUnitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUnitType);
            Controls.Add(lblUnitName);
            Controls.Add(txtUnitName);
            Controls.Add(comboBoxUnitType);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Name = "CreateUnitForm";
            Text = "CreateUnitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnCancel;
        private ComboBox comboBoxUnitType;
        private TextBox txtUnitName;
        private Label lblUnitName;
        private Label lblUnitType;
    }
}