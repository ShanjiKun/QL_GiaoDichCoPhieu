using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_GiaoDichCoPhieu.Models;

namespace QL_GiaoDichCoPhieu
{
    public partial class frmBuys : Form
    {
        public frmBuys()
        {
            InitializeComponent();
        }

        private void onFormLoaded(object sender, EventArgs e)
        {
            //------
            loadTimeTitle();

            //------
            loadAccount();

            //-----
            loadStock();
        }

        //--Method
        void loadTimeTitle()
        {
            lbDateTime.Text = DateTime.Now.ToString();
        }
        void loadAccount()
        {
            List<BankAccount> listItem = DatabaseManager.sharedInstance().getListBankAccount();
            if (listItem.Count == 0)
            {
                MessageBox.Show("Can't get list Account!");
                return;
            }

            cbAccountID.DataSource = listItem;
            cbAccountID.DisplayMember = "accountID";
            cbAccountID.ValueMember = "accountID";
        }
        void loadStock()
        {
            List<ComboBoxItem> listItem = DatabaseManager.sharedInstance().getListStock();
            if (listItem.Count == 0)
            {
                MessageBox.Show("Can't get list Stock!");
                return;
            }

            cbStock.DataSource = listItem;
            cbStock.DisplayMember = "text";
            cbStock.DisplayMember = "value";
        }
        //----Action----
        private void oncbAccountIDChanged(object sender, EventArgs e)
        {
            if (!cbAccountID.SelectedValue.GetType().Equals(typeof(String))) return;

            String accountID = cbAccountID.SelectedValue.ToString();
            List<String> list = DatabaseManager.sharedInstance().getBankNameAndBalance(accountID);
            if (list.Count == 0)
            {
                MessageBox.Show("Can't get Name and Banlance!");
                return;
            }

            lbBankName.Text = list[0];
            lbBalance.Text = list[1] + " VND";
        }

        private void oncbStockChanged(object sender, EventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)cbStock.SelectedValue;
            String stockID = item.text;
            List<String> list = DatabaseManager.sharedInstance().getStockPrices(stockID);
            if (list.Count == 0)
            {
                MessageBox.Show("Can't get prices!");
                return;
            }

            lbPriceMax.Text = list[0];
            lbPriceMin.Text = list[1];
            lbPriceMiddle.Text = list[2];
        }
    }
}
