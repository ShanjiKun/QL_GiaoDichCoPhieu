namespace QL_GiaoDichCoPhieu
{
    partial class frmUpdateTKNDT
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.nGANHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_GDCPDataSet = new QL_GiaoDichCoPhieu.QL_GDCPDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.nGANHANGTableAdapter = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.NGANHANGTableAdapter();
            this.cmbMaNDT = new System.Windows.Forms.ComboBox();
            this.nDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nDTTableAdapter = new QL_GiaoDichCoPhieu.QL_GDCPDataSetTableAdapters.NDTTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã NDT";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Location = new System.Drawing.Point(106, 162);
            this.txtMaTK.MaxLength = 20;
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(147, 20);
            this.txtMaTK.TabIndex = 33;
            this.txtMaTK.TextChanged += new System.EventHandler(this.txtMaTK_TextChanged);
            this.txtMaTK.Leave += new System.EventHandler(this.txtMaTK_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Mã tài khoản";
            // 
            // cmbBank
            // 
            this.cmbBank.DataSource = this.nGANHANGBindingSource;
            this.cmbBank.DisplayMember = "TenNH";
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(106, 201);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(147, 21);
            this.cmbBank.TabIndex = 35;
            this.cmbBank.ValueMember = "MaNH";
            // 
            // nGANHANGBindingSource
            // 
            this.nGANHANGBindingSource.DataMember = "NGANHANG";
            this.nGANHANGBindingSource.DataSource = this.qL_GDCPDataSet;
            // 
            // qL_GDCPDataSet
            // 
            this.qL_GDCPDataSet.DataSetName = "QL_GDCPDataSet";
            this.qL_GDCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Ngân hàng";
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(106, 242);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(147, 20);
            this.txtMoney.TabIndex = 37;
            this.txtMoney.TextChanged += new System.EventHandler(this.txtMoney_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "Số tiền";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(375, 238);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 42;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(375, 201);
            this.txtPhone.MaxLength = 15;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(147, 20);
            this.txtPhone.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Số điện thoại";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(375, 125);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(147, 20);
            this.txtName.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Họ tên";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(375, 162);
            this.txtID.MaxLength = 10;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(147, 20);
            this.txtID.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "CMND";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(447, 284);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 49;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // nGANHANGTableAdapter
            // 
            this.nGANHANGTableAdapter.ClearBeforeFill = true;
            // 
            // cmbMaNDT
            // 
            this.cmbMaNDT.DataSource = this.nDTBindingSource;
            this.cmbMaNDT.DisplayMember = "MaNDT";
            this.cmbMaNDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNDT.FormattingEnabled = true;
            this.cmbMaNDT.Location = new System.Drawing.Point(106, 122);
            this.cmbMaNDT.Name = "cmbMaNDT";
            this.cmbMaNDT.Size = new System.Drawing.Size(147, 21);
            this.cmbMaNDT.TabIndex = 50;
            this.cmbMaNDT.ValueMember = "MaNDT";
            this.cmbMaNDT.SelectedIndexChanged += new System.EventHandler(this.cmbMaNDT_SelectedIndexChanged);
            // 
            // nDTBindingSource
            // 
            this.nDTBindingSource.DataMember = "NDT";
            this.nDTBindingSource.DataSource = this.qL_GDCPDataSet;
            // 
            // nDTTableAdapter
            // 
            this.nDTTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(137, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Cập Nhật Tài Khoản Nhà Đầu Tư";
            // 
            // frmUpdateTKNDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMaNDT);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbBank);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMaTK);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmUpdateTKNDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateTKNDT";
            this.Load += new System.EventHandler(this.frmUpdateTKNDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nGANHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_GDCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private QL_GDCPDataSet qL_GDCPDataSet;
        private System.Windows.Forms.BindingSource nGANHANGBindingSource;
        private QL_GDCPDataSetTableAdapters.NGANHANGTableAdapter nGANHANGTableAdapter;
        private System.Windows.Forms.ComboBox cmbMaNDT;
        private System.Windows.Forms.BindingSource nDTBindingSource;
        private QL_GDCPDataSetTableAdapters.NDTTableAdapter nDTTableAdapter;
        private System.Windows.Forms.Label label3;
    }
}