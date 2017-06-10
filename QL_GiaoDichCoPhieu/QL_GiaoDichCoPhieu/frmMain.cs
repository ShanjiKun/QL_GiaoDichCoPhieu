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
    }
}