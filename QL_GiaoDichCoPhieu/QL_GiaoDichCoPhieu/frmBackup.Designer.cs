namespace QL_GiaoDichCoPhieu
{
    partial class frmBackup
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
            this.label3 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.sP_STTBACKUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_GDCPDataSet = new QL_GiaoDichCoPhieu.QL_GDCPDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSL = new System.Windows.Forms.Button();
            this.btnPH = new System.Windows.Forms.Button();
            this.sP_STTBACKUPTableAdapter = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.SP_STTBACKUPTableAdapter();
            this.tableAdapterManager = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_STTBACKUPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(118, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Sao Lưu - Phục Hồi Dữ Liệu";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.sP_STTBACKUPBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(49, 73);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(401, 185);
            this.gridControl1.TabIndex = 54;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sP_STTBACKUPBindingSource
            // 
            this.sP_STTBACKUPBindingSource.DataMember = "SP_STTBACKUP";
            this.sP_STTBACKUPBindingSource.DataSource = this.qL_GDCPDataSet;
            // 
            // qL_GDCPDataSet
            // 
            this.qL_GDCPDataSet.DataSetName = "QL_GDCPDataSet";
            this.qL_GDCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colbackup_start_date});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colposition
            // 
            this.colposition.FieldName = "position";
            this.colposition.Name = "colposition";
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 1;
            // 
            // btnSL
            // 
            this.btnSL.Location = new System.Drawing.Point(262, 275);
            this.btnSL.Name = "btnSL";
            this.btnSL.Size = new System.Drawing.Size(75, 23);
            this.btnSL.TabIndex = 55;
            this.btnSL.Text = "Sao lưu";
            this.btnSL.UseVisualStyleBackColor = true;
            this.btnSL.Click += new System.EventHandler(this.btnSL_Click);
            // 
            // btnPH
            // 
            this.btnPH.Location = new System.Drawing.Point(375, 275);
            this.btnPH.Name = "btnPH";
            this.btnPH.Size = new System.Drawing.Size(75, 23);
            this.btnPH.TabIndex = 56;
            this.btnPH.Text = "Phục hồi";
            this.btnPH.UseVisualStyleBackColor = true;
            // 
            // sP_STTBACKUPTableAdapter
            // 
            this.sP_STTBACKUPTableAdapter.ClearBeforeFill = true;
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
            // frmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 316);
            this.Controls.Add(this.btnPH);
            this.Controls.Add(this.btnSL);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label3);
            this.Name = "frmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBackup";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_STTBACKUPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnSL;
        private System.Windows.Forms.Button btnPH;
        private QL_GDCPDataSet qL_GDCPDataSet;
        private System.Windows.Forms.BindingSource sP_STTBACKUPBindingSource;
        private QL_GDCPDataSetTableAdapters.SP_STTBACKUPTableAdapter sP_STTBACKUPTableAdapter;
        private QL_GDCPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
    }
}