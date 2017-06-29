namespace QL_GiaoDichCoPhieu
{
    partial class frmMain
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnBalanceAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnBalanceStock = new DevExpress.XtraBars.BarButtonItem();
            this.btnGD = new DevExpress.XtraBars.BarButtonItem();
            this.btnLK = new DevExpress.XtraBars.BarButtonItem();
            this.bt = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBuy = new DevExpress.XtraBars.BarButtonItem();
            this.btnSell = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.tbnCreateNDT = new DevExpress.XtraBars.BarButtonItem();
            this.btnTKNDT = new DevExpress.XtraBars.BarButtonItem();
            this.btnSKDSLD = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnLogOut,
            this.btnBalanceAccount,
            this.btnBalanceStock,
            this.btnGD,
            this.btnLK,
            this.bt,
            this.barButtonItem3,
            this.btnBuy,
            this.btnSell,
            this.btnCreateAccount,
            this.btnChangePassword,
            this.tbnCreateNDT,
            this.btnTKNDT,
            this.btnSKDSLD,
            this.btnBackup,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbon.Size = new System.Drawing.Size(630, 146);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Đăng xuất";
            this.btnLogOut.Id = 1;
            this.btnLogOut.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_door_opened;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogOut_ItemClick);
            // 
            // btnBalanceAccount
            // 
            this.btnBalanceAccount.Caption = "Tra cứu số dư";
            this.btnBalanceAccount.Glyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_bank_card_back_side;
            this.btnBalanceAccount.Id = 2;
            this.btnBalanceAccount.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_bank_card_back_side;
            this.btnBalanceAccount.Name = "btnBalanceAccount";
            this.btnBalanceAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBalanceAccount_ItemClick);
            // 
            // btnBalanceStock
            // 
            this.btnBalanceStock.Caption = "Số dư cổ phiếu";
            this.btnBalanceStock.Id = 3;
            this.btnBalanceStock.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_money;
            this.btnBalanceStock.Name = "btnBalanceStock";
            // 
            // btnGD
            // 
            this.btnGD.Caption = "Giao dịch";
            this.btnGD.Id = 4;
            this.btnGD.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_2f_swipe_down;
            this.btnGD.Name = "btnGD";
            this.btnGD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGD_ItemClick);
            // 
            // btnLK
            // 
            this.btnLK.Caption = "Lệnh khớp";
            this.btnLK.Id = 5;
            this.btnLK.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_chevron_down_round;
            this.btnLK.Name = "btnLK";
            this.btnLK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLK_ItemClick);
            // 
            // bt
            // 
            this.bt.Caption = "Lệnh mua";
            this.bt.Id = 6;
            this.bt.Name = "bt";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Lệnh bán";
            this.barButtonItem3.Id = 7;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // btnBuy
            // 
            this.btnBuy.Caption = "Lệnh mua";
            this.btnBuy.Id = 8;
            this.btnBuy.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_buy;
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBuy_ItemClick);
            // 
            // btnSell
            // 
            this.btnSell.Caption = "Lệnh bán";
            this.btnSell.Id = 9;
            this.btnSell.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_sell;
            this.btnSell.Name = "btnSell";
            this.btnSell.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSell_ItemClick);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Caption = "Tạo tài khoản";
            this.btnCreateAccount.Id = 10;
            this.btnCreateAccount.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_add_user;
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateAccount_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Đổi mật khẩu";
            this.btnChangePassword.Id = 11;
            this.btnChangePassword.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_key_2;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // tbnCreateNDT
            // 
            this.tbnCreateNDT.Caption = "Tài khoản NDT";
            this.tbnCreateNDT.Id = 12;
            this.tbnCreateNDT.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_businessman;
            this.tbnCreateNDT.Name = "tbnCreateNDT";
            this.tbnCreateNDT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbnCreateNDT_ItemClick);
            // 
            // btnTKNDT
            // 
            this.btnTKNDT.Caption = "Cập nhật tài khoản NDT";
            this.btnTKNDT.Id = 13;
            this.btnTKNDT.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_bank_cards;
            this.btnTKNDT.Name = "btnTKNDT";
            this.btnTKNDT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTKNDT_ItemClick);
            // 
            // btnSKDSLD
            // 
            this.btnSKDSLD.Caption = "Danh sách lệnh đặt";
            this.btnSKDSLD.Id = 14;
            this.btnSKDSLD.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_print;
            this.btnSKDSLD.Name = "btnSKDSLD";
            this.btnSKDSLD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSKDSLD_ItemClick);
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Backup";
            this.btnBackup.Id = 15;
            this.btnBackup.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_data_backup;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBackup_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Restore";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.LargeGlyph = global::QL_GiaoDichCoPhieu.Properties.Resources.icons8_restore_page_filled;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.onRestoreTapped);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogOut);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBackup);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Tra cứu số dư";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnBalanceAccount);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Sao kê";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnGD);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLK);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Đặt lệnh";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnBuy);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnSell);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Tài khoản";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnCreateAccount);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup8.ItemLinks.Add(this.tbnCreateNDT);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnTKNDT);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 628);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(630, 21);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 649);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Cổ phiếu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarButtonItem btnBalanceAccount;
        private DevExpress.XtraBars.BarButtonItem btnBalanceStock;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnGD;
        private DevExpress.XtraBars.BarButtonItem btnLK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem bt;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnBuy;
        private DevExpress.XtraBars.BarButtonItem btnSell;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnCreateAccount;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem tbnCreateNDT;
        private DevExpress.XtraBars.BarButtonItem btnTKNDT;
        private DevExpress.XtraBars.BarButtonItem btnSKDSLD;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}