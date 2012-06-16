using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using foi.pi;

namespace PutniNalozi.NET
{
    public partial class frmMain : Form
    {
        public Login piLogin = new Login();
        public iUser current_user;

        public frmMain()
        {
            InitializeComponent();
        }

        /*
         * Show login form to user
         */
        private void openLogin()
        {
            frmLogin FrmLogin = new frmLogin(piLogin);
            // set this window as parent to frmLogin
            FrmLogin.MdiParent = this;
            // show windows centered within this window
            FrmLogin.StartPosition = FormStartPosition.CenterScreen;
            // set status message so that user knows what to do
            writeToStatus("Please login to proceed", 3000);
            // finally, show login window
            FrmLogin.Show();
        }

        /*
         * Show putni nalozi form to user
         */
        private void openNalozi()
        {
            frmPutniNalozi FrmPutniNalozi = new frmPutniNalozi(piLogin);
            FrmPutniNalozi.MdiParent = this;
            FrmPutniNalozi.StartPosition = FormStartPosition.CenterParent;
            FrmPutniNalozi.Show();
        }

        /*
         * method enables displaying status messages on frmMain's statusbar
         */
        public void writeToStatus(string text, int interval)
        {
            stsLabel.Text = text;
            tmrCleanStatus.Interval = interval;
            tmrCleanStatus.Start();
        }

        /*
         * assign logged user as application user
         */
        public void setLoggedUser(iUser user)
        {
            this.current_user = user;
            // update status bar to show current logged user
            stsUser.Text = stsUser.Text + " " + user.Name + " " + user.Surname + " (" + user.UserName + ")";
        }

        /*
         * perform user logout
         */
        public void logout()
        {
            // update status bar to show Guest user
            stsUser.Text = "User: Guest";
            // unset current logged user
            current_user = null;
            // show login form
            openLogin();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // display login form to user
            openLogin();
        }

        private void optMainLogin_Click(object sender, EventArgs e)
        {
            // if user selects login option from Main menu, show login form
            openLogin();
        }

        private void optMainExit_Click(object sender, EventArgs e)
        {
            // exit application
            Application.Exit();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ask user to confirm before exiting application
            if (DialogResult.Yes != MessageBox.Show(
                "Please confirm exit",
                "Close application?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2))
            {
                e.Cancel = true;
            }
        }

        private void optMainLogout_Click(object sender, EventArgs e)
        {
            // perform user logout
            logout();
        }

        private void optUserLogout_Click(object sender, EventArgs e)
        {
            // perform user logout
            logout();
        }

        private void optPutniNalozi_Click(object sender, EventArgs e)
        {
            openNalozi();
        }

        private void tmrCleanStatus_Tick(object sender, EventArgs e)
        {
            stsLabel.Text = "";
            tmrCleanStatus.Stop();
        }
    }
}
