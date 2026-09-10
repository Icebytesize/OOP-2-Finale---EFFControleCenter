namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    partial class MainForm
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
            dataGridViewUnits = new DataGridView();
            btnCreateUnit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUnits
            // 
            dataGridViewUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnits.Location = new Point(119, 32);
            dataGridViewUnits.MultiSelect = false;
            dataGridViewUnits.Name = "dataGridViewUnits";
            dataGridViewUnits.ReadOnly = true;
            dataGridViewUnits.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUnits.Size = new Size(535, 287);
            dataGridViewUnits.TabIndex = 0;
            // 
            // btnCreateUnit
            // 
            btnCreateUnit.Location = new Point(141, 346);
            btnCreateUnit.Name = "btnCreateUnit";
            btnCreateUnit.Size = new Size(75, 23);
            btnCreateUnit.TabIndex = 1;
            btnCreateUnit.Text = "Create Unit";
            btnCreateUnit.UseVisualStyleBackColor = true;
            btnCreateUnit.Click += btnCreateUnit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreateUnit);
            Controls.Add(dataGridViewUnits);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUnits;
        private Button btnCreateUnit;
    }
}