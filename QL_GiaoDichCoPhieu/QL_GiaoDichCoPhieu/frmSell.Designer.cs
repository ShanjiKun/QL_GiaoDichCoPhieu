﻿namespace QL_GiaoDichCoPhieu
{
    partial class frmSell
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lbStockBalance = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudSellPrice = new System.Windows.Forms.NumericUpDown();
            this.nudSellCount = new System.Windows.Forms.NumericUpDown();
            this.btnSell = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbStock = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPasswordTransaction = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbPriceMax = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbPriceMiddle = new System.Windows.Forms.Label();
            this.lbPriceMin = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cbAccountID = new System.Windows.Forms.ComboBox();
            this.lbBankName = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lbStockBalance);
            this.panelControl2.Controls.Add(this.label11);
            this.panelControl2.Controls.Add(this.nudSellPrice);
            this.panelControl2.Controls.Add(this.nudSellCount);
            this.panelControl2.Controls.Add(this.btnSell);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.label23);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Controls.Add(this.label22);
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Controls.Add(this.cbStock);
            this.panelControl2.Controls.Add(this.label9);
            this.panelControl2.Controls.Add(this.lbTotalPrice);
            this.panelControl2.Controls.Add(this.label10);
            this.panelControl2.Controls.Add(this.label20);
            this.panelControl2.Controls.Add(this.label12);
            this.panelControl2.Controls.Add(this.tbPasswordTransaction);
            this.panelControl2.Controls.Add(this.label13);
            this.panelControl2.Controls.Add(this.lbPriceMax);
            this.panelControl2.Controls.Add(this.label16);
            this.panelControl2.Controls.Add(this.lbPriceMiddle);
            this.panelControl2.Controls.Add(this.lbPriceMin);
            this.panelControl2.Controls.Add(this.label18);
            this.panelControl2.Location = new System.Drawing.Point(12, 180);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(524, 309);
            this.panelControl2.TabIndex = 40;
            // 
            // lbStockBalance
            // 
            this.lbStockBalance.AutoSize = true;
            this.lbStockBalance.Location = new System.Drawing.Point(219, 72);
            this.lbStockBalance.Name = "lbStockBalance";
            this.lbStockBalance.Size = new System.Drawing.Size(49, 13);
            this.lbStockBalance.TabIndex = 39;
            this.lbStockBalance.Text = "1000000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Số dư cổ phiếu:";
            // 
            // nudSellPrice
            // 
            this.nudSellPrice.DecimalPlaces = 1;
            this.nudSellPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudSellPrice.Location = new System.Drawing.Point(222, 154);
            this.nudSellPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSellPrice.Name = "nudSellPrice";
            this.nudSellPrice.Size = new System.Drawing.Size(120, 21);
            this.nudSellPrice.TabIndex = 37;
            this.nudSellPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSellPrice.ValueChanged += new System.EventHandler(this.onSellPriceChanged);
            // 
            // nudSellCount
            // 
            this.nudSellCount.Location = new System.Drawing.Point(222, 127);
            this.nudSellCount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudSellCount.Name = "nudSellCount";
            this.nudSellCount.Size = new System.Drawing.Size(120, 21);
            this.nudSellCount.TabIndex = 36;
            this.nudSellCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSellCount.ValueChanged += new System.EventHandler(this.onSellBalanceChanged);
            // 
            // btnSell
            // 
            this.btnSell.Enabled = false;
            this.btnSell.Location = new System.Drawing.Point(222, 248);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(119, 33);
            this.btnSell.TabIndex = 35;
            this.btnSell.Text = "Đặt lệnh";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.onSellTapped);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Chứng khoán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Loại lệnh:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(220, 99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "Khớp lệnh liên tục";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Giá:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(373, 13);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 13);
            this.label22.TabIndex = 30;
            this.label22.Text = "nghìn VND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Số lượng:";
            // 
            // cbStock
            // 
            this.cbStock.FormattingEnabled = true;
            this.cbStock.Location = new System.Drawing.Point(222, 10);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(84, 21);
            this.cbStock.TabIndex = 29;
            this.cbStock.SelectedIndexChanged += new System.EventHandler(this.oncbStockChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tổng tiền mua:";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(306, 214);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(36, 13);
            this.lbTotalPrice.TabIndex = 28;
            this.lbTotalPrice.Text = "0 VND";
            this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Mật khẩu đặt lệnh:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(348, 156);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "nghìn VND/Cổ phiếu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Đơn vị:";
            // 
            // tbPasswordTransaction
            // 
            this.tbPasswordTransaction.Location = new System.Drawing.Point(223, 180);
            this.tbPasswordTransaction.Name = "tbPasswordTransaction";
            this.tbPasswordTransaction.PasswordChar = '*';
            this.tbPasswordTransaction.Size = new System.Drawing.Size(120, 21);
            this.tbPasswordTransaction.TabIndex = 26;
            this.tbPasswordTransaction.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPasswordTransaction.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(220, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Giá trần:";
            // 
            // lbPriceMax
            // 
            this.lbPriceMax.AutoSize = true;
            this.lbPriceMax.Location = new System.Drawing.Point(273, 42);
            this.lbPriceMax.Name = "lbPriceMax";
            this.lbPriceMax.Size = new System.Drawing.Size(13, 13);
            this.lbPriceMax.TabIndex = 17;
            this.lbPriceMax.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(326, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "Giá sàn:";
            // 
            // lbPriceMiddle
            // 
            this.lbPriceMiddle.AutoSize = true;
            this.lbPriceMiddle.Location = new System.Drawing.Point(487, 42);
            this.lbPriceMiddle.Name = "lbPriceMiddle";
            this.lbPriceMiddle.Size = new System.Drawing.Size(13, 13);
            this.lbPriceMiddle.TabIndex = 21;
            this.lbPriceMiddle.Text = "0";
            // 
            // lbPriceMin
            // 
            this.lbPriceMin.AutoSize = true;
            this.lbPriceMin.Location = new System.Drawing.Point(379, 42);
            this.lbPriceMin.Name = "lbPriceMin";
            this.lbPriceMin.Size = new System.Drawing.Size(13, 13);
            this.lbPriceMin.TabIndex = 19;
            this.lbPriceMin.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(434, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "Giá TC:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbAccountID);
            this.panelControl1.Controls.Add(this.lbBankName);
            this.panelControl1.Controls.Add(this.label19);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.lbBalance);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Location = new System.Drawing.Point(12, 85);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(524, 89);
            this.panelControl1.TabIndex = 39;
            // 
            // cbAccountID
            // 
            this.cbAccountID.FormattingEnabled = true;
            this.cbAccountID.Location = new System.Drawing.Point(223, 8);
            this.cbAccountID.Name = "cbAccountID";
            this.cbAccountID.Size = new System.Drawing.Size(121, 21);
            this.cbAccountID.TabIndex = 35;
            this.cbAccountID.SelectedValueChanged += new System.EventHandler(this.oncbAccountIDChanged);
            // 
            // lbBankName
            // 
            this.lbBankName.AutoSize = true;
            this.lbBankName.Location = new System.Drawing.Point(219, 38);
            this.lbBankName.Name = "lbBankName";
            this.lbBankName.Size = new System.Drawing.Size(56, 13);
            this.lbBankName.TabIndex = 34;
            this.lbBankName.Text = "Vietinbank";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "Tên ngân hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số dư:";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(219, 65);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(86, 13);
            this.lbBalance.TabIndex = 12;
            this.lbBalance.Text = "10,000,000 VND";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tài khoản tiền:";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(27, 61);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(494, 18);
            this.separatorControl1.TabIndex = 38;
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.Location = new System.Drawing.Point(127, 45);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(47, 13);
            this.lbDateTime.TabIndex = 37;
            this.lbDateTime.Text = "datetime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Đặt lệnh cho ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "ĐẶT LỆNH MUA";
            // 
            // frmSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 502);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSell";
            this.Text = "frmSell";
            this.Load += new System.EventHandler(this.onFormLoaded);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSellCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.NumericUpDown nudSellPrice;
        private System.Windows.Forms.NumericUpDown nudSellCount;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbStock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPasswordTransaction;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbPriceMax;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbPriceMiddle;
        private System.Windows.Forms.Label lbPriceMin;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cbAccountID;
        private System.Windows.Forms.Label lbBankName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbStockBalance;
        private System.Windows.Forms.Label label11;
    }
}