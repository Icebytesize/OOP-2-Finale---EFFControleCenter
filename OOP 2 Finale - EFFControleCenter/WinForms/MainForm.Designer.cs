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
            toolStripMenuBase = new ToolStripMenuItem();
            contextMenuStripCreate.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(36, 131);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreateUnit_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            lblTitle.Location = new Point(141, 33);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(463, 54);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "EFF CONTROLE CENTER";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += label1_Click;
            // 
            // contextMenuStripCreate
            // 
            contextMenuStripCreate.Items.AddRange(new ToolStripItem[] { toolStripMenuUnit, toolStripMenuPilot, toolStripMenuSquad, toolStripMenuMission, toolStripMenuWeapon, toolStripMenuBase });
            contextMenuStripCreate.Name = "contextMenuStrip1";
            contextMenuStripCreate.Size = new Size(181, 158);
            contextMenuStripCreate.Opening += contextMenuStripCreate_Opening;
            // 
            // toolStripMenuUnit
            // 
            toolStripMenuUnit.Name = "toolStripMenuUnit";
            toolStripMenuUnit.Size = new Size(180, 22);
            toolStripMenuUnit.Text = "Unit";
            toolStripMenuUnit.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuPilot
            // 
            toolStripMenuPilot.Name = "toolStripMenuPilot";
            toolStripMenuPilot.Size = new Size(180, 22);
            toolStripMenuPilot.Text = "Pilot";
            toolStripMenuPilot.Click += toolStripMenuPilot_Click;
            // 
            // toolStripMenuSquad
            // 
            toolStripMenuSquad.Name = "toolStripMenuSquad";
            toolStripMenuSquad.Size = new Size(180, 22);
            toolStripMenuSquad.Text = "Squad";
            // 
            // toolStripMenuMission
            // 
            toolStripMenuMission.Name = "toolStripMenuMission";
            toolStripMenuMission.Size = new Size(180, 22);
            toolStripMenuMission.Text = "Mission";
            // 
            // toolStripMenuWeapon
            // 
            toolStripMenuWeapon.Name = "toolStripMenuWeapon";
            toolStripMenuWeapon.Size = new Size(180, 22);
            toolStripMenuWeapon.Text = "Weapon";
            // 
            // toolStripMenuBase
            // 
            toolStripMenuBase.Name = "toolStripMenuBase";
            toolStripMenuBase.Size = new Size(180, 22);
            toolStripMenuBase.Text = "Base";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitle);
            Controls.Add(btnCreate);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            contextMenuStripCreate.ResumeLayout(false);
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
        private ToolStripMenuItem toolStripMenuBase;
    }
}