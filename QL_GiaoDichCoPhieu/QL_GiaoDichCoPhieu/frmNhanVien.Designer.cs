namespace QL_GiaoDichCoPhieu
{
    partial class frmNhanVien
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
            System.Windows.Forms.Label maNVLabel;
            System.Windows.Forms.Label hoTenLabel;
            System.Windows.Forms.Label ngaySinhLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label emailLabel;
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.qL_GDCPDataSet = new QL_GiaoDichCoPhieu.QL_GDCPDataSet();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHANVIENTableAdapter = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.NHANVIENTableAdapter();
            this.tableAdapterManager = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.TableAdapterManager();
            this.nHANVIENGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.maNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoTenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngaySinhDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.diaChiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.gioiTinhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtCpass = new System.Windows.Forms.TextBox();
            this.radAdmin = new System.Windows.Forms.RadioButton();
            this.radNV = new System.Windows.Forms.RadioButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            maNVLabel = new System.Windows.Forms.Label();
            hoTenLabel = new System.Windows.Forms.Label();
            ngaySinhLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gioiTinhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // maNVLabel
            // 
            maNVLabel.AutoSize = true;
            maNVLabel.Location = new System.Drawing.Point(321, 396);
            maNVLabel.Name = "maNVLabel";
            maNVLabel.Size = new System.Drawing.Size(72, 13);
            maNVLabel.TabIndex = 74;
            maNVLabel.Text = "Mã nhân viên";
            // 
            // hoTenLabel
            // 
            hoTenLabel.AutoSize = true;
            hoTenLabel.Location = new System.Drawing.Point(324, 422);
            hoTenLabel.Name = "hoTenLabel";
            hoTenLabel.Size = new System.Drawing.Size(54, 13);
            hoTenLabel.TabIndex = 76;
            hoTenLabel.Text = "Họ và tên";
            // 
            // ngaySinhLabel
            // 
            ngaySinhLabel.AutoSize = true;
            ngaySinhLabel.Location = new System.Drawing.Point(321, 448);
            ngaySinhLabel.Name = "ngaySinhLabel";
            ngaySinhLabel.Size = new System.Drawing.Size(54, 13);
            ngaySinhLabel.TabIndex = 78;
            ngaySinhLabel.Text = "Ngày sinh";
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(324, 476);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(40, 13);
            diaChiLabel.TabIndex = 80;
            diaChiLabel.Text = "Địa chỉ";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(89, 396);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(70, 13);
            phoneLabel.TabIndex = 82;
            phoneLabel.Text = "Số điện thoại";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(89, 422);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(39, 13);
            cMNDLabel.TabIndex = 84;
            cMNDLabel.Text = "CMND";
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(89, 448);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(47, 13);
            gioiTinhLabel.TabIndex = 86;
            gioiTinhLabel.Text = "Giới tính";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(89, 476);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(32, 13);
            emailLabel.TabIndex = 88;
            emailLabel.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Nhân Viên";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(27, 515);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(223, 515);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(127, 515);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 56;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // qL_GDCPDataSet
            // 
            this.qL_GDCPDataSet.DataSetName = "QL_GDCPDataSet";
            this.qL_GDCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.qL_GDCPDataSet;
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COPHIEUTableAdapter = null;
            this.tableAdapterManager.LENHDATTableAdapter = null;
            this.tableAdapterManager.LENHKHOPTableAdapter = null;
            this.tableAdapterManager.LICHSUGIATableAdapter = null;
            this.tableAdapterManager.NDTTableAdapter = null;
            this.tableAdapterManager.NGANHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = this.nHANVIENTableAdapter;
            this.tableAdapterManager.SOHUUTableAdapter = null;
            this.tableAdapterManager.TAIKHOAN_NGANHANGTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // nHANVIENGridControl
            // 
            this.nHANVIENGridControl.DataSource = this.nHANVIENBindingSource;
            this.nHANVIENGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nHANVIENGridControl.Location = new System.Drawing.Point(0, 0);
            this.nHANVIENGridControl.MainView = this.gridView1;
            this.nHANVIENGridControl.Name = "nHANVIENGridControl";
            this.nHANVIENGridControl.Size = new System.Drawing.Size(1300, 325);
            this.nHANVIENGridControl.TabIndex = 56;
            this.nHANVIENGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colHoTen,
            this.colNgaySinh,
            this.colDiaChi,
            this.colPhone,
            this.colCMND,
            this.colGioiTinh,
            this.colEmail});
            this.gridView1.GridControl = this.nHANVIENGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Tìm nhân viên...";
            this.gridView1.OptionsFind.ShowCloseButton = false;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã nhân viên";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 0;
            // 
            // colHoTen
            // 
            this.colHoTen.Caption = "Họ tên";
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 2;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 3;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Số điện thoại";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 5;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 6;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Thông tin nhân viên";
            // 
            // maNVTextEdit
            // 
            this.maNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "MaNV", true));
            this.maNVTextEdit.Location = new System.Drawing.Point(399, 393);
            this.maNVTextEdit.Name = "maNVTextEdit";
            this.maNVTextEdit.Size = new System.Drawing.Size(133, 20);
            this.maNVTextEdit.TabIndex = 75;
            // 
            // hoTenTextEdit
            // 
            this.hoTenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "HoTen", true));
            this.hoTenTextEdit.Location = new System.Drawing.Point(399, 419);
            this.hoTenTextEdit.Name = "hoTenTextEdit";
            this.hoTenTextEdit.Size = new System.Drawing.Size(133, 20);
            this.hoTenTextEdit.TabIndex = 77;
            // 
            // ngaySinhDateEdit
            // 
            this.ngaySinhDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "NgaySinh", true));
            this.ngaySinhDateEdit.EditValue = null;
            this.ngaySinhDateEdit.Location = new System.Drawing.Point(399, 445);
            this.ngaySinhDateEdit.Name = "ngaySinhDateEdit";
            this.ngaySinhDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhDateEdit.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.ngaySinhDateEdit.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.ngaySinhDateEdit.Size = new System.Drawing.Size(133, 20);
            this.ngaySinhDateEdit.TabIndex = 79;
            // 
            // diaChiTextEdit
            // 
            this.diaChiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "DiaChi", true));
            this.diaChiTextEdit.Location = new System.Drawing.Point(399, 471);
            this.diaChiTextEdit.Name = "diaChiTextEdit";
            this.diaChiTextEdit.Size = new System.Drawing.Size(133, 20);
            this.diaChiTextEdit.TabIndex = 81;
            // 
            // phoneTextEdit
            // 
            this.phoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "Phone", true));
            this.phoneTextEdit.Location = new System.Drawing.Point(172, 393);
            this.phoneTextEdit.Name = "phoneTextEdit";
            this.phoneTextEdit.Size = new System.Drawing.Size(123, 20);
            this.phoneTextEdit.TabIndex = 83;
            // 
            // cMNDTextEdit
            // 
            this.cMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "CMND", true));
            this.cMNDTextEdit.Location = new System.Drawing.Point(172, 419);
            this.cMNDTextEdit.Name = "cMNDTextEdit";
            this.cMNDTextEdit.Size = new System.Drawing.Size(123, 20);
            this.cMNDTextEdit.TabIndex = 85;
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "Email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(172, 471);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(123, 20);
            this.emailTextEdit.TabIndex = 89;
            // 
            // gioiTinhTextEdit
            // 
            this.gioiTinhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANVIENBindingSource, "GioiTinh", true));
            this.gioiTinhTextEdit.Location = new System.Drawing.Point(172, 445);
            this.gioiTinhTextEdit.Name = "gioiTinhTextEdit";
            this.gioiTinhTextEdit.Properties.AutoHeight = false;
            this.gioiTinhTextEdit.Size = new System.Drawing.Size(123, 20);
            this.gioiTinhTextEdit.TabIndex = 87;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 91;
            this.label4.Text = "Mật khẩu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(588, 448);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Xác nhận mk";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(588, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 93;
            this.label6.Text = "Quyền";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(681, 391);
            this.txtTK.MaxLength = 50;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(153, 20);
            this.txtTK.TabIndex = 94;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(681, 419);
            this.txtPass.MaxLength = 50;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(153, 20);
            this.txtPass.TabIndex = 95;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtCpass
            // 
            this.txtCpass.Location = new System.Drawing.Point(681, 445);
            this.txtCpass.MaxLength = 50;
            this.txtCpass.Name = "txtCpass";
            this.txtCpass.Size = new System.Drawing.Size(153, 20);
            this.txtCpass.TabIndex = 96;
            this.txtCpass.UseSystemPasswordChar = true;
            // 
            // radAdmin
            // 
            this.radAdmin.AutoSize = true;
            this.radAdmin.Location = new System.Drawing.Point(681, 474);
            this.radAdmin.Name = "radAdmin";
            this.radAdmin.Size = new System.Drawing.Size(54, 17);
            this.radAdmin.TabIndex = 98;
            this.radAdmin.Text = "Admin";
            this.radAdmin.UseVisualStyleBackColor = true;
            // 
            // radNV
            // 
            this.radNV.AutoSize = true;
            this.radNV.Checked = true;
            this.radNV.Location = new System.Drawing.Point(760, 474);
            this.radNV.Name = "radNV";
            this.radNV.Size = new System.Drawing.Size(74, 17);
            this.radNV.TabIndex = 99;
            this.radNV.TabStop = true;
            this.radNV.Text = "Nhân viên";
            this.radNV.UseVisualStyleBackColor = true;
            this.radNV.CheckedChanged += new System.EventHandler(this.radNV_CheckedChanged);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(27, 363);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(855, 23);
            this.separatorControl1.TabIndex = 100;
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(760, 515);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 101;
            this.btnFinish.Text = "Xác nhận";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(660, 515);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 102;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 550);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.radNV);
            this.Controls.Add(this.radAdmin);
            this.Controls.Add(this.txtCpass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(maNVLabel);
            this.Controls.Add(this.maNVTextEdit);
            this.Controls.Add(hoTenLabel);
            this.Controls.Add(this.hoTenTextEdit);
            this.Controls.Add(ngaySinhLabel);
            this.Controls.Add(this.ngaySinhDateEdit);
            this.Controls.Add(diaChiLabel);
            this.Controls.Add(this.diaChiTextEdit);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextEdit);
            this.Controls.Add(cMNDLabel);
            this.Controls.Add(this.cMNDTextEdit);
            this.Controls.Add(gioiTinhLabel);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nHANVIENGridControl);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gioiTinhTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaChiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gioiTinhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private QL_GDCPDataSet qL_GDCPDataSet;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private QL_GDCPDataSetTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private QL_GDCPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nHANVIENGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraEditors.TextEdit maNVTextEdit;
        private DevExpress.XtraEditors.TextEdit hoTenTextEdit;
        private DevExpress.XtraEditors.DateEdit ngaySinhDateEdit;
        private DevExpress.XtraEditors.TextEdit diaChiTextEdit;
        private DevExpress.XtraEditors.TextEdit phoneTextEdit;
        private DevExpress.XtraEditors.TextEdit cMNDTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.TextEdit gioiTinhTextEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtCpass;
        private System.Windows.Forms.RadioButton radAdmin;
        private System.Windows.Forms.RadioButton radNV;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnHuy;
    }
}