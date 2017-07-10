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
        {            this.components = new System.ComponentModel.Container();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnSK = new System.Windows.Forms.Button();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gctGD = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.qL_GDCPDataSet = new QL_GiaoDichCoPhieu.QL_GDCPDataSet();
            this.lENHDATBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lENHDATTableAdapter = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.LENHDATTableAdapter();
            this.tableAdapterManager = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.TableAdapterManager();
            this.colMaGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiLenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhuongThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gctGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-mm-dd";
            this.dtpFromDate.Location = new System.Drawing.Point(256, 92);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(140, 21);
            this.dtpFromDate.TabIndex = 8;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-mm-dd";
            this.dtpToDate.Location = new System.Drawing.Point(43, 92);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(140, 21);
            this.dtpToDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(407, 90);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 10;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
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
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.separatorControl1);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.btnXem);
            this.panelControl1.Controls.Add(this.dtpToDate);
            this.panelControl1.Controls.Add(this.dtpFromDate);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1300, 134);
            this.panelControl1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(39, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Thông Tin Giao Dịch";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(15, 40);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(470, 22);
            this.separatorControl1.TabIndex = 11;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnSK);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 509);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1300, 41);
            this.panelControl2.TabIndex = 13;
            // 
            // gctGD
            // 
            this.gctGD.DataSource = this.lENHDATBindingSource;
            this.gctGD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctGD.Location = new System.Drawing.Point(0, 134);
            this.gctGD.MainView = this.gridView1;
            this.gctGD.Name = "gctGD";
            this.gctGD.Size = new System.Drawing.Size(1300, 375);
            this.gctGD.TabIndex = 14;
            this.gctGD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaGD,
            this.colNgayGD,
            this.colLoaiLenh,
            this.colPhuongThuc,
            this.colSoLuong,
            this.colMaCP,
            this.colGia,
            this.colMaTK,
            this.colTrangThai});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gctGD;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Tìm thông tin...";
            // 
            // qL_GDCPDataSet
            // 
            this.qL_GDCPDataSet.DataSetName = "QL_GDCPDataSet";
            this.qL_GDCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lENHDATBindingSource
            // 
            this.lENHDATBindingSource.DataMember = "LENHDAT";
            this.lENHDATBindingSource.DataSource = this.qL_GDCPDataSet;
            // 
            // lENHDATTableAdapter
            // 
            this.lENHDATTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COPHIEUTableAdapter = null;
            this.tableAdapterManager.LENHDATTableAdapter = this.lENHDATTableAdapter;
            this.tableAdapterManager.LENHKHOPTableAdapter = null;
            this.tableAdapterManager.LICHSUGIATableAdapter = null;
            this.tableAdapterManager.NDTTableAdapter = null;
            this.tableAdapterManager.NGANHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.TAIKHOAN_NGANHANGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // colMaGD
            // 
            this.colMaGD.Caption = "Mã giao dịch";
            this.colMaGD.FieldName = "MaGD";
            this.colMaGD.Name = "colMaGD";
            this.colMaGD.Visible = true;
            this.colMaGD.VisibleIndex = 0;
            // 
            // colNgayGD
            // 
            this.colNgayGD.Caption = " Ngày giao dịch";
            this.colNgayGD.FieldName = "NgayGD";
            this.colNgayGD.Name = "colNgayGD";
            this.colNgayGD.Visible = true;
            this.colNgayGD.VisibleIndex = 1;
            // 
            // colLoaiLenh
            // 
            this.colLoaiLenh.Caption = "Loại lệnh";
            this.colLoaiLenh.FieldName = "LoaiLenh";
            this.colLoaiLenh.Name = "colLoaiLenh";
            this.colLoaiLenh.Visible = true;
            this.colLoaiLenh.VisibleIndex = 2;
            // 
            // colPhuongThuc
            // 
            this.colPhuongThuc.Caption = "Phương thức";
            this.colPhuongThuc.FieldName = "PhuongThuc";
            this.colPhuongThuc.Name = "colPhuongThuc";
            this.colPhuongThuc.Visible = true;
            this.colPhuongThuc.VisibleIndex = 3;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 4;
            // 
            // colMaCP
            // 
            this.colMaCP.Caption = "Mã cổ phiếu";
            this.colMaCP.FieldName = "MaCP";
            this.colMaCP.Name = "colMaCP";
            this.colMaCP.Visible = true;
            this.colMaCP.VisibleIndex = 5;
            // 
            // colGia
            // 
            this.colGia.Caption = "Giá";
            this.colGia.FieldName = "Gia";
            this.colGia.Name = "colGia";
            this.colGia.Visible = true;
            this.colGia.VisibleIndex = 6;
            // 
            // colMaTK
            // 
            this.colMaTK.Caption = "Mã tài khoản";
            this.colMaTK.FieldName = "MaTK";
            this.colMaTK.Name = "colMaTK";
            this.colMaTK.Visible = true;
            this.colMaTK.VisibleIndex = 7;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng thái";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 8;
            // 
            // frmGD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.gctGD);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGD";
            this.Text = "frmGD";
            this.Load += new System.EventHandler(this.frmGD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gctGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lENHDATBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnSK;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gctGD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QL_GDCPDataSet qL_GDCPDataSet;
        private System.Windows.Forms.BindingSource lENHDATBindingSource;
        private QL_GDCPDataSetTableAdapters.LENHDATTableAdapter lENHDATTableAdapter;
        private QL_GDCPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGD;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiLenh;
        private DevExpress.XtraGrid.Columns.GridColumn colPhuongThuc;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCP;
        private DevExpress.XtraGrid.Columns.GridColumn colGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMaTK;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
    }
}