namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    partial class CreateMissionForm
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
            lblTitel = new Label();
            lblName = new Label();
            lblDesc = new Label();
            lblTerrain = new Label();
            lblDuration = new Label();
            lblSecounds = new Label();
            txtName = new TextBox();
            txtDesc = new TextBox();
            comboBoxTerrain = new ComboBox();
            numericDuration = new NumericUpDown();
            btnCreate = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericDuration).BeginInit();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 25F);
            lblTitel.Location = new Point(32, 9);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(241, 46);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Create Mission";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F);
            lblName.Location = new Point(20, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(45, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name: ";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(20, 115);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(70, 15);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Description:";
            // 
            // lblTerrain
            // 
            lblTerrain.AutoSize = true;
            lblTerrain.Location = new Point(20, 143);
            lblTerrain.Name = "lblTerrain";
            lblTerrain.Size = new Size(49, 15);
            lblTerrain.TabIndex = 3;
            lblTerrain.Text = "Terrain: ";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(20, 171);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(59, 15);
            lblDuration.TabIndex = 4;
            lblDuration.Text = "Duration: ";
            // 
            // lblSecounds
            // 
            lblSecounds.AutoSize = true;
            lblSecounds.Location = new Point(211, 171);
            lblSecounds.Name = "lblSecounds";
            lblSecounds.Size = new Size(51, 15);
            lblSecounds.TabIndex = 5;
            lblSecounds.Text = "Seconds";
            // 
            // txtName
            // 
            txtName.Location = new Point(104, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(104, 107);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(100, 23);
            txtDesc.TabIndex = 7;
            // 
            // comboBoxTerrain
            // 
            comboBoxTerrain.FormattingEnabled = true;
            comboBoxTerrain.Location = new Point(104, 135);
            comboBoxTerrain.Name = "comboBoxTerrain";
            comboBoxTerrain.Size = new Size(100, 23);
            comboBoxTerrain.TabIndex = 8;
            // 
            // numericDuration
            // 
            numericDuration.Location = new Point(104, 164);
            numericDuration.Name = "numericDuration";
            numericDuration.Size = new Size(100, 23);
            numericDuration.TabIndex = 9;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(42, 380);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 10;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(160, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CreateMissionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnCreate);
            Controls.Add(numericDuration);
            Controls.Add(comboBoxTerrain);
            Controls.Add(txtDesc);
            Controls.Add(txtName);
            Controls.Add(lblSecounds);
            Controls.Add(lblDuration);
            Controls.Add(lblTerrain);
            Controls.Add(lblDesc);
            Controls.Add(lblName);
            Controls.Add(lblTitel);
            Name = "CreateMissionForm";
            Text = "CreateMissionForm";
            ((System.ComponentModel.ISupportInitialize)numericDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Label lblName;
        private Label lblDesc;
        private Label lblTerrain;
        private Label lblDuration;
        private Label lblSecounds;
        private TextBox txtName;
        private TextBox txtDesc;
        private ComboBox comboBoxTerrain;
        private NumericUpDown numericDuration;
        private Button btnCreate;
        private Button btnCancel;
    }
}