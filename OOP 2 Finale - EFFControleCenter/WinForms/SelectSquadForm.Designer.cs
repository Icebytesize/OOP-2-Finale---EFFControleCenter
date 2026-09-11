namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    partial class SelectSquadForm
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnStartMission = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(86, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(281, 25);
            label1.TabIndex = 1;
            label1.Text = "Select squad to send on mission";
            // 
            // btnStartMission
            // 
            btnStartMission.Location = new Point(29, 149);
            btnStartMission.Name = "btnStartMission";
            btnStartMission.Size = new Size(86, 23);
            btnStartMission.TabIndex = 2;
            btnStartMission.Text = "Start Mission";
            btnStartMission.UseVisualStyleBackColor = true;
            btnStartMission.Click += btnStartMission_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(186, 149);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // SelectSquadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 225);
            Controls.Add(btnCancel);
            Controls.Add(btnStartMission);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "SelectSquadForm";
            Text = "SelectSquadForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button btnStartMission;
        private Button btnCancel;
    }
}