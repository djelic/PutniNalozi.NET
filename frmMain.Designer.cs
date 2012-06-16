namespace PutniNalozi.NET
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.optMain = new System.Windows.Forms.ToolStripMenuItem();
            this.optMainLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.optMainLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.optMainRegister = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.optMainExit = new System.Windows.Forms.ToolStripMenuItem();
            this.optUser = new System.Windows.Forms.ToolStripMenuItem();
            this.optUserLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.optActions = new System.Windows.Forms.ToolStripMenuItem();
            this.optActionsPutniNalozi = new System.Windows.Forms.ToolStripMenuItem();
            this.optHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.optHelpGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.optHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStatus = new System.Windows.Forms.StatusStrip();
            this.stsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsPlaceholder = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrCleanStatus = new System.Windows.Forms.Timer(this.components);
            this.optUserProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain.SuspendLayout();
            this.stsStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optMain,
            this.optUser,
            this.optActions,
            this.optHelp});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1202, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "Main Menu";
            // 
            // optMain
            // 
            this.optMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optMainLogin,
            this.optMainLogout,
            this.optMainRegister,
            this.toolStripMenuItem2,
            this.optMainExit});
            this.optMain.Name = "optMain";
            this.optMain.Size = new System.Drawing.Size(41, 20);
            this.optMain.Text = "Main";
            // 
            // optMainLogin
            // 
            this.optMainLogin.Name = "optMainLogin";
            this.optMainLogin.Size = new System.Drawing.Size(125, 22);
            this.optMainLogin.Text = "Login";
            this.optMainLogin.Click += new System.EventHandler(this.optMainLogin_Click);
            // 
            // optMainLogout
            // 
            this.optMainLogout.Name = "optMainLogout";
            this.optMainLogout.Size = new System.Drawing.Size(125, 22);
            this.optMainLogout.Text = "Logout";
            this.optMainLogout.Click += new System.EventHandler(this.optMainLogout_Click);
            // 
            // optMainRegister
            // 
            this.optMainRegister.Name = "optMainRegister";
            this.optMainRegister.Size = new System.Drawing.Size(125, 22);
            this.optMainRegister.Text = "Register";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(122, 6);
            // 
            // optMainExit
            // 
            this.optMainExit.Name = "optMainExit";
            this.optMainExit.Size = new System.Drawing.Size(125, 22);
            this.optMainExit.Text = "Exit";
            this.optMainExit.Click += new System.EventHandler(this.optMainExit_Click);
            // 
            // optUser
            // 
            this.optUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optUserProfile,
            this.toolStripSeparator1,
            this.optUserLogout});
            this.optUser.Name = "optUser";
            this.optUser.Size = new System.Drawing.Size(41, 20);
            this.optUser.Text = "User";
            // 
            // optUserLogout
            // 
            this.optUserLogout.Name = "optUserLogout";
            this.optUserLogout.Size = new System.Drawing.Size(152, 22);
            this.optUserLogout.Text = "Logout";
            this.optUserLogout.Click += new System.EventHandler(this.optUserLogout_Click);
            // 
            // optActions
            // 
            this.optActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optActionsPutniNalozi});
            this.optActions.Name = "optActions";
            this.optActions.Size = new System.Drawing.Size(54, 20);
            this.optActions.Text = "Actions";
            // 
            // optActionsPutniNalozi
            // 
            this.optActionsPutniNalozi.Name = "optActionsPutniNalozi";
            this.optActionsPutniNalozi.Size = new System.Drawing.Size(139, 22);
            this.optActionsPutniNalozi.Text = "Putni nalozi";
            this.optActionsPutniNalozi.Click += new System.EventHandler(this.optActionsPutniNalozi_Click);
            // 
            // optHelp
            // 
            this.optHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optHelpGeneral,
            this.toolStripMenuItem1,
            this.optHelpAbout});
            this.optHelp.Name = "optHelp";
            this.optHelp.Size = new System.Drawing.Size(40, 20);
            this.optHelp.Text = "Help";
            // 
            // optHelpGeneral
            // 
            this.optHelpGeneral.Name = "optHelpGeneral";
            this.optHelpGeneral.Size = new System.Drawing.Size(146, 22);
            this.optHelpGeneral.Text = "General Help";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // optHelpAbout
            // 
            this.optHelpAbout.Name = "optHelpAbout";
            this.optHelpAbout.Size = new System.Drawing.Size(146, 22);
            this.optHelpAbout.Text = "About";
            // 
            // stsStatus
            // 
            this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsLabel,
            this.stsPlaceholder,
            this.stsUser});
            this.stsStatus.Location = new System.Drawing.Point(0, 783);
            this.stsStatus.Name = "stsStatus";
            this.stsStatus.Size = new System.Drawing.Size(1202, 22);
            this.stsStatus.TabIndex = 2;
            this.stsStatus.Text = "Status";
            // 
            // stsLabel
            // 
            this.stsLabel.Name = "stsLabel";
            this.stsLabel.Size = new System.Drawing.Size(37, 17);
            this.stsLabel.Text = "status";
            // 
            // stsPlaceholder
            // 
            this.stsPlaceholder.Name = "stsPlaceholder";
            this.stsPlaceholder.Size = new System.Drawing.Size(1117, 17);
            this.stsPlaceholder.Spring = true;
            // 
            // stsUser
            // 
            this.stsUser.Name = "stsUser";
            this.stsUser.Size = new System.Drawing.Size(33, 17);
            this.stsUser.Text = "User:";
            // 
            // tmrCleanStatus
            // 
            this.tmrCleanStatus.Tick += new System.EventHandler(this.tmrCleanStatus_Tick);
            // 
            // optUserProfile
            // 
            this.optUserProfile.Name = "optUserProfile";
            this.optUserProfile.Size = new System.Drawing.Size(152, 22);
            this.optUserProfile.Text = "Profile";
            this.optUserProfile.Click += new System.EventHandler(this.optUserProfile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 805);
            this.Controls.Add(this.stsStatus);
            this.Controls.Add(this.mnuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "PutniNalozi.NET";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.stsStatus.ResumeLayout(false);
            this.stsStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem optMain;
        private System.Windows.Forms.ToolStripMenuItem optMainLogin;
        private System.Windows.Forms.ToolStripMenuItem optMainLogout;
        private System.Windows.Forms.ToolStripMenuItem optMainRegister;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem optMainExit;
        private System.Windows.Forms.ToolStripMenuItem optUser;
        private System.Windows.Forms.ToolStripMenuItem optUserLogout;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripMenuItem optHelp;
        private System.Windows.Forms.ToolStripMenuItem optHelpGeneral;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optHelpAbout;
        private System.Windows.Forms.ToolStripStatusLabel stsLabel;
        private System.Windows.Forms.ToolStripStatusLabel stsPlaceholder;
        private System.Windows.Forms.ToolStripStatusLabel stsUser;
        private System.Windows.Forms.ToolStripMenuItem optActions;
        private System.Windows.Forms.ToolStripMenuItem optActionsPutniNalozi;
        private System.Windows.Forms.Timer tmrCleanStatus;
        private System.Windows.Forms.ToolStripMenuItem optUserProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

