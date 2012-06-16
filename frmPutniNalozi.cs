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
        Login piLogin = new Login();

        public frmPutniNalozi()
        {
            InitializeComponent();
        }

        private void frmPutniNalozi_Load(object sender, EventArgs e)
        {
            this.voziloTA.Fill(this.piDB9DS.vozilo);
            this.statusNalogaTA.Fill(this.piDB9DS.status_naloga);
            this.putniNalogTA.Fill(this.piDB9DS.putni_nalog);

            refreshNalog();
        }

        private void refreshNalog()
        {
            DataRowView current = (DataRowView)dgvPutniNalozi.CurrentRow.DataBoundItem;
            piDB9DS.putni_nalogRow putniNalogRow = (piDB9DS.putni_nalogRow)current.Row;

            iUser zahtjevatelj = this.piLogin.GetUser(putniNalogRow.zahtjevatelj, true).First();
            txtZahtjevatelj.Text = zahtjevatelj.Name + " " + zahtjevatelj.Surname;

            if (txtOdobravatelj.Text.Trim() != "")
            {
                try
                {
                    iUser odobravatelj = this.piLogin.GetUser(putniNalogRow.odobravatelj, true).First();
                    txtOdobravatelj.Text = odobravatelj.Name + " " + odobravatelj.Surname;
                }
                catch (Exception)
                {
                }
            }
        }

        private void frmPutniNalozi_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgvPutniNalozi.DataSource = null;
        }

        private void dgvPutniNalozi_SelectionChanged(object sender, EventArgs e)
        {
            refreshNalog();
        }
    }
}
