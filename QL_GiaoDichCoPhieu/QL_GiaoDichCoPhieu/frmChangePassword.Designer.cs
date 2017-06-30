namespace QL_GiaoDichCoPhieu
{
    partial class frmChangePassword
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
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtCfLogin = new System.Windows.Forms.TextBox();
            this.txtNewLogin = new System.Windows.Forms.TextBox();
            this.txtOldLogin = new System.Windows.Forms.TextBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txtCf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOld = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(404, 230);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 67;
            this.btnCreate.Text = "Xác nhận";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(95, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 24);
            this.label1.TabIndex = 51;
            this.label1.Text = "Cập Nhật Mật Khẩu Nhà Đầu Tư";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(32, 70);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(447, 23);
            this.separatorControl1.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Xác nhận MK";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtCfLogin);
            this.panelControl1.Controls.Add(this.txtNewLogin);
            this.panelControl1.Controls.Add(this.txtOldLogin);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.label4);
            this.panelControl1.Location = new System.Drawing.Point(32, 119);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(213, 100);
            this.panelControl1.TabIndex = 75;
            // 
            // txtCfLogin
            // 
            this.txtCfLogin.Location = new System.Drawing.Point(76, 69);
            this.txtCfLogin.Name = "txtCfLogin";
            this.txtCfLogin.Size = new System.Drawing.Size(128, 21);
            this.txtCfLogin.TabIndex = 74;
            this.txtCfLogin.UseSystemPasswordChar = true;
            // 
            // txtNewLogin
            // 
            this.txtNewLogin.Location = new System.Drawing.Point(76, 40);
            this.txtNewLogin.Name = "txtNewLogin";
            this.txtNewLogin.Size = new System.Drawing.Size(128, 21);
            this.txtNewLogin.TabIndex = 73;
            this.txtNewLogin.UseSystemPasswordChar = true;
            // 
            // txtOldLogin
            // 
            this.txtOldLogin.Location = new System.Drawing.Point(76, 9);
            this.txtOldLogin.Name = "txtOldLogin";
            this.txtOldLogin.Size = new System.Drawing.Size(128, 21);
            this.txtOldLogin.TabIndex = 72;
            this.txtOldLogin.UseSystemPasswordChar = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txtCf);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.txtNew);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.txtOld);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Location = new System.Drawing.Point(262, 119);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(217, 100);
            this.panelControl2.TabIndex = 76;
            // 
            // txtCf
            // 
            this.txtCf.Location = new System.Drawing.Point(76, 69);
            this.txtCf.Name = "txtCf";
            this.txtCf.Size = new System.Drawing.Size(128, 21);
            this.txtCf.TabIndex = 77;
            this.txtCf.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Mật khẩu cũ";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(76, 40);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(128, 21);
            this.txtNew.TabIndex = 76;
            this.txtNew.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Mật khẩu mới";
            // 
            // txtOld
            // 
            this.txtOld.Location = new System.Drawing.Point(76, 9);
            this.txtOld.Name = "txtOld";
            this.txtOld.Size = new System.Drawing.Size(128, 21);
            this.txtOld.TabIndex = 75;
            this.txtOld.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Xác nhận MK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Đăng nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Giao dịch";
            // 
            // frmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 265);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Name = "frmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChangePassword";
            this.Load += new System.EventHandler(this.frmChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox txtCfLogin;
        private System.Windows.Forms.TextBox txtNewLogin;
        private System.Windows.Forms.TextBox txtOldLogin;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txtCf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOld;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}