namespace PutniNalozi.NET
{
    partial class frmUredjivanjePrava
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
            this.grpDodjeljenaPrava = new System.Windows.Forms.GroupBox();
            this.dgvDodjeljenaPrava = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korisnikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulogaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumdoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razlogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivanDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmsUredjivanjePravaActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsiMakniPrava = new System.Windows.Forms.ToolStripMenuItem();
            this.ulogaBS = new System.Windows.Forms.BindingSource(this.components);
            this.piDB9DS = new PutniNalozi.NET.piDB9DS();
            this.ulogaTA = new PutniNalozi.NET.piDB9DSTableAdapters.ulogaTA();
            this.tsiUkljuciPrava = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDodjeljenaPrava.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodjeljenaPrava)).BeginInit();
            this.cmsUredjivanjePravaActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB9DS)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDodjeljenaPrava
            // 
            this.grpDodjeljenaPrava.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDodjeljenaPrava.Controls.Add(this.dgvDodjeljenaPrava);
            this.grpDodjeljenaPrava.Location = new System.Drawing.Point(12, 12);
            this.grpDodjeljenaPrava.Name = "grpDodjeljenaPrava";
            this.grpDodjeljenaPrava.Size = new System.Drawing.Size(724, 380);
            this.grpDodjeljenaPrava.TabIndex = 0;
            this.grpDodjeljenaPrava.TabStop = false;
            this.grpDodjeljenaPrava.Text = "Dodjeljena prava";
            // 
            // dgvDodjeljenaPrava
            // 
            this.dgvDodjeljenaPrava.AllowUserToAddRows = false;
            this.dgvDodjeljenaPrava.AllowUserToDeleteRows = false;
            this.dgvDodjeljenaPrava.AutoGenerateColumns = false;
            this.dgvDodjeljenaPrava.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDodjeljenaPrava.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDodjeljenaPrava.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDodjeljenaPrava.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDodjeljenaPrava.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDodjeljenaPrava.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.korisnikDataGridViewTextBoxColumn,
            this.ulogaDataGridViewTextBoxColumn,
            this.datumodDataGridViewTextBoxColumn,
            this.datumdoDataGridViewTextBoxColumn,
            this.razlogDataGridViewTextBoxColumn,
            this.aktivanDataGridViewCheckBoxColumn});
            this.dgvDodjeljenaPrava.ContextMenuStrip = this.cmsUredjivanjePravaActions;
            this.dgvDodjeljenaPrava.DataSource = this.ulogaBS;
            this.dgvDodjeljenaPrava.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDodjeljenaPrava.Location = new System.Drawing.Point(3, 16);
            this.dgvDodjeljenaPrava.Name = "dgvDodjeljenaPrava";
            this.dgvDodjeljenaPrava.ReadOnly = true;
            this.dgvDodjeljenaPrava.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDodjeljenaPrava.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDodjeljenaPrava.Size = new System.Drawing.Size(718, 361);
            this.dgvDodjeljenaPrava.TabIndex = 0;
            this.dgvDodjeljenaPrava.SelectionChanged += new System.EventHandler(this.dgvDodjeljenaPrava_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // korisnikDataGridViewTextBoxColumn
            // 
            this.korisnikDataGridViewTextBoxColumn.DataPropertyName = "korisnik";
            this.korisnikDataGridViewTextBoxColumn.HeaderText = "Korisnik";
            this.korisnikDataGridViewTextBoxColumn.Name = "korisnikDataGridViewTextBoxColumn";
            this.korisnikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ulogaDataGridViewTextBoxColumn
            // 
            this.ulogaDataGridViewTextBoxColumn.DataPropertyName = "uloga";
            this.ulogaDataGridViewTextBoxColumn.HeaderText = "Uloga";
            this.ulogaDataGridViewTextBoxColumn.Name = "ulogaDataGridViewTextBoxColumn";
            this.ulogaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumodDataGridViewTextBoxColumn
            // 
            this.datumodDataGridViewTextBoxColumn.DataPropertyName = "datum_od";
            this.datumodDataGridViewTextBoxColumn.HeaderText = "Od";
            this.datumodDataGridViewTextBoxColumn.Name = "datumodDataGridViewTextBoxColumn";
            this.datumodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumdoDataGridViewTextBoxColumn
            // 
            this.datumdoDataGridViewTextBoxColumn.DataPropertyName = "datum_do";
            this.datumdoDataGridViewTextBoxColumn.HeaderText = "Do";
            this.datumdoDataGridViewTextBoxColumn.Name = "datumdoDataGridViewTextBoxColumn";
            this.datumdoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // razlogDataGridViewTextBoxColumn
            // 
            this.razlogDataGridViewTextBoxColumn.DataPropertyName = "razlog";
            this.razlogDataGridViewTextBoxColumn.HeaderText = "Razlog";
            this.razlogDataGridViewTextBoxColumn.Name = "razlogDataGridViewTextBoxColumn";
            this.razlogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aktivanDataGridViewCheckBoxColumn
            // 
            this.aktivanDataGridViewCheckBoxColumn.DataPropertyName = "aktivan";
            this.aktivanDataGridViewCheckBoxColumn.HeaderText = "Aktivan";
            this.aktivanDataGridViewCheckBoxColumn.Name = "aktivanDataGridViewCheckBoxColumn";
            this.aktivanDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // cmsUredjivanjePravaActions
            // 
            this.cmsUredjivanjePravaActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiUkljuciPrava,
            this.tsiMakniPrava});
            this.cmsUredjivanjePravaActions.Name = "cmsUredjivanjePravaActions";
            this.cmsUredjivanjePravaActions.Size = new System.Drawing.Size(153, 70);
            // 
            // tsiMakniPrava
            // 
            this.tsiMakniPrava.Name = "tsiMakniPrava";
            this.tsiMakniPrava.Size = new System.Drawing.Size(146, 22);
            this.tsiMakniPrava.Text = "Makni prava";
            this.tsiMakniPrava.Click += new System.EventHandler(this.tsiMakniPrava_Click);
            // 
            // ulogaBS
            // 
            this.ulogaBS.DataMember = "uloga";
            this.ulogaBS.DataSource = this.piDB9DS;
            // 
            // piDB9DS
            // 
            this.piDB9DS.DataSetName = "piDB9DS";
            this.piDB9DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ulogaTA
            // 
            this.ulogaTA.ClearBeforeFill = true;
            // 
            // tsiUkljuciPrava
            // 
            this.tsiUkljuciPrava.Name = "tsiUkljuciPrava";
            this.tsiUkljuciPrava.Size = new System.Drawing.Size(152, 22);
            this.tsiUkljuciPrava.Text = "Uključi prava";
            this.tsiUkljuciPrava.Click += new System.EventHandler(this.tsiUkljuciPrava_Click);
            // 
            // frmUredjivanjePrava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 404);
            this.Controls.Add(this.grpDodjeljenaPrava);
            this.Name = "frmUredjivanjePrava";
            this.Text = "Uređivanje prava";
            this.Load += new System.EventHandler(this.frmUredjivanjePrava_Load);
            this.grpDodjeljenaPrava.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodjeljenaPrava)).EndInit();
            this.cmsUredjivanjePravaActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ulogaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB9DS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDodjeljenaPrava;
        private System.Windows.Forms.DataGridView dgvDodjeljenaPrava;
        private piDB9DS piDB9DS;
        private System.Windows.Forms.BindingSource ulogaBS;
        private piDB9DSTableAdapters.ulogaTA ulogaTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn korisnikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulogaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumdoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razlogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivanDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ContextMenuStrip cmsUredjivanjePravaActions;
        private System.Windows.Forms.ToolStripMenuItem tsiMakniPrava;
        private System.Windows.Forms.ToolStripMenuItem tsiUkljuciPrava;

    }
}