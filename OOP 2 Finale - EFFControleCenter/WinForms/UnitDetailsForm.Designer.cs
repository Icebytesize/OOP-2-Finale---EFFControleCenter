namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    partial class UnitDetailsForm
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
            lblName = new Label();
            lblType = new Label();
            lblHealth = new Label();
            lblEnergy = new Label();
            lblAvailable = new Label();
            comboBoxPilot = new ComboBox();
            checkedListBoxWeapons = new CheckedListBox();
            btnSave = new Button();
            btnRemoveUnit = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(58, 29);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 15);
            lblName.TabIndex = 0;
            lblName.Text = "label1";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(58, 53);
            lblType.Name = "lblType";
            lblType.Size = new Size(38, 15);
            lblType.TabIndex = 1;
            lblType.Text = "label2";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Location = new Point(58, 80);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(38, 15);
            lblHealth.TabIndex = 2;
            lblHealth.Text = "label3";
            // 
            // lblEnergy
            // 
            lblEnergy.AutoSize = true;
            lblEnergy.Location = new Point(58, 108);
            lblEnergy.Name = "lblEnergy";
            lblEnergy.Size = new Size(38, 15);
            lblEnergy.TabIndex = 3;
            lblEnergy.Text = "label4";
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(58, 136);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(38, 15);
            lblAvailable.TabIndex = 4;
            lblAvailable.Text = "label5";
            // 
            // comboBoxPilot
            // 
            comboBoxPilot.FormattingEnabled = true;
            comboBoxPilot.Location = new Point(58, 169);
            comboBoxPilot.Name = "comboBoxPilot";
            comboBoxPilot.Size = new Size(121, 23);
            comboBoxPilot.TabIndex = 5;
            // 
            // checkedListBoxWeapons
            // 
            checkedListBoxWeapons.FormattingEnabled = true;
            checkedListBoxWeapons.Location = new Point(58, 210);
            checkedListBoxWeapons.Name = "checkedListBoxWeapons";
            checkedListBoxWeapons.Size = new Size(263, 94);
            checkedListBoxWeapons.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(60, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save changes";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRemoveUnit
            // 
            btnRemoveUnit.Location = new Point(154, 383);
            btnRemoveUnit.Name = "btnRemoveUnit";
            btnRemoveUnit.Size = new Size(86, 23);
            btnRemoveUnit.TabIndex = 8;
            btnRemoveUnit.Text = "Remove Unit";
            btnRemoveUnit.UseVisualStyleBackColor = true;
            btnRemoveUnit.Click += btnRemoveUnit_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(246, 383);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // UnitDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 450);
            Controls.Add(btnClose);
            Controls.Add(btnRemoveUnit);
            Controls.Add(btnSave);
            Controls.Add(checkedListBoxWeapons);
            Controls.Add(comboBoxPilot);
            Controls.Add(lblAvailable);
            Controls.Add(lblEnergy);
            Controls.Add(lblHealth);
            Controls.Add(lblType);
            Controls.Add(lblName);
            Name = "UnitDetailsForm";
            Text = "UnitDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblType;
        private Label lblHealth;
        private Label lblEnergy;
        private Label lblAvailable;
        private ComboBox comboBoxPilot;
        private CheckedListBox checkedListBoxWeapons;
        private Button btnSave;
        private Button btnRemoveUnit;
        private Button btnClose;
    }
}