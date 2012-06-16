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
    public partial class frmPutniNalozi : Form
    {
        Login piLogin;

        int STATUS_ODOBREN = 2;

        public frmPutniNalozi(Login piLoginInstance)
        {
            InitializeComponent();

            // set login component passed when instancing
            this.piLogin = piLoginInstance;
        }

        /*
         * Returns currently selected row in DataGridView dgvPutniNalog
         */
        private piDB9DS.putni_nalogRow getSelectedRow()
        {
            DataRowView current = (DataRowView)dgvPutniNalozi.CurrentRow.DataBoundItem;
            piDB9DS.putni_nalogRow putniNalogRow = (piDB9DS.putni_nalogRow)current.Row;

            return putniNalogRow;
        }

        /*
         * Returns full name of given username via piLogin component
         */
        public string getFullName(string username)
        {
            // retrieve users matching username
            List<iUser> korisnici = this.piLogin.GetUser(username, true);
            if (korisnici.Count > 0)
            {
                // if user exists, return concationation of users first and last name
                iUser korisnik = korisnici.First();
                return korisnik.Name + " " + korisnik.Surname;
            }

            // if user doesn't exists, fallback on username given as argument
            return username;
        }

        /*
         * Method refreshes left side of form where information about "nalog" are displayed
         */
        private void refreshNalog()
        {
            // if user select's header of DataGridView, break don't refresh nalog
            if (dgvPutniNalozi.CurrentCellAddress.Y == -1)
            {
                return;
            }

            // get currently selected row of DataGridView
            piDB9DS.putni_nalogRow putniNalogRow = getSelectedRow();

            // "zahtjevatelj" must exist in database, so we just can show full name in text field
            txtZahtjevatelj.Text = getFullName(putniNalogRow.zahtjevatelj);
            
            // "odobravatelj" may/may not exist, so we need to check first
            if (putniNalogRow.odobravatelj.Trim() != "")
            {
                txtOdobravatelj.Text = getFullName(putniNalogRow.odobravatelj);
            }

            // disable button for approval if nalog already approved
            if (putniNalogRow.status_id == this.STATUS_ODOBREN)
            {
                btnOdobri.Enabled = false;
            }
            else
            {
                btnOdobri.Enabled = true;
            }
        }

        /*
         * Calls method for updating status of nalog and returns true if number of rows affected > 0
         */
        private bool odobriNalog(int putniNalogId, string korIme)
        {
            return this.putniNalogTA.UpdateStatus(this.STATUS_ODOBREN, korIme, putniNalogId) > 0;
        }

        private void frmPutniNalozi_Load(object sender, EventArgs e)
        {
            // fills putniNalogTA with data with values of foreign keys
            this.putniNalogTA.FillWithRelations(this.piDB9DS.putni_nalog);

            // refresh left pane
            refreshNalog();
        }

        private void frmPutniNalozi_FormClosing(object sender, FormClosingEventArgs e)
        {
            // set datasource to null to avoid crashing
            dgvPutniNalozi.DataSource = null;
        }

        private void dgvPutniNalozi_SelectionChanged(object sender, EventArgs e)
        {
            // when user clicks on other row, refresh left pane
            refreshNalog();
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            // get username of currenty logged user from main form
            string korIme = ((frmMain)this.ParentForm).current_user.UserName;
            // get currenty selected nalog from DataGridView and fetch id
            int putniNalogId = getSelectedRow().id;
            // finnaly, call method for approving
            if (odobriNalog(putniNalogId, korIme))
            {
                // if succeded, refresh DataGridView and display status message
                this.putniNalogTA.FillWithRelations(this.piDB9DS.putni_nalog);
                ((frmMain)this.ParentForm).writeToStatus("Nalog odobren", 3000);
                dgvPutniNalozi.Refresh();
            }
        }
    }
}
