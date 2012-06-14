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
            this.spcContainer = new System.Windows.Forms.SplitContainer();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.grpPrikaz = new System.Windows.Forms.GroupBox();
            this.grpNalog = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).BeginInit();
            this.spcContainer.Panel1.SuspendLayout();
            this.spcContainer.Panel2.SuspendLayout();
            this.spcContainer.SuspendLayout();
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
            // 
            // spcContainer.Panel2
            // 
            this.spcContainer.Panel2.Controls.Add(this.grpPrikaz);
            this.spcContainer.Panel2.Controls.Add(this.grpFilter);
            this.spcContainer.Size = new System.Drawing.Size(659, 363);
            this.spcContainer.SplitterDistance = 219;
            this.spcContainer.TabIndex = 0;
            // 
            // grpFilter
            // 
            this.grpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFilter.Location = new System.Drawing.Point(9, 12);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(415, 100);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // grpPrikaz
            // 
            this.grpPrikaz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPrikaz.Location = new System.Drawing.Point(9, 118);
            this.grpPrikaz.Name = "grpPrikaz";
            this.grpPrikaz.Size = new System.Drawing.Size(415, 233);
            this.grpPrikaz.TabIndex = 1;
            this.grpPrikaz.TabStop = false;
            this.grpPrikaz.Text = "Prikaz";
            // 
            // grpNalog
            // 
            this.grpNalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNalog.Location = new System.Drawing.Point(12, 12);
            this.grpNalog.Name = "grpNalog";
            this.grpNalog.Size = new System.Drawing.Size(199, 339);
            this.grpNalog.TabIndex = 0;
            this.grpNalog.TabStop = false;
            this.grpNalog.Text = "Putni nalog";
            // 
            // frmPutniNalozi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 363);
            this.Controls.Add(this.spcContainer);
            this.Name = "frmPutniNalozi";
            this.Text = "Putni nalozi";
            this.spcContainer.Panel1.ResumeLayout(false);
            this.spcContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcContainer)).EndInit();
            this.spcContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcContainer;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.GroupBox grpPrikaz;
        private System.Windows.Forms.GroupBox grpNalog;
    }
}