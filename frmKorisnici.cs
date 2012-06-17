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

        private void frmKorisnici_Load(object sender, EventArgs e)
        {
            // fetch all users from piLogin component
            List<iUser> piKorisnici = piLogin.GetUser();

            // set list of users as source to DGV
            dgvKorisnici.DataSource = piKorisnici;

            // adjust columns header text
            string[] headerText = new string[] { "Korisničko ime", "Ime", "Prezime", "Telefon",
                "Adresa", "Titula", "Zanimanje", "E-mail" };
            for (int i = 0; i < headerText.Count(); i++)
            {
                dgvKorisnici.Columns[i].HeaderText = headerText[i];
            }
        }
    }
}
