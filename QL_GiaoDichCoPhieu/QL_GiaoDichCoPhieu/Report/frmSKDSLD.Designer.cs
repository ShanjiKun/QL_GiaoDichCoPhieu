namespace QL_GiaoDichCoPhieu.Report
{
    partial class frmSKDSLD
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
            this.crvSKDSLD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptSKDSLD1 = new QL_GiaoDichCoPhieu.Report.rptSKDSLD();
            this.SuspendLayout();
            // 
            // crvSKDSLD
            // 
            this.crvSKDSLD.ActiveViewIndex = 0;
            this.crvSKDSLD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSKDSLD.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSKDSLD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSKDSLD.Location = new System.Drawing.Point(0, 0);
            this.crvSKDSLD.Name = "crvSKDSLD";
            this.crvSKDSLD.ReportSource = this.rptSKDSLD1;
            this.crvSKDSLD.Size = new System.Drawing.Size(694, 371);
            this.crvSKDSLD.TabIndex = 0;
            this.crvSKDSLD.Load += new System.EventHandler(this.crvSKDSLD_Load);
            // 
            // frmSKDSLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 371);
            this.Controls.Add(this.crvSKDSLD);
            this.Name = "frmSKDSLD";
            this.Text = "frmSKDSLD";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSKDSLD;
        private rptSKDSLD rptSKDSLD1;
    }
}