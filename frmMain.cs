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
        public static ToolStripStatusLabel status_bar;
        public static ToolStripStatusLabel logged_user;
        public Login piLogin = new Login();
        public static iUser current_user;

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
            frmMain.WriteToStatus("Please login to proceed");
            // finally, show login window
            FrmLogin.Show();
        }

        private void openNalozi()
        {
            frmPutniNalozi FrmPutniNalozi = new frmPutniNalozi(piLogin);
            FrmPutniNalozi.MdiParent = this;
            FrmPutniNalozi.StartPosition = FormStartPosition.CenterParent;
            FrmPutniNalozi.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // connect status_bar items with properties
            status_bar = stsLabel;
            logged_user = stsUser;

            // display login form to user
            openLogin();
        }

        private void optMainLogin_Click(object sender, EventArgs e)
        {
            // if user selects login option from Main menu,
            // show login form
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

        /*
         * method enables displaying status messages on frmMain's statusbar
         */
        public static void WriteToStatus(string text)
        {
            status_bar.Text = text;
        }

        /*
         * assign logged user as application user
         */
        public static void SetLoggedUser(foi.pi.iUser user)
        {
            current_user = user;
            // update status bar to show current logged user
            logged_user.Text = logged_user.Text + " " + current_user.Name;
        }

        /*
         * perform user logout
         */
        public void Logout()
        {
            // update status bar to show Guest user
            logged_user.Text = "User: Guest";
            // unset current logged user
            current_user = null;
            // show login form
            // openLogin();
        }

        private void optMainLogout_Click(object sender, EventArgs e)
        {
            // perform user logout
            Logout();
        }

        private void optUserLogout_Click(object sender, EventArgs e)
        {
            // perform user logout
            Logout();
        }

        private void optPutniNalozi_Click(object sender, EventArgs e)
        {
            openNalozi();
        }
    }
}
