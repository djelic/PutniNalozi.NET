using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PutniNalozi.NET
{
    public partial class frmUredjivanjePrava : Form
    {
        public frmUredjivanjePrava()
        {
            InitializeComponent();
        }

        /*
         * Returns currently selected row in DataGridView
         */
        private piDB9DS.ulogaRow getSelectedRow()
        {
            DataRowView current = (DataRowView)dgvDodjeljenaPrava.CurrentRow.DataBoundItem;
            piDB9DS.ulogaRow ulogaRow = (piDB9DS.ulogaRow)current.Row;

            return ulogaRow;
        }

        private void frmUredjivanjePrava_Load(object sender, EventArgs e)
        {
            this.ulogaTA.Fill(this.piDB9DS.uloga);
        }

        private void tsiMakniPrava_Click(object sender, EventArgs e)
        {
            // enable user's rights, refresh dgv and write message to status
            if (ulogaTA.UpdateRoleAktivan(false, getSelectedRow().id) > 0)
            {
                ulogaTA.Fill(piDB9DS.uloga);
                dgvDodjeljenaPrava.Refresh();
                ((frmMain)this.MdiParent).writeToStatus("Prava isključena", 3000);
            }
        }

        private void tsiUkljuciPrava_Click(object sender, EventArgs e)
        {
            // disable user's rights, refresh dgv and write message to status
            if (ulogaTA.UpdateRoleAktivan(true, getSelectedRow().id) > 0)
            {
                ulogaTA.Fill(piDB9DS.uloga);
                dgvDodjeljenaPrava.Refresh();
                ((frmMain)this.MdiParent).writeToStatus("Prava uključena", 3000);
            }
        }

        private void dgvDodjeljenaPrava_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (getSelectedRow().aktivan)
                {
                    tsiUkljuciPrava.Enabled = false;
                    tsiMakniPrava.Enabled = true;
                }
                else
                {
                    tsiUkljuciPrava.Enabled = true;
                    tsiMakniPrava.Enabled = false;
                }
            }
            catch (Exception)
            {}
        }
    }
}
