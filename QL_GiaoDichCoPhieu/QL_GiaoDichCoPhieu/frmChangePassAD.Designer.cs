namespace QL_GiaoDichCoPhieu
{
    partial class frmChangePassAD
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
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCfLogin = new System.Windows.Forms.TextBox();
            this.txtNewLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(36, 78);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(327, 23);
            this.separatorControl1.TabIndex = 78;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(273, 196);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 77;
            this.btnCreate.Text = "Xác nhận";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 24);
            this.label1.TabIndex = 76;
            this.label1.Text = "Cập Nhật Mật Khẩu Nhân Viên";
            // 
            // txtCfLogin
            // 
            this.txtCfLogin.Location = new System.Drawing.Point(138, 153);
            this.txtCfLogin.Name = "txtCfLogin";
            this.txtCfLogin.Size = new System.Drawing.Size(210, 20);
            this.txtCfLogin.TabIndex = 82;
            this.txtCfLogin.UseSystemPasswordChar = true;
            // 
            // txtNewLogin
            // 
            this.txtNewLogin.Location = new System.Drawing.Point(138, 111);
            this.txtNewLogin.Name = "txtNewLogin";
            this.txtNewLogin.Size = new System.Drawing.Size(210, 20);
            this.txtNewLogin.TabIndex = 81;
            this.txtNewLogin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Xác nhận MK";
            // 
            // frmChangePassAD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 245);
            this.Controls.Add(this.txtCfLogin);
            this.Controls.Add(this.txtNewLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Name = "frmChangePassAD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCfLogin;
        private System.Windows.Forms.TextBox txtNewLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}