namespace QL_GiaoDichCoPhieu
{
    partial class frmLK
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
        {            this.components = new System.ComponentModel.Container();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnSK = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sP_LKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_GDCPDataSet = new QL_GiaoDichCoPhieu.QL_GDCPDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGioKhop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuongKhop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaKhop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKieuKhop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_LKTableAdapter = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.SP_LKTableAdapter();
            this.tableAdapterManager = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-mm-dd";
            this.dtpFromDate.Location = new System.Drawing.Point(256, 92);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(140, 21);
            this.dtpFromDate.TabIndex = 13;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-mm-dd";
            this.dtpToDate.Location = new System.Drawing.Point(43, 92);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(140, 21);
            this.dtpToDate.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ ngày";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(407, 90);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 15;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.separatorControl1);
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.dtpFromDate);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.dtpToDate);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1300, 134);
            this.panelControl1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(39, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Thông Tin Khớp Lệnh";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(15, 40);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(470, 22);
            this.separatorControl1.TabIndex = 16;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSK);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 509);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1300, 41);
            this.panelControl2.TabIndex = 17;
            // 
            // btnSK
            // 
            this.btnSK.Location = new System.Drawing.Point(15, 7);
            this.btnSK.Name = "btnSK";
            this.btnSK.Size = new System.Drawing.Size(75, 23);
            this.btnSK.TabIndex = 11;
            this.btnSK.Text = "Sao kê";
            this.btnSK.UseVisualStyleBackColor = true;
            this.btnSK.Click += new System.EventHandler(this.btnSK_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sP_LKBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 134);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1300, 375);
            this.gridControl1.TabIndex = 18;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_LKBindingSource
            // 
            this.sP_LKBindingSource.DataMember = "SP_LK";
            this.sP_LKBindingSource.DataSource = this.qL_GDCPDataSet;
            // 
            // qL_GDCPDataSet
            // 
            this.qL_GDCPDataSet.DataSetName = "QL_GDCPDataSet";
            this.qL_GDCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLK,
            this.colMaGD,
            this.colNgayGioKhop,
            this.colSoLuongKhop,
            this.colGiaKhop,
            this.colKieuKhop});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Tìm thông tin...";
            // 
            // colMaLK
            // 
            this.colMaLK.Caption = "Mã lệnh khớp";
            this.colMaLK.FieldName = "MaLK";
            this.colMaLK.Name = "colMaLK";
            this.colMaLK.Visible = true;
            this.colMaLK.VisibleIndex = 0;
            // 
            // colMaGD
            // 
            this.colMaGD.Caption = "Mã giao dịch";
            this.colMaGD.FieldName = "MaGD";
            this.colMaGD.Name = "colMaGD";
            this.colMaGD.Visible = true;
            this.colMaGD.VisibleIndex = 1;
            // 
            // colNgayGioKhop
            // 
            this.colNgayGioKhop.Caption = "Ngày giờ khớp";
            this.colNgayGioKhop.FieldName = "NgayGioKhop";
            this.colNgayGioKhop.Name = "colNgayGioKhop";
            this.colNgayGioKhop.Visible = true;
            this.colNgayGioKhop.VisibleIndex = 2;
            // 
            // colSoLuongKhop
            // 
            this.colSoLuongKhop.Caption = "Số lượng khớp";
            this.colSoLuongKhop.FieldName = "SoLuongKhop";
            this.colSoLuongKhop.Name = "colSoLuongKhop";
            this.colSoLuongKhop.Visible = true;
            this.colSoLuongKhop.VisibleIndex = 3;
            // 
            // colGiaKhop
            // 
            this.colGiaKhop.Caption = "Giá khớp";
            this.colGiaKhop.FieldName = "GiaKhop";
            this.colGiaKhop.Name = "colGiaKhop";
            this.colGiaKhop.Visible = true;
            this.colGiaKhop.VisibleIndex = 4;
            // 
            // colKieuKhop
            // 
            this.colKieuKhop.Caption = "Kiểu khớp";
            this.colKieuKhop.FieldName = "KieuKhop";
            this.colKieuKhop.Name = "colKieuKhop";
            this.colKieuKhop.Visible = true;
            this.colKieuKhop.VisibleIndex = 5;
            // 
            // sP_LKTableAdapter
            // 
            this.sP_LKTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COPHIEUTableAdapter = null;
            this.tableAdapterManager.LENHDATTableAdapter = null;
            this.tableAdapterManager.LENHKHOPTableAdapter = null;
            this.tableAdapterManager.LICHSUGIATableAdapter = null;
            this.tableAdapterManager.NDTTableAdapter = null;
            this.tableAdapterManager.NGANHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.TAIKHOAN_NGANHANGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmLK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLK";
            this.Text = "frmLK";
            this.Load += new System.EventHandler(this.frmLK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Button btnSK;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QL_GDCPDataSet qL_GDCPDataSet;
        private System.Windows.Forms.BindingSource sP_LKBindingSource;
        private QL_GDCPDataSetTableAdapters.SP_LKTableAdapter sP_LKTableAdapter;
        private QL_GDCPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLK;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGioKhop;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuongKhop;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaKhop;
        private DevExpress.XtraGrid.Columns.GridColumn colKieuKhop;
    }
}