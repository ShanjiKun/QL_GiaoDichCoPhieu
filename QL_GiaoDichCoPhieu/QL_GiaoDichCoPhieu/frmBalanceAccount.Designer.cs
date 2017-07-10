namespace QL_GiaoDichCoPhieu
{
    partial class frmBalanceAccount
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lblBalanceAccount = new System.Windows.Forms.Label();
            this.lblIdBank = new System.Windows.Forms.Label();
            this.lblAllowBalance = new System.Windows.Forms.Label();
            this.lblNameBank = new System.Windows.Forms.Label();
            this.lblNameAccount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sP_SDCPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_GDCPDataSet = new QL_GiaoDichCoPhieu.QL_GDCPDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenCty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongGiaTri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_SDCPTableAdapter = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.SP_SDCPTableAdapter();
            this.tableAdapterManager = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SDCPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1016, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tài khoản";
            // 
            // cmbAccount
            // 
            this.cmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(1110, 12);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(150, 21);
            this.cmbAccount.TabIndex = 11;
            this.cmbAccount.SelectedIndexChanged += new System.EventHandler(this.cmbAccount_SelectedIndexChanged);
            this.cmbAccount.SelectedValueChanged += new System.EventHandler(this.cmbAccount_SelectedValueChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lblBalanceAccount);
            this.panelControl1.Controls.Add(this.lblIdBank);
            this.panelControl1.Controls.Add(this.cmbAccount);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Controls.Add(this.lblAllowBalance);
            this.panelControl1.Controls.Add(this.lblNameBank);
            this.panelControl1.Controls.Add(this.lblNameAccount);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1300, 120);
            this.panelControl1.TabIndex = 13;
            // 
            // lblBalanceAccount
            // 
            this.lblBalanceAccount.AutoSize = true;
            this.lblBalanceAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblBalanceAccount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAccount.ForeColor = System.Drawing.Color.Blue;
            this.lblBalanceAccount.Location = new System.Drawing.Point(171, 48);
            this.lblBalanceAccount.Name = "lblBalanceAccount";
            this.lblBalanceAccount.Size = new System.Drawing.Size(128, 19);
            this.lblBalanceAccount.TabIndex = 19;
            this.lblBalanceAccount.Text = "10,000,000 VND";
            // 
            // lblIdBank
            // 
            this.lblIdBank.AutoSize = true;
            this.lblIdBank.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdBank.Location = new System.Drawing.Point(171, 80);
            this.lblIdBank.Name = "lblIdBank";
            this.lblIdBank.Size = new System.Drawing.Size(58, 19);
            this.lblIdBank.TabIndex = 18;
            this.lblIdBank.Text = "TKMK1";
            // 
            // lblAllowBalance
            // 
            this.lblAllowBalance.AutoSize = true;
            this.lblAllowBalance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowBalance.ForeColor = System.Drawing.Color.Red;
            this.lblAllowBalance.Location = new System.Drawing.Point(583, 12);
            this.lblAllowBalance.Name = "lblAllowBalance";
            this.lblAllowBalance.Size = new System.Drawing.Size(119, 19);
            this.lblAllowBalance.TabIndex = 17;
            this.lblAllowBalance.Text = "5,000,000 VND";
            // 
            // lblNameBank
            // 
            this.lblNameBank.AutoSize = true;
            this.lblNameBank.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameBank.Location = new System.Drawing.Point(583, 44);
            this.lblNameBank.Name = "lblNameBank";
            this.lblNameBank.Size = new System.Drawing.Size(90, 19);
            this.lblNameBank.TabIndex = 16;
            this.lblNameBank.Text = "Sacombank";
            // 
            // lblNameAccount
            // 
            this.lblNameAccount.AutoSize = true;
            this.lblNameAccount.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAccount.Location = new System.Drawing.Point(171, 16);
            this.lblNameAccount.Name = "lblNameAccount";
            this.lblNameAccount.Size = new System.Drawing.Size(117, 19);
            this.lblNameAccount.TabIndex = 15;
            this.lblNameAccount.Text = "Vũ Trọng Tuấn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Số dư được phép giao dịch:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Số dư hiện tại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên chủ TK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã số tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(371, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngân hàng:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnPrint);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 501);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1300, 49);
            this.panelControl2.TabIndex = 14;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 14);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Sao kê cổ phiếu";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sP_SDCPBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 120);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1300, 381);
            this.gridControl1.TabIndex = 15;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_SDCPBindingSource
            // 
            this.sP_SDCPBindingSource.DataMember = "SP_SDCP";
            this.sP_SDCPBindingSource.DataSource = this.qL_GDCPDataSet;
            // 
            // qL_GDCPDataSet
            // 
            this.qL_GDCPDataSet.DataSetName = "QL_GDCPDataSet";
            this.qL_GDCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCP,
            this.colSoLuong,
            this.colTenCty,
            this.colGiaTC,
            this.colTongGiaTri});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Tìm thông tin...";
            // 
            // colMaCP
            // 
            this.colMaCP.Caption = "Mã cổ phiếu";
            this.colMaCP.FieldName = "MaCP";
            this.colMaCP.Name = "colMaCP";
            this.colMaCP.Visible = true;
            this.colMaCP.VisibleIndex = 0;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 1;
            // 
            // colTenCty
            // 
            this.colTenCty.Caption = "Tên công ty";
            this.colTenCty.FieldName = "TenCty";
            this.colTenCty.Name = "colTenCty";
            this.colTenCty.Visible = true;
            this.colTenCty.VisibleIndex = 2;
            // 
            // colGiaTC
            // 
            this.colGiaTC.Caption = "Giá tham chiếu";
            this.colGiaTC.FieldName = "GiaTC";
            this.colGiaTC.Name = "colGiaTC";
            this.colGiaTC.Visible = true;
            this.colGiaTC.VisibleIndex = 3;
            // 
            // colTongGiaTri
            // 
            this.colTongGiaTri.Caption = "Tổng giá trị";
            this.colTongGiaTri.FieldName = "TongGiaTri";
            this.colTongGiaTri.Name = "colTongGiaTri";
            this.colTongGiaTri.Visible = true;
            this.colTongGiaTri.VisibleIndex = 4;
            // 
            // sP_SDCPTableAdapter
            // 
            this.sP_SDCPTableAdapter.ClearBeforeFill = true;
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
            // frmBalanceAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBalanceAccount";
            this.Text = "frmBalanceAccount";
            this.Load += new System.EventHandler(this.frmBalanceAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_SDCPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAccount;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lblBalanceAccount;
        private System.Windows.Forms.Label lblIdBank;
        private System.Windows.Forms.Label lblAllowBalance;
        private System.Windows.Forms.Label lblNameBank;
        private System.Windows.Forms.Label lblNameAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnPrint;
        private QL_GDCPDataSet qL_GDCPDataSet;
        private System.Windows.Forms.BindingSource sP_SDCPBindingSource;
        private QL_GDCPDataSetTableAdapters.SP_SDCPTableAdapter sP_SDCPTableAdapter;
        private QL_GDCPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCP;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenCty;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaTC;
        private DevExpress.XtraGrid.Columns.GridColumn colTongGiaTri;
    }
}