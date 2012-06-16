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
            writeToStatus("Za nastavak morate biti ulogirani", 3000);
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
         * Method enables displaying status messages on frmMain's statusbar
         */
        public void writeToStatus(string text, int interval)
        {
            stsLabel.Text = text;
            tmrCleanStatus.Interval = interval;
            tmrCleanStatus.Start();
        }

        /*
         * Enables actions in main menu
         */
        private void refreshMenuActions()
        {
            if (this.current_user != null)
            {
                // user logged in
                optMainLogin.Enabled = false;
                optMainLogout.Enabled = true;
                optMainRegister.Enabled = false;

                optUserLogout.Enabled = true;

                optActionsPutniNalozi.Enabled = true;
            }
            else
            {
                // guest session
                optMainLogin.Enabled = true;
                optMainLogout.Enabled = false;
                optMainRegister.Enabled = true;

                optUserLogout.Enabled = false;

                optActionsPutniNalozi.Enabled = false;
            }
        }

        /*
         * Assign logged user as application user
         */
        public void setLoggedUser(iUser user)
        {
            // set logged user
            this.current_user = user;
            // refresh menu actions
            refreshMenuActions();
            // update status bar to show current logged user
            stsUser.Text = stsUser.Text + " " + user.Name + " " + user.Surname + " (" + user.UserName + ")";
        }

        /*
         * Perform user logout
         */
        public void logout()
        {
            // update status bar to show Guest user
            stsUser.Text = "User: Guest";
            // unset current logged user
            current_user = null;
            // refresh menu actions
            refreshMenuActions();
            // show login form
            openLogin();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // refresh main menu's actions
            refreshMenuActions();
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

        private void optActionsPutniNalozi_Click(object sender, EventArgs e)
        {
            // open putni nalozi form
            openNalozi();
        }

        private void tmrCleanStatus_Tick(object sender, EventArgs e)
        {
            // when timer runs out, clear text from statusbar and disable timer
            stsLabel.Text = "";
            tmrCleanStatus.Stop();
        }
    }
}
