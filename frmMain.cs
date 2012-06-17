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
         * Tries to focus form if exists as Child of main form
         */
        public bool focusForm(string formName)
        {
            // if login form already opened, focus on form
            foreach (Form form in this.MdiChildren)
            {
                if (form.Name == formName)
                {
                    form.Focus();
                    return true;
                }
            }

            return false;
        }

        /*
         * Show login form
         */
        private void openLogin()
        {
            // if there is no form instance active, create new form and show
            if (!focusForm("frmLogin"))
            {
                // otherwise, create and show new login form
                frmLogin FrmLogin = new frmLogin(this.piLogin);
                // set this window as parent to frmLogin
                FrmLogin.MdiParent = this;
                // show windows centered within this window
                FrmLogin.StartPosition = FormStartPosition.CenterScreen;
                // set status message so that user knows what to do
                writeToStatus("Za nastavak morate biti ulogirani", 3000);
                // finally, show login window
                FrmLogin.Show(); 
            }
        }

        /*
         * Show putni nalozi form
         */
        private void openNalozi()
        {
            if (!focusForm("frmPutniNalozi"))
            {
                frmPutniNalozi FrmPutniNalozi = new frmPutniNalozi(this.piLogin);
                FrmPutniNalozi.MdiParent = this;
                FrmPutniNalozi.StartPosition = FormStartPosition.CenterParent;
                FrmPutniNalozi.Show(); 
            }
        }

        /*
         * Shows user listing form
         */
        private void openKorisnici()
        {
            if (!focusForm("frmKorisnici"))
            {
                frmKorisnici FrmKorisnici = new frmKorisnici(this.piLogin);
                FrmKorisnici.MdiParent = this;
                FrmKorisnici.StartPosition = FormStartPosition.CenterParent;
                FrmKorisnici.Show(); 
            }
        }

        /*
         * Shows user's profile form
         */
        private void openProfile()
        {
            if (!focusForm("frmProfile"))
            {
                frmProfile FrmProfile = new frmProfile(this.current_user);
                FrmProfile.MdiParent = this;
                FrmProfile.StartPosition = FormStartPosition.CenterParent;
                FrmProfile.Show(); 
            }
        }

        /*
         * Shows form for role assignment
         */
        private void openDodjelaPrava()
        {
            if (!focusForm("frmDodjelaPrava"))
            {
                frmDodjelaPrava FrmDodjelaPrava = new frmDodjelaPrava(this.piLogin);
                FrmDodjelaPrava.MdiParent = this;
                FrmDodjelaPrava.StartPosition = FormStartPosition.CenterParent;
                FrmDodjelaPrava.Show();
            }
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

                optUserProfile.Enabled = true;
                optUserLogout.Enabled = true;

                optActionsPutniNalozi.Enabled = true;
                optActionsKorisnici.Enabled = true;
                optActionsDodjelaPrava.Enabled = true;
            }
            else
            {
                // guest session
                optMainLogin.Enabled = true;
                optMainLogout.Enabled = false;
                optMainRegister.Enabled = true;

                optUserProfile.Enabled = false;
                optUserLogout.Enabled = false;

                optActionsPutniNalozi.Enabled = false;
                optActionsKorisnici.Enabled = false;
                optActionsDodjelaPrava.Enabled = false;
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

        private void optUserProfile_Click(object sender, EventArgs e)
        {
            openProfile();
        }

        private void optActionsKorisnici_Click(object sender, EventArgs e)
        {
            openKorisnici();
        }

        private void optActionsDodjelaPrava_Click(object sender, EventArgs e)
        {
            openDodjelaPrava();
        }
    }
}
