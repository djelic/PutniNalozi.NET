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

        public frmPutniNalozi(Login piLoginInstance)
        {
            InitializeComponent();
            this.piLogin = piLoginInstance;
        }

        private void frmPutniNalozi_Load(object sender, EventArgs e)
        {
            //this.voziloTA.Fill(this.piDB9DS.vozilo);
            //this.statusNalogaTA.Fill(this.piDB9DS.status_naloga);
            //this.putniNalogTA.Fill(this.piDB9DS.putni_nalog);

            this.putniNalogTA.FillWithRelations(this.piDB9DS.putni_nalog);

            refreshNalog();
        }

        private void refreshNalog()
        {
            if (dgvPutniNalozi.CurrentCellAddress.Y == -1)
            {
                return;
            }

            DataRowView current = (DataRowView)dgvPutniNalozi.CurrentRow.DataBoundItem;
            piDB9DS.putni_nalogRow putniNalogRow = (piDB9DS.putni_nalogRow)current.Row;

            txtZahtjevatelj.Text = getFullName(putniNalogRow.zahtjevatelj);
            if (putniNalogRow.odobravatelj.Trim() != "")
            {
                txtOdobravatelj.Text = getFullName(putniNalogRow.odobravatelj);
            }

            if (putniNalogRow.status_id == 2)
            {
                btnOdobri.Enabled = false;
            }
            else
            {
                btnOdobri.Enabled = true;
            }
        }

        public string getFullName(string username)
        {
            if (this.piLogin.GetUser(username, true).Count > 0)
            {
                iUser korisnik = this.piLogin.GetUser(username, true).First();
                return korisnik.Name + " " + korisnik.Surname;
            }

            return username;
        }

        private bool odobriNalog()
        {
            DataRowView current = (DataRowView)dgvPutniNalozi.CurrentRow.DataBoundItem;
            piDB9DS.putni_nalogRow putniNalogRow = (piDB9DS.putni_nalogRow)current.Row;
            return this.putniNalogTA.UpdateStatus(2, putniNalogRow.id) > 0;
        }

        private void frmPutniNalozi_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgvPutniNalozi.DataSource = null;
        }

        private void dgvPutniNalozi_SelectionChanged(object sender, EventArgs e)
        {
            refreshNalog();
        }

        private void btnOdobri_Click(object sender, EventArgs e)
        {
            if (odobriNalog())
            {
                this.putniNalogTA.FillWithRelations(this.piDB9DS.putni_nalog);
                dgvPutniNalozi.Refresh();
                frmMain.WriteToStatus("Nalog odobren");
            }
        }
    }
}
