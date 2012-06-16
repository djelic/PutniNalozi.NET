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
    public partial class frmLogin : Form
    {
        // set piLoginInstance property to frmLogin class
        Login piLogin;

        public frmLogin(Login piLoginInstance)
        {
            InitializeComponent();
            this.piLogin = piLoginInstance;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // fetch user information from text fields
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            // run authentication against database
            iUser tmpUser = piLogin.Authenticate(username, password);
            
            // check authentication result
            if (tmpUser == null)
            {
                // notify user that login failed
                ((frmMain)this.ParentForm).writeToStatus("Login failed!", 3000);
                // focus text input on username
                txtUsername.Focus();
                txtUsername.SelectAll();
            }
            else
            {
                // notify user that login failed
                ((frmMain)this.ParentForm).writeToStatus("Login suceed!", 3000);
                // set this user as current_user
                ((frmMain)this.ParentForm).setLoggedUser(tmpUser);
                // unload form
                this.Close();
            }
        }
    }
}
