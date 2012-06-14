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
    public partial class frmPutniNalozi : Form
    {
        public frmPutniNalozi()
        {
            InitializeComponent();
        }

        private void frmPutniNalozi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'piDB9DS.vozilo' table. You can move, or remove it, as needed.
            this.voziloTA.Fill(this.piDB9DS.vozilo);
            // TODO: This line of code loads data into the 'piDB9DS.status_naloga' table. You can move, or remove it, as needed.
            this.statusNalogaTA.Fill(this.piDB9DS.status_naloga);
            // TODO: This line of code loads data into the 'piDB9DS.status_naloga' table. You can move, or remove it, as needed.
            this.statusNalogaTA.Fill(this.piDB9DS.status_naloga);
            // TODO: This line of code loads data into the 'piDB9DS.putni_nalog' table. You can move, or remove it, as needed.
            this.putniNalogTA.Fill(this.piDB9DS.putni_nalog);

        }

        private void frmPutniNalozi_FormClosing(object sender, FormClosingEventArgs e)
        {
            dgvPutniNalozi.DataSource = null;
        }
    }
}
