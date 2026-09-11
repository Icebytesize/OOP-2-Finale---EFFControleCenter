namespace OOP_2_Finale___EFFControleCenter.WinForms
{
    partial class MissionRoomForm
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
            lblMissionRoom = new Label();
            dataGridViewMission = new DataGridView();
            this.btnStartMission = new Button();
            this.btnRefresh = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMission).BeginInit();
            SuspendLayout();
            // 
            // lblMissionRoom
            // 
            lblMissionRoom.AutoSize = true;
            lblMissionRoom.Font = new Font("Segoe UI", 30F);
            lblMissionRoom.Location = new Point(230, 30);
            lblMissionRoom.Name = "lblMissionRoom";
            lblMissionRoom.Size = new Size(273, 54);
            lblMissionRoom.TabIndex = 0;
            lblMissionRoom.Text = "Mission Room";
            // 
            // dataGridViewMission
            // 
            dataGridViewMission.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMission.Location = new Point(12, 87);
            dataGridViewMission.Name = "dataGridViewMission";
            dataGridViewMission.Size = new Size(776, 304);
            dataGridViewMission.TabIndex = 1;
            // 
            // btnStartMission
            // 
            this.btnStartMission.Location = new Point(102, 410);
            this.btnStartMission.Name = "btnStartMission";
            this.btnStartMission.Size = new Size(85, 23);
            this.btnStartMission.TabIndex = 2;
            this.btnStartMission.Text = "Start Mission";
            this.btnStartMission.UseVisualStyleBackColor = true;
            this.btnStartMission.Click += this.btnStartMission_Click;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new Point(343, 410);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(612, 410);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MissionRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(this.btnRefresh);
            Controls.Add(this.btnStartMission);
            Controls.Add(dataGridViewMission);
            Controls.Add(lblMissionRoom);
            Name = "MissionRoomForm";
            Text = "MissionRoomForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMission).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMissionRoom;
        private DataGridView dataGridViewMission;
        private Button btnStartMission;
        private Button btnRefresh;
        private Button btnClose;
    }
}