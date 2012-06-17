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
    public partial class frmKorisnici : Form
    {
        Login piLogin;

        public frmKorisnici()
        {
            InitializeComponent();
        }

        public frmKorisnici(Login piLoginInstance)
        {
            InitializeComponent();

            this.piLogin = piLoginInstance;
        }
    }
}
