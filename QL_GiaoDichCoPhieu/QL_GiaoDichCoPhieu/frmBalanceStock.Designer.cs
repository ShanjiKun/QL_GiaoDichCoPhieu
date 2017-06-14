namespace QL_GiaoDichCoPhieu
{
    partial class frmBalanceStock
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
            this.gctBalanceStock = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gctBalanceStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gctBalanceStock
            // 
            this.gctBalanceStock.Location = new System.Drawing.Point(12, 12);
            this.gctBalanceStock.MainView = this.gridView1;
            this.gctBalanceStock.Name = "gctBalanceStock";
            this.gctBalanceStock.Size = new System.Drawing.Size(487, 248);
            this.gctBalanceStock.TabIndex = 0;
            this.gctBalanceStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gctBalanceStock;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // frmBalanceStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 272);
            this.Controls.Add(this.gctBalanceStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBalanceStock";
            this.Text = "frmBalanceStock";
            this.Load += new System.EventHandler(this.frmBalanceStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gctBalanceStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctBalanceStock;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}