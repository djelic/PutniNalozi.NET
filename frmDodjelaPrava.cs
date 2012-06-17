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
    public partial class frmDodjelaPrava : Form
    {
        private Login piLogin;
        private iUser korisnik;

        public frmDodjelaPrava()
        {
            InitializeComponent();
        }

        /*
         * Overload when form called from main menu
         */
        public frmDodjelaPrava(Login piLoginInstance)
        {
            InitializeComponent();

            this.piLogin = piLoginInstance;
        }

        /*
         * Overload when called from user listing
         */
        public frmDodjelaPrava(Login piLoginInstance, iUser korisnik)
        {
            InitializeComponent();

            this.piLogin = piLoginInstance;
            this.korisnik = korisnik;
        }

        /*
         * Assign role to user
         * Method returns true if there are rows inserted
         */
        private bool dodijeliPrava(string korIme, string uloga, DateTime datumOd, DateTime datumDo, string razlog, bool aktivan)
        {
            piDB9DS piDS = new piDB9DS();
            piDB9DSTableAdapters.ulogaTA uTA = new piDB9DSTableAdapters.ulogaTA();
            return uTA.InsertRole(korIme, uloga, datumOd, datumDo, razlog, aktivan) > 0;
        }

        private void frmDodjelaPrava_Load(object sender, EventArgs e)
        {
            // key/value for combobox source
            List<KeyValuePair<string, string>> data = new List<KeyValuePair<string, string>>();
            // autocomplete for user's combobox
            AutoCompleteStringCollection autocomplete = new AutoCompleteStringCollection();

            // text inside combobox: Name Surname (username)
            // value: username
            foreach (iUser korisnik in piLogin.GetUser())
            {
                data.Add(new KeyValuePair<string, string> (korisnik.UserName, korisnik.Name + " " + korisnik.Surname + " (" + korisnik.UserName + ")"));
                autocomplete.Add(korisnik.Name + " " + korisnik.Surname + " (" + korisnik.UserName + ")");
            }

            // set datasource for user's combobox
            cmbKorisnik.DataSource = new BindingSource(data, null);
            cmbKorisnik.DisplayMember = "Value";
            cmbKorisnik.ValueMember = "Key";

            // set autocomplete source and mode
            cmbKorisnik.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbKorisnik.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbKorisnik.AutoCompleteCustomSource = autocomplete;

            // set role items
            cmbUloga.Items.Add("Odobravanje");
            cmbUloga.Items.Add("Likvidatura");

            // if user is set, select it from combobox
            if (this.korisnik != null)
            {
                cmbKorisnik.SelectedValue = this.korisnik.UserName;
            }
        }

        private void chbTrajno_CheckedChanged(object sender, EventArgs e)
        {
            // check checkbox to enable expiration date
            dtpDo.Enabled = chbTrajno.Checked;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodijeli_Click(object sender, EventArgs e)
        {
            // if checkbox not checked, use max date as date expiring
            if (!chbTrajno.Checked)
            {
                dtpDo.Value = dtpDo.MaxDate;
            }

            // assign role to user and write message to status
            if (dodijeliPrava(cmbKorisnik.SelectedValue.ToString(), cmbUloga.Text, dtpOd.Value, dtpDo.Value, txtRazlog.Text, chbAktivan.Checked))
            {
                ((frmMain)this.MdiParent).writeToStatus("Prava dodjeljena korisniku " + cmbKorisnik.Text, 3000);
            }
        }
    }
}
