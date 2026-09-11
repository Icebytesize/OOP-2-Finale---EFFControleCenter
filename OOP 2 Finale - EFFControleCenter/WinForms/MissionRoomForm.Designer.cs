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
            btnStartMission = new Button();
            btnRefresh = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMission).BeginInit();
            SuspendLayout();
            // 
            // lblMissionRoom
            // 
            lblMissionRoom.AutoSize = true;
            lblMissionRoom.Font = new Font("Segoe UI", 30F);
            lblMissionRoom.Location = new Point(263, 40);
            lblMissionRoom.Name = "lblMissionRoom";
            lblMissionRoom.Size = new Size(341, 67);
            lblMissionRoom.TabIndex = 0;
            lblMissionRoom.Text = "Mission Room";
            // 
            // dataGridViewMission
            // 
            dataGridViewMission.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMission.Location = new Point(14, 116);
            dataGridViewMission.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMission.Name = "dataGridViewMission";
            dataGridViewMission.RowHeadersWidth = 51;
            dataGridViewMission.Size = new Size(887, 405);
            dataGridViewMission.TabIndex = 1;
            // 
            // btnStartMission
            // 
            btnStartMission.Location = new Point(117, 547);
            btnStartMission.Margin = new Padding(3, 4, 3, 4);
            btnStartMission.Name = "btnStartMission";
            btnStartMission.Size = new Size(97, 31);
            btnStartMission.TabIndex = 2;
            btnStartMission.Text = "Start Mission";
            btnStartMission.UseVisualStyleBackColor = true;
            btnStartMission.Click += btnStartMission_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(392, 547);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 31);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(699, 547);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 31);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // MissionRoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnClose);
            Controls.Add(btnRefresh);
            Controls.Add(btnStartMission);
            Controls.Add(dataGridViewMission);
            Controls.Add(lblMissionRoom);
            Margin = new Padding(3, 4, 3, 4);
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