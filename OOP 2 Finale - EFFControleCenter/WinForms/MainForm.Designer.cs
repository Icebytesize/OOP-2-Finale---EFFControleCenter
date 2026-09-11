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
            components = new System.ComponentModel.Container();
            btnCreate = new Button();
            lblTitle = new Label();
            contextMenuStripCreate = new ContextMenuStrip(components);
            toolStripMenuUnit = new ToolStripMenuItem();
            toolStripMenuPilot = new ToolStripMenuItem();
            toolStripMenuSquad = new ToolStripMenuItem();
            toolStripMenuMission = new ToolStripMenuItem();
            toolStripMenuWeapon = new ToolStripMenuItem();
            contextMenuStripView = new ContextMenuStrip(components);
            toolStripViewUnit = new ToolStripMenuItem();
            toolStripViewPilot = new ToolStripMenuItem();
            toolStripViewWeapon = new ToolStripMenuItem();
            toolStripViewSquad = new ToolStripMenuItem();
            toolStripViewMission = new ToolStripMenuItem();
            btnView = new Button();
            ListLog = new ListBox();
            label1 = new Label();
            btnMissionRoom = new Button();
            btnQuickStart = new Button();
            contextMenuStripCreate.SuspendLayout();
            contextMenuStripView.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(41, 175);
            btnCreate.Margin = new Padding(3, 4, 3, 4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(86, 31);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreateUnit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTitle.Location = new Point(161, 44);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(584, 67);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "EFF CONTROLE CENTER";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // contextMenuStripCreate
            // 
            contextMenuStripCreate.ImageScalingSize = new Size(20, 20);
            contextMenuStripCreate.Items.AddRange(new ToolStripItem[] { toolStripMenuUnit, toolStripMenuPilot, toolStripMenuSquad, toolStripMenuMission, toolStripMenuWeapon });
            contextMenuStripCreate.Name = "contextMenuStrip1";
            contextMenuStripCreate.Size = new Size(134, 124);
            contextMenuStripCreate.Opening += contextMenuStripCreate_Opening;
            // 
            // toolStripMenuUnit
            // 
            toolStripMenuUnit.Name = "toolStripMenuUnit";
            toolStripMenuUnit.Size = new Size(133, 24);
            toolStripMenuUnit.Text = "Unit";
            toolStripMenuUnit.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuPilot
            // 
            toolStripMenuPilot.Name = "toolStripMenuPilot";
            toolStripMenuPilot.Size = new Size(133, 24);
            toolStripMenuPilot.Text = "Pilot";
            toolStripMenuPilot.Click += toolStripMenuPilot_Click;
            // 
            // toolStripMenuSquad
            // 
            toolStripMenuSquad.Name = "toolStripMenuSquad";
            toolStripMenuSquad.Size = new Size(133, 24);
            toolStripMenuSquad.Text = "Squad";
            toolStripMenuSquad.Click += toolStripMenuSquad_Click;
            // 
            // toolStripMenuMission
            // 
            toolStripMenuMission.Name = "toolStripMenuMission";
            toolStripMenuMission.Size = new Size(133, 24);
            toolStripMenuMission.Text = "Mission";
            toolStripMenuMission.Click += toolStripMenuMission_Click;
            // 
            // toolStripMenuWeapon
            // 
            toolStripMenuWeapon.Name = "toolStripMenuWeapon";
            toolStripMenuWeapon.Size = new Size(133, 24);
            toolStripMenuWeapon.Text = "Weapon";
            toolStripMenuWeapon.Click += toolStripMenuWeapon_Click;
            // 
            // contextMenuStripView
            // 
            contextMenuStripView.ImageScalingSize = new Size(20, 20);
            contextMenuStripView.Items.AddRange(new ToolStripItem[] { toolStripViewUnit, toolStripViewPilot, toolStripViewWeapon, toolStripViewSquad, toolStripViewMission });
            contextMenuStripView.Name = "contextMenuStripView";
            contextMenuStripView.Size = new Size(134, 124);
            // 
            // toolStripViewUnit
            // 
            toolStripViewUnit.Name = "toolStripViewUnit";
            toolStripViewUnit.Size = new Size(133, 24);
            toolStripViewUnit.Text = "Unit";
            toolStripViewUnit.Click += toolStripViewUnit_Click;
            // 
            // toolStripViewPilot
            // 
            toolStripViewPilot.Name = "toolStripViewPilot";
            toolStripViewPilot.Size = new Size(133, 24);
            toolStripViewPilot.Text = "Pilot";
            // 
            // toolStripViewWeapon
            // 
            toolStripViewWeapon.Name = "toolStripViewWeapon";
            toolStripViewWeapon.Size = new Size(133, 24);
            toolStripViewWeapon.Text = "Weapon";
            // 
            // toolStripViewSquad
            // 
            toolStripViewSquad.Name = "toolStripViewSquad";
            toolStripViewSquad.Size = new Size(133, 24);
            toolStripViewSquad.Text = "Squad";
            // 
            // toolStripViewMission
            // 
            toolStripViewMission.Name = "toolStripViewMission";
            toolStripViewMission.Size = new Size(133, 24);
            toolStripViewMission.Text = "Mission";
            // 
            // btnView
            // 
            btnView.Location = new Point(179, 175);
            btnView.Margin = new Padding(3, 4, 3, 4);
            btnView.Name = "btnView";
            btnView.Size = new Size(86, 31);
            btnView.TabIndex = 3;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // ListLog
            // 
            ListLog.FormattingEnabled = true;
            ListLog.Location = new Point(650, 219);
            ListLog.Margin = new Padding(3, 4, 3, 4);
            ListLog.Name = "ListLog";
            ListLog.Size = new Size(250, 364);
            ListLog.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(761, 177);
            label1.Name = "label1";
            label1.Size = new Size(45, 28);
            label1.TabIndex = 5;
            label1.Text = "Log";
            // 
            // btnMissionRoom
            // 
            btnMissionRoom.Location = new Point(323, 175);
            btnMissionRoom.Margin = new Padding(3, 4, 3, 4);
            btnMissionRoom.Name = "btnMissionRoom";
            btnMissionRoom.Size = new Size(106, 31);
            btnMissionRoom.TabIndex = 6;
            btnMissionRoom.Text = "Mission Room";
            btnMissionRoom.UseVisualStyleBackColor = true;
            btnMissionRoom.Click += btnMissionRoom_Click;
            // 
            // btnQuickStart
            // 
            btnQuickStart.Location = new Point(302, 213);
            btnQuickStart.Name = "btnQuickStart";
            btnQuickStart.Size = new Size(149, 29);
            btnQuickStart.TabIndex = 7;
            btnQuickStart.Text = "Quick start mission";
            btnQuickStart.UseVisualStyleBackColor = true;
            btnQuickStart.Click += btnQuickStart_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnQuickStart);
            Controls.Add(btnMissionRoom);
            Controls.Add(label1);
            Controls.Add(ListLog);
            Controls.Add(btnView);
            Controls.Add(lblTitle);
            Controls.Add(btnCreate);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            contextMenuStripCreate.ResumeLayout(false);
            contextMenuStripView.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCreate;
        private Label lblTitle;
        private ContextMenuStrip contextMenuStripCreate;
        private ToolStripMenuItem toolStripMenuUnit;
        private ToolStripMenuItem toolStripMenuPilot;
        private ToolStripMenuItem toolStripMenuSquad;
        private ToolStripMenuItem toolStripMenuMission;
        private ToolStripMenuItem toolStripMenuWeapon;
        private ContextMenuStrip contextMenuStripView;
        private ToolStripMenuItem toolStripViewUnit;
        private ToolStripMenuItem toolStripViewPilot;
        private ToolStripMenuItem toolStripViewWeapon;
        private ToolStripMenuItem toolStripViewSquad;
        private ToolStripMenuItem toolStripViewMission;
        private Button btnView;
        private ListBox ListLog;
        private Label label1;
        private Button btnMissionRoom;
        private Button btnQuickStart;
    }
}