namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    partial class CreateWeaponForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            this.textBoxName = new TextBox();
            this.textBoxDmg = new TextBox();
            textBoxEC = new TextBox();
            btnCreateWeapon = new Button();
            btnCancelWeapon = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(252, 46);
            label1.TabIndex = 0;
            label1.Text = "Create Weapon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 97);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 128);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 2;
            label3.Text = "Damage:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 157);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 3;
            label4.Text = "Energy cost:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new Point(111, 94);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new Size(116, 23);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxDmg
            // 
            this.textBoxDmg.Location = new Point(111, 123);
            this.textBoxDmg.Name = "textBoxDmg";
            this.textBoxDmg.Size = new Size(73, 23);
            this.textBoxDmg.TabIndex = 5;
            // 
            // textBoxEC
            // 
            textBoxEC.Location = new Point(111, 154);
            textBoxEC.Name = "textBoxEC";
            textBoxEC.Size = new Size(73, 23);
            textBoxEC.TabIndex = 6;
            // 
            // btnCreateWeapon
            // 
            btnCreateWeapon.Location = new Point(51, 328);
            btnCreateWeapon.Name = "btnCreateWeapon";
            btnCreateWeapon.Size = new Size(75, 23);
            btnCreateWeapon.TabIndex = 7;
            btnCreateWeapon.Text = "Create";
            btnCreateWeapon.UseVisualStyleBackColor = true;
            btnCreateWeapon.Click += btnCreateWeapon_Click;
            // 
            // btnCancelWeapon
            // 
            btnCancelWeapon.Location = new Point(162, 328);
            btnCancelWeapon.Name = "btnCancelWeapon";
            btnCancelWeapon.Size = new Size(75, 23);
            btnCancelWeapon.TabIndex = 8;
            btnCancelWeapon.Text = "Cancel";
            btnCancelWeapon.UseVisualStyleBackColor = true;
            btnCancelWeapon.Click += btnCancelWeapon_Click;
            // 
            // CreateWeaponForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 450);
            Controls.Add(btnCancelWeapon);
            Controls.Add(btnCreateWeapon);
            Controls.Add(textBoxEC);
            Controls.Add(this.textBoxDmg);
            Controls.Add(this.textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateWeaponForm";
            Text = "CreateWeaponForm";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
        private TextBox textBoxDmg;
        private TextBox textBoxEC;
        private Button btnCreateWeapon;
        private Button btnCancelWeapon;
    }
}