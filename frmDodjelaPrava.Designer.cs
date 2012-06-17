namespace PutniNalozi.NET
{
    partial class frmDodjelaPrava
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDodjeliPrava = new System.Windows.Forms.GroupBox();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.cmbUloga = new System.Windows.Forms.ComboBox();
            this.lblUloga = new System.Windows.Forms.Label();
            this.lblOd = new System.Windows.Forms.Label();
            this.dtpOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDo = new System.Windows.Forms.DateTimePicker();
            this.lblDo = new System.Windows.Forms.Label();
            this.chbTrajno = new System.Windows.Forms.CheckBox();
            this.txtRazlog = new System.Windows.Forms.TextBox();
            this.lblRazlog = new System.Windows.Forms.Label();
            this.btnDodijeli = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.chbAktivan = new System.Windows.Forms.CheckBox();
            this.lblAktivan = new System.Windows.Forms.Label();
            this.grpDodjeliPrava.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDodjeliPrava
            // 
            this.grpDodjeliPrava.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDodjeliPrava.Controls.Add(this.chbAktivan);
            this.grpDodjeliPrava.Controls.Add(this.lblAktivan);
            this.grpDodjeliPrava.Controls.Add(this.btnOdustani);
            this.grpDodjeliPrava.Controls.Add(this.btnDodijeli);
            this.grpDodjeliPrava.Controls.Add(this.lblRazlog);
            this.grpDodjeliPrava.Controls.Add(this.txtRazlog);
            this.grpDodjeliPrava.Controls.Add(this.chbTrajno);
            this.grpDodjeliPrava.Controls.Add(this.dtpDo);
            this.grpDodjeliPrava.Controls.Add(this.lblDo);
            this.grpDodjeliPrava.Controls.Add(this.dtpOd);
            this.grpDodjeliPrava.Controls.Add(this.lblOd);
            this.grpDodjeliPrava.Controls.Add(this.cmbUloga);
            this.grpDodjeliPrava.Controls.Add(this.lblUloga);
            this.grpDodjeliPrava.Controls.Add(this.cmbKorisnik);
            this.grpDodjeliPrava.Controls.Add(this.lblKorisnik);
            this.grpDodjeliPrava.Location = new System.Drawing.Point(12, 12);
            this.grpDodjeliPrava.Name = "grpDodjeliPrava";
            this.grpDodjeliPrava.Size = new System.Drawing.Size(287, 344);
            this.grpDodjeliPrava.TabIndex = 0;
            this.grpDodjeliPrava.TabStop = false;
            this.grpDodjeliPrava.Text = "Dodijeli prava";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(6, 22);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(44, 13);
            this.lblKorisnik.TabIndex = 0;
            this.lblKorisnik.Text = "Korisnik";
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(90, 19);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(186, 21);
            this.cmbKorisnik.TabIndex = 0;
            // 
            // cmbUloga
            // 
            this.cmbUloga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUloga.FormattingEnabled = true;
            this.cmbUloga.Location = new System.Drawing.Point(90, 46);
            this.cmbUloga.Name = "cmbUloga";
            this.cmbUloga.Size = new System.Drawing.Size(186, 21);
            this.cmbUloga.TabIndex = 1;
            // 
            // lblUloga
            // 
            this.lblUloga.AutoSize = true;
            this.lblUloga.Location = new System.Drawing.Point(6, 49);
            this.lblUloga.Name = "lblUloga";
            this.lblUloga.Size = new System.Drawing.Size(35, 13);
            this.lblUloga.TabIndex = 2;
            this.lblUloga.Text = "Uloga";
            // 
            // lblOd
            // 
            this.lblOd.AutoSize = true;
            this.lblOd.Location = new System.Drawing.Point(6, 80);
            this.lblOd.Name = "lblOd";
            this.lblOd.Size = new System.Drawing.Size(21, 13);
            this.lblOd.TabIndex = 4;
            this.lblOd.Text = "Od";
            // 
            // dtpOd
            // 
            this.dtpOd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpOd.Location = new System.Drawing.Point(90, 76);
            this.dtpOd.Name = "dtpOd";
            this.dtpOd.Size = new System.Drawing.Size(186, 20);
            this.dtpOd.TabIndex = 2;
            // 
            // dtpDo
            // 
            this.dtpDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDo.Location = new System.Drawing.Point(90, 102);
            this.dtpDo.Name = "dtpDo";
            this.dtpDo.Size = new System.Drawing.Size(186, 20);
            this.dtpDo.TabIndex = 4;
            // 
            // lblDo
            // 
            this.lblDo.AutoSize = true;
            this.lblDo.Location = new System.Drawing.Point(6, 106);
            this.lblDo.Name = "lblDo";
            this.lblDo.Size = new System.Drawing.Size(21, 13);
            this.lblDo.TabIndex = 6;
            this.lblDo.Text = "Do";
            // 
            // chbTrajno
            // 
            this.chbTrajno.AutoSize = true;
            this.chbTrajno.Checked = true;
            this.chbTrajno.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTrajno.Location = new System.Drawing.Point(69, 106);
            this.chbTrajno.Name = "chbTrajno";
            this.chbTrajno.Size = new System.Drawing.Size(15, 14);
            this.chbTrajno.TabIndex = 3;
            this.chbTrajno.UseVisualStyleBackColor = true;
            this.chbTrajno.CheckedChanged += new System.EventHandler(this.chbTrajno_CheckedChanged);
            // 
            // txtRazlog
            // 
            this.txtRazlog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazlog.Location = new System.Drawing.Point(90, 128);
            this.txtRazlog.Multiline = true;
            this.txtRazlog.Name = "txtRazlog";
            this.txtRazlog.Size = new System.Drawing.Size(186, 118);
            this.txtRazlog.TabIndex = 5;
            // 
            // lblRazlog
            // 
            this.lblRazlog.AutoSize = true;
            this.lblRazlog.Location = new System.Drawing.Point(6, 131);
            this.lblRazlog.Name = "lblRazlog";
            this.lblRazlog.Size = new System.Drawing.Size(40, 13);
            this.lblRazlog.TabIndex = 10;
            this.lblRazlog.Text = "Razlog";
            // 
            // btnDodijeli
            // 
            this.btnDodijeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDodijeli.Location = new System.Drawing.Point(186, 299);
            this.btnDodijeli.Name = "btnDodijeli";
            this.btnDodijeli.Size = new System.Drawing.Size(90, 34);
            this.btnDodijeli.TabIndex = 7;
            this.btnDodijeli.Text = "Dodijeli";
            this.btnDodijeli.UseVisualStyleBackColor = true;
            this.btnDodijeli.Click += new System.EventHandler(this.btnDodijeli_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdustani.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOdustani.Location = new System.Drawing.Point(90, 299);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(90, 34);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // chbAktivan
            // 
            this.chbAktivan.AutoSize = true;
            this.chbAktivan.Checked = true;
            this.chbAktivan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAktivan.Location = new System.Drawing.Point(90, 252);
            this.chbAktivan.Name = "chbAktivan";
            this.chbAktivan.Size = new System.Drawing.Size(15, 14);
            this.chbAktivan.TabIndex = 6;
            this.chbAktivan.UseVisualStyleBackColor = true;
            // 
            // lblAktivan
            // 
            this.lblAktivan.AutoSize = true;
            this.lblAktivan.Location = new System.Drawing.Point(6, 252);
            this.lblAktivan.Name = "lblAktivan";
            this.lblAktivan.Size = new System.Drawing.Size(37, 13);
            this.lblAktivan.TabIndex = 13;
            this.lblAktivan.Text = "Aktian";
            // 
            // frmDodjelaPrava
            // 
            this.AcceptButton = this.btnDodijeli;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOdustani;
            this.ClientSize = new System.Drawing.Size(311, 368);
            this.Controls.Add(this.grpDodjeliPrava);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDodjelaPrava";
            this.Text = "Dodjela prava";
            this.Load += new System.EventHandler(this.frmDodjelaPrava_Load);
            this.grpDodjeliPrava.ResumeLayout(false);
            this.grpDodjeliPrava.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDodjeliPrava;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.ComboBox cmbKorisnik;
        private System.Windows.Forms.DateTimePicker dtpOd;
        private System.Windows.Forms.Label lblOd;
        private System.Windows.Forms.ComboBox cmbUloga;
        private System.Windows.Forms.Label lblUloga;
        private System.Windows.Forms.DateTimePicker dtpDo;
        private System.Windows.Forms.Label lblDo;
        private System.Windows.Forms.CheckBox chbTrajno;
        private System.Windows.Forms.TextBox txtRazlog;
        private System.Windows.Forms.Label lblRazlog;
        private System.Windows.Forms.Button btnDodijeli;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.CheckBox chbAktivan;
        private System.Windows.Forms.Label lblAktivan;
    }
}