namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    partial class CreateSquadForm
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
            txtNameSquad = new TextBox();
            checkedListBoxUnits = new CheckedListBox();
            btnCreateSquad = new Button();
            btnCancelSquad = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(35, 21);
            label1.Name = "label1";
            label1.Size = new Size(221, 46);
            label1.TabIndex = 0;
            label1.Text = "Create Squad";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 85);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // txtNameSquad
            // 
            txtNameSquad.Location = new Point(120, 82);
            txtNameSquad.Name = "txtNameSquad";
            txtNameSquad.Size = new Size(100, 23);
            txtNameSquad.TabIndex = 2;
            // 
            // checkedListBoxUnits
            // 
            checkedListBoxUnits.FormattingEnabled = true;
            checkedListBoxUnits.Location = new Point(55, 155);
            checkedListBoxUnits.Name = "checkedListBoxUnits";
            checkedListBoxUnits.Size = new Size(184, 148);
            checkedListBoxUnits.TabIndex = 3;
            // 
            // btnCreateSquad
            // 
            btnCreateSquad.Location = new Point(55, 389);
            btnCreateSquad.Name = "btnCreateSquad";
            btnCreateSquad.Size = new Size(75, 23);
            btnCreateSquad.TabIndex = 4;
            btnCreateSquad.Text = "Create";
            btnCreateSquad.UseVisualStyleBackColor = true;
            btnCreateSquad.Click += btnCreateSquad_Click;
            // 
            // btnCancelSquad
            // 
            btnCancelSquad.Location = new Point(164, 389);
            btnCancelSquad.Name = "btnCancelSquad";
            btnCancelSquad.Size = new Size(75, 23);
            btnCancelSquad.TabIndex = 5;
            btnCancelSquad.Text = "Cancel";
            btnCancelSquad.UseVisualStyleBackColor = true;
            btnCancelSquad.Click += btnCancelSquad_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 137);
            label3.Name = "label3";
            label3.Size = new Size(154, 15);
            label3.TabIndex = 6;
            label3.Text = "Select Units to add to squad";
            // 
            // CreateSquadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 450);
            Controls.Add(label3);
            Controls.Add(btnCancelSquad);
            Controls.Add(btnCreateSquad);
            Controls.Add(checkedListBoxUnits);
            Controls.Add(txtNameSquad);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CreateSquadForm";
            Text = "CreateSquadForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNameSquad;
        private CheckedListBox checkedListBoxUnits;
        private Button btnCreateSquad;
        private Button btnCancelSquad;
        private Label label3;
    }
}