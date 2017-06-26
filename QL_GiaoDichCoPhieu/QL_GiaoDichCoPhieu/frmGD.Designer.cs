namespace QL_GiaoDichCoPhieu
{
    partial class frmGD
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
        {            this.gctGD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnSK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gctGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gctGD
            // 
            this.gctGD.Location = new System.Drawing.Point(43, 90);
            this.gctGD.MainView = this.gridView1;
            this.gctGD.Name = "gctGD";
            this.gctGD.Size = new System.Drawing.Size(442, 200);
            this.gctGD.TabIndex = 9;
            this.gctGD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gctGD;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-mm-dd";
            this.dtpFromDate.Location = new System.Drawing.Point(259, 48);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(140, 20);
            this.dtpFromDate.TabIndex = 8;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-mm-dd";
            this.dtpToDate.Location = new System.Drawing.Point(43, 48);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(140, 20);
            this.dtpToDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(410, 46);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 10;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnSK
            // 
            this.btnSK.Location = new System.Drawing.Point(512, 90);
            this.btnSK.Name = "btnSK";
            this.btnSK.Size = new System.Drawing.Size(75, 23);
            this.btnSK.TabIndex = 11;
            this.btnSK.Text = "Sao kê";
            this.btnSK.UseVisualStyleBackColor = true;
            this.btnSK.Click += new System.EventHandler(this.btnSK_Click);
            // 
            // frmGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 310);
            this.Controls.Add(this.btnSK);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.gctGD);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGD";
            this.Text = "frmGD";
            this.Load += new System.EventHandler(this.frmGD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gctGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctGD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnSK;
    }
}