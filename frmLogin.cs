﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PutniNalozi.NET
{
    public partial class frmLogin : Form
    {
        // set piLoginInstance property to frmLogin class
        foi.pi.Login piLoginInstance = new foi.pi.Login();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // fetch user information from text fields
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            // run authentication against database
            foi.pi.iUser tmpUser = piLoginInstance.Authenticate(username, password);
            
            // check authentication result
            if (tmpUser == null)
            {
                // notify user that login failed
                frmMain.WriteToStatus("Login failed!");
                // focus text input on username
                txtUsername.Focus();
            }
            else
            {
                // notify user that login failed
                frmMain.WriteToStatus("Login succeded!");
                // set this user as current_user
                frmMain.SetLoggedUser(tmpUser);
                // unload form
                this.Close();
            }
        }
    }
}
