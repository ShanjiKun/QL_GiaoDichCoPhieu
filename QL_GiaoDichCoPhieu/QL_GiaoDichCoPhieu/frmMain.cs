using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QL_GiaoDichCoPhieu
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // check form from mdi parent
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // ActiveForm
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void btnBalanceAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmBalanceAccount"))
            {
                frmBalanceAccount frmBalanceAccount = new frmBalanceAccount();
                frmBalanceAccount.MdiParent = this;
                frmBalanceAccount.Show();
            }
            else
                ActiveChildForm("frmBalanceAccount");
        }

        private void btnBalanceStock_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmBalanceStock"))
            {
                frmBalanceStock frmBalanceStock = new frmBalanceStock();
                frmBalanceStock.MdiParent = this;
                frmBalanceStock.Show();
            }
            else
                ActiveChildForm("frmBalanceStock");
        }

        private void btnGD_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmGD"))
            {
                frmGD frmGD = new frmGD();
                frmGD.MdiParent = this;
                frmGD.Show();
            }
            else
                ActiveChildForm("frmGD");
        }

        private void btnLK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmLK"))
            {
                frmLK frmLK = new frmLK();
                frmLK.MdiParent = this;
                frmLK.Show();
            }
            else
                ActiveChildForm("frmLK");
        }

        private void btnSell_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmSell"))
            {
                frmSell frmSell = new frmSell();
                frmSell.MdiParent = this;
                frmSell.Show();
            }
            else
                ActiveChildForm("frmSell");
        }

        private void btnBuy_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmBuys"))
            {
                frmBuys frmBuys = new frmBuys();
                frmBuys.MdiParent = this;
                frmBuys.Show();
            }
            else
                ActiveChildForm("frmBuys");
        }

        private void btnCreateAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmCreateAccount"))
            {
                frmCreateAccount frmCreateAccount = new frmCreateAccount();
                frmCreateAccount.MdiParent = this;
                frmCreateAccount.Show();
            }
            else
                ActiveChildForm("frmCreateAccount");
        }

        private void btnLogOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void tbnCreateNDT_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmCreateAccountNDT"))
            {
                frmCreateAccountNDT frmCreateAccountNDT = new frmCreateAccountNDT();
                frmCreateAccountNDT.MdiParent = this;
                frmCreateAccountNDT.Show();
            }
            else
                ActiveChildForm("frmCreateAccountNDT");
        }

        private void btnTKNDT_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!CheckExistForm("frmUpdateTKNDT"))
            {
                frmUpdateTKNDT frmUpdateTKNDT = new frmUpdateTKNDT();
                frmUpdateTKNDT.MdiParent = this;
                frmUpdateTKNDT.Show();
            }
            else
                ActiveChildForm("frmUpdateTKNDT");
        }

        private void btnSKDSLD_ItemClick(object sender, ItemClickEventArgs e)
        {
          
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if(Program.Name == "ADMIN")
            {
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                ribbonPage4.Visible = false;
                tbnCreateNDT.Enabled = false;
                btnTKNDT.Enabled = false;
            }else if(Program.Name == "NHANVIEN")
            {
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                ribbonPage4.Visible = false;
                btnChangePassword.Enabled = false;
                btnCreateAccount.Enabled = false;
            }else if(Program.Name == "NDT")
            {
                ribbonPage5.Visible = false;
            }

        }

        private void btnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }
    }
}