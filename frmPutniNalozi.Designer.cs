namespace PutniNalozi.NET
{
    partial class frmPutniNalozi
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
            this.spcContainer = new System.Windows.Forms.SplitContainer();
            this.grpNalog = new System.Windows.Forms.GroupBox();
            this.btnOdobri = new System.Windows.Forms.Button();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.putniNalogBS = new System.Windows.Forms.BindingSource(this.components);
            this.piDB9DS = new PutniNalozi.NET.piDB9DS();
            this.txtDatumPolaska = new System.Windows.Forms.TextBox();
            this.txtDatumKreiranja = new System.Windows.Forms.TextBox();
            this.txtOdobravatelj = new System.Windows.Forms.TextBox();
            this.lblOdobrio = new System.Windows.Forms.Label();
            this.btnVoziloInfo = new System.Windows.Forms.Button();
            this.txtVozilo = new System.Windows.Forms.TextBox();
            this.lblVozilo = new System.Windows.Forms.Label();
            this.lblTrajanje = new System.Windows.Forms.Label();
            this.txtSvrha = new System.Windows.Forms.TextBox();
            this.lblSvrha = new System.Windows.Forms.Label();
            this.txtOdrediste = new System.Windows.Forms.TextBox();
            this.lblOdrediste = new System.Windows.Forms.Label();
            this.lblDatumPolaska = new System.Windows.Forms.Label();
            this.btnKorisnikInfo = new System.Windows.Forms.Button();
            this.txtZahtjevatelj = new System.Windows.Forms.TextBox();
            this.lblZahtjevatelj = new System.Windows.Forms.Label();
            this.lblDatumKreiranja = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtKatedra = new System.Windows.Forms.TextBox();
            this.lblKatedra = new System.Windows.Forms.Label();
            this.txtUstanova = new System.Windows.Forms.TextBox();
            this.lblUstanova = new System.Windows.Forms.Label();
            this.grpPrikaz = new System.Windows.Forms.GroupBox();
            this.dgvPutniNalozi = new System.Windows.Forms.DataGridView();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.voziloBS = new System.Windows.Forms.BindingSource(this.components);
            this.statusNalogaBS = new System.Windows.Forms.BindingSource(this.components);
            this.putniNalogTA = new PutniNalozi.NET.piDB9DSTableAdapters.putniNalogTA();
            this.statusNalogaTA = new PutniNalozi.NET.piDB9DSTableAdapters.statusNalogaTA();
            this.voziloTA = new PutniNalozi.NET.piDB9DSTableAdapters.voziloTA();
            this.ustanovaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumkreiranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zahtjevateljDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumpolaskaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odredisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.svrhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vozilotipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.katedraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusnazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odobravateljDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).BeginInit();
            this.spcContainer.Panel1.SuspendLayout();
            this.spcContainer.Panel2.SuspendLayout();
            this.spcContainer.SuspendLayout();
            this.grpNalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB9DS)).BeginInit();
            this.grpPrikaz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutniNalozi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBS)).BeginInit();
            this.SuspendLayout();
            // 
            // spcContainer
            // 
            this.spcContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcContainer.Location = new System.Drawing.Point(0, 0);
            this.spcContainer.Name = "spcContainer";
            // 
            // spcContainer.Panel1
            // 
            this.spcContainer.Panel1.Controls.Add(this.grpNalog);
            this.spcContainer.Panel1MinSize = 300;
            // 
            // spcContainer.Panel2
            // 
            this.spcContainer.Panel2.Controls.Add(this.grpPrikaz);
            this.spcContainer.Panel2.Controls.Add(this.grpFilter);
            this.spcContainer.Panel2MinSize = 400;
            this.spcContainer.Size = new System.Drawing.Size(1028, 580);
            this.spcContainer.SplitterDistance = 342;
            this.spcContainer.TabIndex = 0;
            // 
            // grpNalog
            // 
            this.grpNalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNalog.Controls.Add(this.btnOdobri);
            this.grpNalog.Controls.Add(this.txtTrajanje);
            this.grpNalog.Controls.Add(this.txtDatumPolaska);
            this.grpNalog.Controls.Add(this.txtDatumKreiranja);
            this.grpNalog.Controls.Add(this.txtOdobravatelj);
            this.grpNalog.Controls.Add(this.lblOdobrio);
            this.grpNalog.Controls.Add(this.btnVoziloInfo);
            this.grpNalog.Controls.Add(this.txtVozilo);
            this.grpNalog.Controls.Add(this.lblVozilo);
            this.grpNalog.Controls.Add(this.lblTrajanje);
            this.grpNalog.Controls.Add(this.txtSvrha);
            this.grpNalog.Controls.Add(this.lblSvrha);
            this.grpNalog.Controls.Add(this.txtOdrediste);
            this.grpNalog.Controls.Add(this.lblOdrediste);
            this.grpNalog.Controls.Add(this.lblDatumPolaska);
            this.grpNalog.Controls.Add(this.btnKorisnikInfo);
            this.grpNalog.Controls.Add(this.txtZahtjevatelj);
            this.grpNalog.Controls.Add(this.lblZahtjevatelj);
            this.grpNalog.Controls.Add(this.lblDatumKreiranja);
            this.grpNalog.Controls.Add(this.txtId);
            this.grpNalog.Controls.Add(this.lblId);
            this.grpNalog.Controls.Add(this.txtKatedra);
            this.grpNalog.Controls.Add(this.lblKatedra);
            this.grpNalog.Controls.Add(this.txtUstanova);
            this.grpNalog.Controls.Add(this.lblUstanova);
            this.grpNalog.Location = new System.Drawing.Point(12, 12);
            this.grpNalog.Name = "grpNalog";
            this.grpNalog.Size = new System.Drawing.Size(322, 556);
            this.grpNalog.TabIndex = 0;
            this.grpNalog.TabStop = false;
            this.grpNalog.Text = "Putni nalog";
            // 
            // btnOdobri
            // 
            this.btnOdobri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOdobri.Location = new System.Drawing.Point(201, 501);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(115, 49);
            this.btnOdobri.TabIndex = 28;
            this.btnOdobri.Text = "Odobri";
            this.btnOdobri.UseVisualStyleBackColor = true;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrajanje.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putniNalogBS, "trajanje", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.txtTrajanje.Location = new System.Drawing.Point(95, 265);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(221, 20);
            this.txtTrajanje.TabIndex = 27;
            // 
            // putniNalogBS
            // 
            this.putniNalogBS.DataMember = "putni_nalog";
            this.putniNalogBS.DataSource = this.piDB9DS;
            // 
            // piDB9DS
            // 
            this.piDB9DS.DataSetName = "piDB9DS";
            this.piDB9DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtDatumPolaska
            // 
            this.txtDatumPolaska.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatumPolaska.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putniNalogBS, "datum_polaska", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.txtDatumPolaska.Location = new System.Drawing.Point(95, 123);
            this.txtDatumPolaska.Name = "txtDatumPolaska";
            this.txtDatumPolaska.Size = new System.Drawing.Size(221, 20);
            this.txtDatumPolaska.TabIndex = 26;
            // 
            // txtDatumKreiranja
            // 
            this.txtDatumKreiranja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDatumKreiranja.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putniNalogBS, "datum_kreiranja", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "D"));
            this.txtDatumKreiranja.Location = new System.Drawing.Point(95, 71);
            this.txtDatumKreiranja.Name = "txtDatumKreiranja";
            this.txtDatumKreiranja.Size = new System.Drawing.Size(221, 20);
            this.txtDatumKreiranja.TabIndex = 25;
            // 
            // txtOdobravatelj
            // 
            this.txtOdobravatelj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOdobravatelj.Location = new System.Drawing.Point(95, 343);
            this.txtOdobravatelj.Name = "txtOdobravatelj";
            this.txtOdobravatelj.Size = new System.Drawing.Size(221, 20);
            this.txtOdobravatelj.TabIndex = 24;
            // 
            // lblOdobrio
            // 
            this.lblOdobrio.AutoSize = true;
            this.lblOdobrio.Location = new System.Drawing.Point(7, 346);
            this.lblOdobrio.Name = "lblOdobrio";
            this.lblOdobrio.Size = new System.Drawing.Size(44, 13);
            this.lblOdobrio.TabIndex = 23;
            this.lblOdobrio.Text = "Odobrio";
            // 
            // btnVoziloInfo
            // 
            this.btnVoziloInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoziloInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVoziloInfo.Location = new System.Drawing.Point(293, 291);
            this.btnVoziloInfo.Name = "btnVoziloInfo";
            this.btnVoziloInfo.Size = new System.Drawing.Size(23, 20);
            this.btnVoziloInfo.TabIndex = 22;
            this.btnVoziloInfo.Text = "?";
            this.btnVoziloInfo.UseVisualStyleBackColor = true;
            // 
            // txtVozilo
            // 
            this.txtVozilo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVozilo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putniNalogBS, "vozilo_id", true));
            this.txtVozilo.Location = new System.Drawing.Point(95, 291);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.Size = new System.Drawing.Size(192, 20);
            this.txtVozilo.TabIndex = 21;
            // 
            // lblVozilo
            // 
            this.lblVozilo.AutoSize = true;
            this.lblVozilo.Location = new System.Drawing.Point(7, 294);
            this.lblVozilo.Name = "lblVozilo";
            this.lblVozilo.Size = new System.Drawing.Size(35, 13);
            this.lblVozilo.TabIndex = 20;
            this.lblVozilo.Text = "Vozilo";
            // 
            // lblTrajanje
            // 
            this.lblTrajanje.AutoSize = true;
            this.lblTrajanje.Location = new System.Drawing.Point(7, 268);
            this.lblTrajanje.Name = "lblTrajanje";
            this.lblTrajanje.Size = new System.Drawing.Size(45, 13);
            this.lblTrajanje.TabIndex = 19;
            this.lblTrajanje.Text = "Trajanje";
            // 
            // txtSvrha
            // 
            this.txtSvrha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSvrha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putniNalogBS, "svrha", true));
            this.txtSvrha.Location = new System.Drawing.Point(95, 175);
            this.txtSvrha.Multiline = true;
            this.txtSvrha.Name = "txtSvrha";
            this.txtSvrha.Size = new System.Drawing.Size(221, 84);
            this.txtSvrha.TabIndex = 17;
            // 
            // lblSvrha
            // 
            this.lblSvrha.AutoSize = true;
            this.lblSvrha.Location = new System.Drawing.Point(7, 178);
            this.lblSvrha.Name = "lblSvrha";
            this.lblSvrha.Size = new System.Drawing.Size(35, 13);
            this.lblSvrha.TabIndex = 16;
            this.lblSvrha.Text = "Svrha";
            // 
            // txtOdrediste
            // 
            this.txtOdrediste.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOdrediste.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putniNalogBS, "odrediste", true));
            this.txtOdrediste.Location = new System.Drawing.Point(95, 149);
            this.txtOdrediste.Name = "txtOdrediste";
            this.txtOdrediste.Size = new System.Drawing.Size(221, 20);
            this.txtOdrediste.TabIndex = 15;
            // 
            // lblOdrediste
            // 
            this.lblOdrediste.AutoSize = true;
            this.lblOdrediste.Location = new System.Drawing.Point(7, 152);
            this.lblOdrediste.Name = "lblOdrediste";
            this.lblOdrediste.Size = new System.Drawing.Size(52, 13);
            this.lblOdrediste.TabIndex = 14;
            this.lblOdrediste.Text = "Odredište";
            // 
            // lblDatumPolaska
            // 
            this.lblDatumPolaska.AutoSize = true;
            this.lblDatumPolaska.Location = new System.Drawing.Point(7, 126);
            this.lblDatumPolaska.Name = "lblDatumPolaska";
            this.lblDatumPolaska.Size = new System.Drawing.Size(78, 13);
            this.lblDatumPolaska.TabIndex = 12;
            this.lblDatumPolaska.Text = "Datum polaska";
            // 
            // btnKorisnikInfo
            // 
            this.btnKorisnikInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKorisnikInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKorisnikInfo.Location = new System.Drawing.Point(293, 97);
            this.btnKorisnikInfo.Name = "btnKorisnikInfo";
            this.btnKorisnikInfo.Size = new System.Drawing.Size(23, 20);
            this.btnKorisnikInfo.TabIndex = 11;
            this.btnKorisnikInfo.Text = "?";
            this.btnKorisnikInfo.UseVisualStyleBackColor = true;
            // 
            // txtZahtjevatelj
            // 
            this.txtZahtjevatelj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtZahtjevatelj.Location = new System.Drawing.Point(95, 97);
            this.txtZahtjevatelj.Name = "txtZahtjevatelj";
            this.txtZahtjevatelj.Size = new System.Drawing.Size(192, 20);
            this.txtZahtjevatelj.TabIndex = 9;
            // 
            // lblZahtjevatelj
            // 
            this.lblZahtjevatelj.AutoSize = true;
            this.lblZahtjevatelj.Location = new System.Drawing.Point(7, 100);
            this.lblZahtjevatelj.Name = "lblZahtjevatelj";
            this.lblZahtjevatelj.Size = new System.Drawing.Size(62, 13);
            this.lblZahtjevatelj.TabIndex = 8;
            this.lblZahtjevatelj.Text = "Zahtjevatelj";
            // 
            // lblDatumKreiranja
            // 
            this.lblDatumKreiranja.AutoSize = true;
            this.lblDatumKreiranja.Location = new System.Drawing.Point(7, 74);
            this.lblDatumKreiranja.Name = "lblDatumKreiranja";
            this.lblDatumKreiranja.Size = new System.Drawing.Size(81, 13);
            this.lblDatumKreiranja.TabIndex = 6;
            this.lblDatumKreiranja.Text = "Datum kreiranja";
            // 
            // txtId
            // 
            this.txtId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putniNalogBS, "id", true));
            this.txtId.Location = new System.Drawing.Point(95, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(221, 20);
            this.txtId.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(7, 48);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 13);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Broj";
            // 
            // txtKatedra
            // 
            this.txtKatedra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKatedra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putniNalogBS, "katedra", true));
            this.txtKatedra.Location = new System.Drawing.Point(95, 317);
            this.txtKatedra.Name = "txtKatedra";
            this.txtKatedra.Size = new System.Drawing.Size(221, 20);
            this.txtKatedra.TabIndex = 3;
            // 
            // lblKatedra
            // 
            this.lblKatedra.AutoSize = true;
            this.lblKatedra.Location = new System.Drawing.Point(7, 320);
            this.lblKatedra.Name = "lblKatedra";
            this.lblKatedra.Size = new System.Drawing.Size(44, 13);
            this.lblKatedra.TabIndex = 2;
            this.lblKatedra.Text = "Katedra";
            // 
            // txtUstanova
            // 
            this.txtUstanova.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUstanova.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.putniNalogBS, "ustanova", true));
            this.txtUstanova.Location = new System.Drawing.Point(95, 19);
            this.txtUstanova.Name = "txtUstanova";
            this.txtUstanova.Size = new System.Drawing.Size(221, 20);
            this.txtUstanova.TabIndex = 1;
            // 
            // lblUstanova
            // 
            this.lblUstanova.AutoSize = true;
            this.lblUstanova.Location = new System.Drawing.Point(7, 22);
            this.lblUstanova.Name = "lblUstanova";
            this.lblUstanova.Size = new System.Drawing.Size(53, 13);
            this.lblUstanova.TabIndex = 0;
            this.lblUstanova.Text = "Ustanova";
            // 
            // grpPrikaz
            // 
            this.grpPrikaz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPrikaz.Controls.Add(this.dgvPutniNalozi);
            this.grpPrikaz.Location = new System.Drawing.Point(9, 118);
            this.grpPrikaz.Name = "grpPrikaz";
            this.grpPrikaz.Size = new System.Drawing.Size(661, 450);
            this.grpPrikaz.TabIndex = 1;
            this.grpPrikaz.TabStop = false;
            this.grpPrikaz.Text = "Prikaz";
            // 
            // dgvPutniNalozi
            // 
            this.dgvPutniNalozi.AllowUserToAddRows = false;
            this.dgvPutniNalozi.AllowUserToDeleteRows = false;
            this.dgvPutniNalozi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPutniNalozi.AutoGenerateColumns = false;
            this.dgvPutniNalozi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPutniNalozi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPutniNalozi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ustanovaDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.datumkreiranjaDataGridViewTextBoxColumn,
            this.zahtjevateljDataGridViewTextBoxColumn,
            this.datumpolaskaDataGridViewTextBoxColumn,
            this.odredisteDataGridViewTextBoxColumn,
            this.svrhaDataGridViewTextBoxColumn,
            this.trajanjeDataGridViewTextBoxColumn,
            this.vozilotipDataGridViewTextBoxColumn,
            this.katedraDataGridViewTextBoxColumn,
            this.statusnazivDataGridViewTextBoxColumn,
            this.odobravateljDataGridViewTextBoxColumn});
            this.dgvPutniNalozi.DataSource = this.putniNalogBS;
            this.dgvPutniNalozi.Location = new System.Drawing.Point(6, 17);
            this.dgvPutniNalozi.Name = "dgvPutniNalozi";
            this.dgvPutniNalozi.ReadOnly = true;
            this.dgvPutniNalozi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPutniNalozi.Size = new System.Drawing.Size(649, 427);
            this.dgvPutniNalozi.TabIndex = 0;
            this.dgvPutniNalozi.SelectionChanged += new System.EventHandler(this.dgvPutniNalozi_SelectionChanged);
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.Location = new System.Drawing.Point(9, 12);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(661, 100);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // voziloBS
            // 
            this.voziloBS.DataMember = "vozilo";
            this.voziloBS.DataSource = this.piDB9DS;
            // 
            // statusNalogaBS
            // 
            this.statusNalogaBS.DataMember = "status_naloga";
            this.statusNalogaBS.DataSource = this.piDB9DS;
            // 
            // putniNalogTA
            // 
            this.putniNalogTA.ClearBeforeFill = true;
            // 
            // statusNalogaTA
            // 
            this.statusNalogaTA.ClearBeforeFill = true;
            // 
            // voziloTA
            // 
            this.voziloTA.ClearBeforeFill = true;
            // 
            // ustanovaDataGridViewTextBoxColumn
            // 
            this.ustanovaDataGridViewTextBoxColumn.DataPropertyName = "ustanova";
            this.ustanovaDataGridViewTextBoxColumn.HeaderText = "Ustanova";
            this.ustanovaDataGridViewTextBoxColumn.Name = "ustanovaDataGridViewTextBoxColumn";
            this.ustanovaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ustanovaDataGridViewTextBoxColumn.Width = 76;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Broj";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 48;
            // 
            // datumkreiranjaDataGridViewTextBoxColumn
            // 
            this.datumkreiranjaDataGridViewTextBoxColumn.DataPropertyName = "datum_kreiranja";
            this.datumkreiranjaDataGridViewTextBoxColumn.HeaderText = "Datum kreiranja";
            this.datumkreiranjaDataGridViewTextBoxColumn.Name = "datumkreiranjaDataGridViewTextBoxColumn";
            this.datumkreiranjaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumkreiranjaDataGridViewTextBoxColumn.Width = 95;
            // 
            // zahtjevateljDataGridViewTextBoxColumn
            // 
            this.zahtjevateljDataGridViewTextBoxColumn.DataPropertyName = "zahtjevatelj";
            this.zahtjevateljDataGridViewTextBoxColumn.HeaderText = "Zahtjevatelj";
            this.zahtjevateljDataGridViewTextBoxColumn.Name = "zahtjevateljDataGridViewTextBoxColumn";
            this.zahtjevateljDataGridViewTextBoxColumn.ReadOnly = true;
            this.zahtjevateljDataGridViewTextBoxColumn.Width = 85;
            // 
            // datumpolaskaDataGridViewTextBoxColumn
            // 
            this.datumpolaskaDataGridViewTextBoxColumn.DataPropertyName = "datum_polaska";
            this.datumpolaskaDataGridViewTextBoxColumn.HeaderText = "Datum polaska";
            this.datumpolaskaDataGridViewTextBoxColumn.Name = "datumpolaskaDataGridViewTextBoxColumn";
            this.datumpolaskaDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumpolaskaDataGridViewTextBoxColumn.Width = 93;
            // 
            // odredisteDataGridViewTextBoxColumn
            // 
            this.odredisteDataGridViewTextBoxColumn.DataPropertyName = "odrediste";
            this.odredisteDataGridViewTextBoxColumn.HeaderText = "Odrediste";
            this.odredisteDataGridViewTextBoxColumn.Name = "odredisteDataGridViewTextBoxColumn";
            this.odredisteDataGridViewTextBoxColumn.ReadOnly = true;
            this.odredisteDataGridViewTextBoxColumn.Width = 75;
            // 
            // svrhaDataGridViewTextBoxColumn
            // 
            this.svrhaDataGridViewTextBoxColumn.DataPropertyName = "svrha";
            this.svrhaDataGridViewTextBoxColumn.HeaderText = "Svrha";
            this.svrhaDataGridViewTextBoxColumn.Name = "svrhaDataGridViewTextBoxColumn";
            this.svrhaDataGridViewTextBoxColumn.ReadOnly = true;
            this.svrhaDataGridViewTextBoxColumn.Width = 58;
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            this.trajanjeDataGridViewTextBoxColumn.ReadOnly = true;
            this.trajanjeDataGridViewTextBoxColumn.Width = 68;
            // 
            // vozilotipDataGridViewTextBoxColumn
            // 
            this.vozilotipDataGridViewTextBoxColumn.DataPropertyName = "vozilo_tip";
            this.vozilotipDataGridViewTextBoxColumn.HeaderText = "Vozilo";
            this.vozilotipDataGridViewTextBoxColumn.Name = "vozilotipDataGridViewTextBoxColumn";
            this.vozilotipDataGridViewTextBoxColumn.ReadOnly = true;
            this.vozilotipDataGridViewTextBoxColumn.Width = 58;
            // 
            // katedraDataGridViewTextBoxColumn
            // 
            this.katedraDataGridViewTextBoxColumn.DataPropertyName = "katedra";
            this.katedraDataGridViewTextBoxColumn.HeaderText = "Katedra";
            this.katedraDataGridViewTextBoxColumn.Name = "katedraDataGridViewTextBoxColumn";
            this.katedraDataGridViewTextBoxColumn.ReadOnly = true;
            this.katedraDataGridViewTextBoxColumn.Width = 67;
            // 
            // statusnazivDataGridViewTextBoxColumn
            // 
            this.statusnazivDataGridViewTextBoxColumn.DataPropertyName = "status_naziv";
            this.statusnazivDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusnazivDataGridViewTextBoxColumn.Name = "statusnazivDataGridViewTextBoxColumn";
            this.statusnazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusnazivDataGridViewTextBoxColumn.Width = 60;
            // 
            // odobravateljDataGridViewTextBoxColumn
            // 
            this.odobravateljDataGridViewTextBoxColumn.DataPropertyName = "odobravatelj";
            this.odobravateljDataGridViewTextBoxColumn.HeaderText = "Odobravatelj";
            this.odobravateljDataGridViewTextBoxColumn.Name = "odobravateljDataGridViewTextBoxColumn";
            this.odobravateljDataGridViewTextBoxColumn.ReadOnly = true;
            this.odobravateljDataGridViewTextBoxColumn.Width = 90;
            // 
            // frmPutniNalozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 580);
            this.Controls.Add(this.spcContainer);
            this.Name = "frmPutniNalozi";
            this.Text = "Putni nalozi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPutniNalozi_FormClosing);
            this.Load += new System.EventHandler(this.frmPutniNalozi_Load);
            this.spcContainer.Panel1.ResumeLayout(false);
            this.spcContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).EndInit();
            this.spcContainer.ResumeLayout(false);
            this.grpNalog.ResumeLayout(false);
            this.grpNalog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.putniNalogBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piDB9DS)).EndInit();
            this.grpPrikaz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPutniNalozi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voziloBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusNalogaBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcContainer;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.GroupBox grpPrikaz;
        private System.Windows.Forms.GroupBox grpNalog;
        private piDB9DS piDB9DS;
        private System.Windows.Forms.DataGridView dgvPutniNalozi;
        private System.Windows.Forms.BindingSource putniNalogBS;
        private piDB9DSTableAdapters.putniNalogTA putniNalogTA;
        private System.Windows.Forms.BindingSource statusNalogaBS;
        private piDB9DSTableAdapters.statusNalogaTA statusNalogaTA;
        private System.Windows.Forms.BindingSource voziloBS;
        private piDB9DSTableAdapters.voziloTA voziloTA;
        private System.Windows.Forms.Label lblUstanova;
        private System.Windows.Forms.TextBox txtKatedra;
        private System.Windows.Forms.Label lblKatedra;
        private System.Windows.Forms.TextBox txtUstanova;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDatumKreiranja;
        private System.Windows.Forms.TextBox txtZahtjevatelj;
        private System.Windows.Forms.Label lblZahtjevatelj;
        private System.Windows.Forms.Button btnKorisnikInfo;
        private System.Windows.Forms.Label lblDatumPolaska;
        private System.Windows.Forms.TextBox txtOdrediste;
        private System.Windows.Forms.Label lblOdrediste;
        private System.Windows.Forms.TextBox txtSvrha;
        private System.Windows.Forms.Label lblSvrha;
        private System.Windows.Forms.Label lblTrajanje;
        private System.Windows.Forms.Label lblVozilo;
        private System.Windows.Forms.Button btnVoziloInfo;
        private System.Windows.Forms.TextBox txtOdobravatelj;
        private System.Windows.Forms.Label lblOdobrio;
        private System.Windows.Forms.TextBox txtDatumKreiranja;
        private System.Windows.Forms.TextBox txtDatumPolaska;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtVozilo;
        private System.Windows.Forms.Button btnOdobri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ustanovaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumkreiranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zahtjevateljDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumpolaskaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odredisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn svrhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vozilotipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn katedraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusnazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odobravateljDataGridViewTextBoxColumn;
    }
}