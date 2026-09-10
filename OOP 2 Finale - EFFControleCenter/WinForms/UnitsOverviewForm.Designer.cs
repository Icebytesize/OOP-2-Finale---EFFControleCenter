namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    partial class UnitsOverviewForm
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
            btnViewDetails = new Button();
            btnClose = new Button();
            dataGridViewUnits = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).BeginInit();
            SuspendLayout();
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Font = new Font("Segoe UI", 30F);
            lblTitel.Location = new Point(362, 9);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(288, 54);
            lblTitel.TabIndex = 0;
            lblTitel.Text = "Units Overview";
            // 
            // btnViewDetails
            // 
            btnViewDetails.Location = new Point(362, 498);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(98, 23);
            btnViewDetails.TabIndex = 1;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(575, 498);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 2;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridViewUnits
            // 
            dataGridViewUnits.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnits.Location = new Point(12, 80);
            dataGridViewUnits.Name = "dataGridViewUnits";
            dataGridViewUnits.Size = new Size(1058, 392);
            dataGridViewUnits.TabIndex = 3;
            // 
            // UnitsOverviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 535);
            Controls.Add(dataGridViewUnits);
            Controls.Add(btnClose);
            Controls.Add(btnViewDetails);
            Controls.Add(lblTitel);
            Name = "UnitsOverviewForm";
            Text = "UnitsOverviewForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnits).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitel;
        private Button btnViewDetails;
        private Button btnClose;
        private DataGridView dataGridViewUnits;
    }
}