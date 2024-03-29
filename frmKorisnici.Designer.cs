﻿namespace PutniNalozi.NET
{
    partial class frmKorisnici
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
            this.components = new System.ComponentModel.Container();
            this.grpKorisnici = new System.Windows.Forms.GroupBox();
            this.dgvKorisnici = new System.Windows.Forms.DataGridView();
            this.cmsKorisniciActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiDodjijeliPrava = new System.Windows.Forms.ToolStripMenuItem();
            this.grpKorisnici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).BeginInit();
            this.cmsKorisniciActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKorisnici
            // 
            this.grpKorisnici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpKorisnici.Controls.Add(this.dgvKorisnici);
            this.grpKorisnici.Location = new System.Drawing.Point(12, 12);
            this.grpKorisnici.Name = "grpKorisnici";
            this.grpKorisnici.Size = new System.Drawing.Size(690, 476);
            this.grpKorisnici.TabIndex = 0;
            this.grpKorisnici.TabStop = false;
            this.grpKorisnici.Text = "Korisnici";
            // 
            // dgvKorisnici
            // 
            this.dgvKorisnici.AllowUserToAddRows = false;
            this.dgvKorisnici.AllowUserToDeleteRows = false;
            this.dgvKorisnici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKorisnici.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKorisnici.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvKorisnici.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnici.ContextMenuStrip = this.cmsKorisniciActions;
            this.dgvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKorisnici.Location = new System.Drawing.Point(3, 16);
            this.dgvKorisnici.Name = "dgvKorisnici";
            this.dgvKorisnici.ReadOnly = true;
            this.dgvKorisnici.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKorisnici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKorisnici.Size = new System.Drawing.Size(684, 457);
            this.dgvKorisnici.TabIndex = 0;
            this.dgvKorisnici.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKorisnici_CellDoubleClick);
            // 
            // cmsKorisniciActions
            // 
            this.cmsKorisniciActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiProfile,
            this.tsiDodjijeliPrava});
            this.cmsKorisniciActions.Name = "cmsKorisniciActions";
            this.cmsKorisniciActions.Size = new System.Drawing.Size(153, 70);
            // 
            // tsiProfile
            // 
            this.tsiProfile.Name = "tsiProfile";
            this.tsiProfile.Size = new System.Drawing.Size(152, 22);
            this.tsiProfile.Text = "Profil";
            this.tsiProfile.Click += new System.EventHandler(this.tsiProfile_Click);
            // 
            // tsiDodjijeliPrava
            // 
            this.tsiDodjijeliPrava.Name = "tsiDodjijeliPrava";
            this.tsiDodjijeliPrava.Size = new System.Drawing.Size(152, 22);
            this.tsiDodjijeliPrava.Text = "Dodijeli prava";
            this.tsiDodjijeliPrava.Click += new System.EventHandler(this.tsiDodjijeliPrava_Click);
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 500);
            this.Controls.Add(this.grpKorisnici);
            this.Name = "frmKorisnici";
            this.Text = "Korisnici";
            this.Load += new System.EventHandler(this.frmKorisnici_Load);
            this.grpKorisnici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnici)).EndInit();
            this.cmsKorisniciActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKorisnici;
        private System.Windows.Forms.DataGridView dgvKorisnici;
        private System.Windows.Forms.ContextMenuStrip cmsKorisniciActions;
        private System.Windows.Forms.ToolStripMenuItem tsiProfile;
        private System.Windows.Forms.ToolStripMenuItem tsiDodjijeliPrava;
    }
}