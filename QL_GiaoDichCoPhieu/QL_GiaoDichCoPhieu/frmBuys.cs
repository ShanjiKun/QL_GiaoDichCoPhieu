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
        double availableBalance = 0;
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
            cbAccountID.ValueMember = "accountBalance";
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
        void updateTotalPrice()
        {
            int stockBanlance = Int32.Parse(tbStockBalance.Text);
            int buyPrice = Int32.Parse(tbBuyPrice.Text);
            int totalPrice = stockBanlance * buyPrice;
            lbTotalPrice.Text = totalPrice.ToString();
        }
        bool valideate()
        {
            //---BankAcount---
            if (cbAccountID.Text.Length == 0)
            {
                MessageBox.Show("Bank Account empty!");
                return false;
            }

            List<BankAccount> listBA = (List<BankAccount>)cbAccountID.DataSource;
            int i = 0;
            while (i < listBA.Count)
            {
                if (listBA[i].accountID == cbAccountID.Text) break;
                i++;
            }
            if (i == listBA.Count)
            {
                MessageBox.Show("Bank Account invalid!");
                return false;
            }
            //---Stock ID----
            if (cbStock.Text.Length == 0)
            {
                MessageBox.Show("Stock ID empty!");
                return false;
            }
            List<ComboBoxItem> listCB = (List<ComboBoxItem>)cbStock.DataSource;
            i = 0;
            while (i < listCB.Count)
            {
                if (listCB[i].value == cbAccountID.Text) break;
                i++;
            }
            if (i == listCB.Count)
            {
                MessageBox.Show("Stock ID invalid!");
                return false;
            }
            //---Stock Balance---
            if (tbStockBalance.Text.Length == 0)
            {
                MessageBox.Show("Stock Balance empty!");
                return false;
            }
            if (double.Parse(tbStockBalance.Text) > 10000000)
            {
                MessageBox.Show("Maximum of Stock balance is 10,000,000!");
                return false;
            }
            //---Buy Price----
            if (tbBuyPrice.Text.Length == 0)
            {
                MessageBox.Show("Buy price empty!");
                return false;
            }
            if (double.Parse(tbBuyPrice.Text) > 10000000)
            {
                MessageBox.Show("Maximum of Stock balance is 10,000,000!");
                return false;
            }
            //--
            if (tbPasswordTransaction.Text.Length == 0)
            {
                MessageBox.Show("Password empty!");
                return false;
            }

            return true;
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
            availableBalance = double.Parse(list[1]);
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

        private void onLbStockBalanceChanged(object sender, EventArgs e)
        {
            if (tbStockBalance.Text.Length == 0 || tbBuyPrice.Text.Length == 0) return;
            updateTotalPrice();
        }

        private void onLbBuyPriceChanged(object sender, EventArgs e)
        {
            if (tbStockBalance.Text.Length == 0 || tbBuyPrice.Text.Length == 0) return;
            updateTotalPrice();
        }

        private void onBuyTapped(object sender, EventArgs e)
        {
            valideate();
        }
    }
}
