namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    partial class CreatePilotForm
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
            txtName = new TextBox();
            lblName = new Label();
            label1 = new Label();
            btnCreatePilot = new Button();
            btnCancelPilot = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(111, 101);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(63, 104);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(47, 22);
            label1.Name = "label1";
            label1.Size = new Size(194, 46);
            label1.TabIndex = 2;
            label1.Text = "Create Pilot";
            // 
            // btnCreatePilot
            // 
            btnCreatePilot.Location = new Point(47, 381);
            btnCreatePilot.Name = "btnCreatePilot";
            btnCreatePilot.Size = new Size(75, 23);
            btnCreatePilot.TabIndex = 3;
            btnCreatePilot.Text = "Create";
            btnCreatePilot.UseVisualStyleBackColor = true;
            btnCreatePilot.Click += btnCreatePilot_Click;
            // 
            // btnCancelPilot
            // 
            btnCancelPilot.Location = new Point(166, 381);
            btnCancelPilot.Name = "btnCancelPilot";
            btnCancelPilot.Size = new Size(75, 23);
            btnCancelPilot.TabIndex = 4;
            btnCancelPilot.Text = "Cancel";
            btnCancelPilot.UseVisualStyleBackColor = true;
            btnCancelPilot.Click += btnCancelPilot_Click;
            // 
            // CreatePilotForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 450);
            Controls.Add(btnCancelPilot);
            Controls.Add(btnCreatePilot);
            Controls.Add(label1);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "CreatePilotForm";
            Text = "CreatePilotForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label lblName;
        private Label label1;
        private Button button1;
        private Button btnCreatePilot;
        private Button btnCancelPilot;
    }
}