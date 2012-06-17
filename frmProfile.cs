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
    public partial class frmProfile : Form
    {
        private iUser korisnik;

        public frmProfile()
        {
            InitializeComponent();
        }

        /*
         * Overload takes iUser instance of user
         */
        public frmProfile(iUser korisnik)
        {
            InitializeComponent();
            this.korisnik = korisnik;
        }

        private void frmProfile_Load(object sender, EventArgs e)
        {
            // set window title
            this.Text = "Profile: " + korisnik.UserName;

            // set textbox properies
            txtKorisnickoIme.Text = korisnik.UserName;
            txtImePrezime.Text = korisnik.Name + " " + korisnik.Surname;
            txtTitula.Text = korisnik.Title;
            txtZanimanje.Text = korisnik.Occupation;
            txtEmail.Text = korisnik.Email;
            txtTelefon.Text = korisnik.Phone;
            txtAdresa.Text = korisnik.Address;

            // populate role list
            foreach (iRole uloga in korisnik.AssignedRoles)
            {
                lsbUloge.Items.Add(uloga.RoleName);
            }
        }

        private void frmProfile_KeyUp(object sender, KeyEventArgs e)
        {
            // if user press "Escape" key on keyboard, close form
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
