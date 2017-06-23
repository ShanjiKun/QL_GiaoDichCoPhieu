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
    public partial class frmSell : Form
    {

        int availableStockBalance = 0;

        float priceMax;
        float priceMin;

        int totalSellStock;

        public frmSell()
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

        //--Method--
        //--------Handle Transaction------
        void handleTransaction()
        {
            string transID = "M";
            string mode = "LO";
            int buyCount = Decimal.ToInt32(nudSellCount.Value);
            string stockID = cbStock.Text;
            float price = (float)nudSellPrice.Value;
            string accountID = cbAccountID.Text;
            DatabaseManager.sharedInstance().createTransaction(transID, mode, buyCount, stockID, price, accountID);
        }
        //--------------------------------
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
            decimal stockCount = nudSellCount.Value;
            decimal buyPrice = nudSellPrice.Value;
            UInt64 total = Decimal.ToUInt64(stockCount * buyPrice * 1000);
            lbTotalPrice.Text = total.ToString() + " VND";

            totalSellStock = (int)(stockCount);
        }
        void valideate()
        {
            btnSell.Enabled = false;

            //---BankAcount---
            if (cbAccountID.Text.Length == 0)
            {
                Console.WriteLine("Bank Account empty!");
                return;
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
                Console.WriteLine("Bank Account invalid!");
                return;
            }
            //---Stock ID----
            if (cbStock.Text.Length == 0)
            {
                Console.WriteLine("Stock ID empty!");
                return;
            }
            List<ComboBoxItem> listCB = (List<ComboBoxItem>)cbStock.DataSource;
            i = 0;
            while (i < listCB.Count)
            {
                if (listCB[i].value == cbStock.Text) break;
                i++;
            }
            if (i == listCB.Count)
            {
                Console.WriteLine("Stock ID invalid!");
                return;
            }
            //---Stock Balance---
            if (nudSellCount.Value == 0)
            {
                Console.WriteLine("Stock Balance empty!");
                return;
            }
            if (nudSellCount.Value > 10000000)
            {
                Console.WriteLine("Maximum of Stock balance is 10,000,000!");
                return;
            }
            //---SELL Price----
            if (nudSellPrice.Value == 0)
            {
                Console.WriteLine("Buy price must greater than 0.0!");
                return;
            }
            if (nudSellPrice.Value > 10000)
            {
                Console.WriteLine("Maximum of buy price is 10,000,000!");
                return;
            }
            if ((float)nudSellPrice.Value * 1000 < priceMin || (float)nudSellPrice.Value * 1000 > priceMax)
            {
                Console.WriteLine("Price must in " + priceMin + " < your price < " + priceMax);
                return;
            }
            //---Password----
            if (tbPasswordTransaction.Text.Length == 0)
            {
                Console.WriteLine("Password empty!");
                return;
            }
            //---Total Sell Stock----
            if (totalSellStock > availableStockBalance)
            {
                Console.WriteLine("Your balance don't enough!");
                return;
            }

            btnSell.Enabled = true;
        }
        //----Action----
        private void oncbAccountIDChanged(object sender, EventArgs e)
        {
            BankAccount bankAcc = (BankAccount)cbAccountID.SelectedItem;
            List<String> list = DatabaseManager.sharedInstance().getBankNameAndBalance(bankAcc.accountID);
            if (list.Count == 0)
            {
                MessageBox.Show("Can't get Name and Banlance!");
                return;
            }

            lbBankName.Text = list[0];
            lbBalance.Text = double.Parse(list[1]) * 1000 + " VND";

            //
            valideate();
        }

        private void oncbStockChanged(object sender, EventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem)cbStock.SelectedValue;
            String stockID = item.text;
            List<String> list = DatabaseManager.sharedInstance().getStockPrices(stockID);

            int stockBalance = DatabaseManager.sharedInstance().getStockBalance(stockID);

            if (list.Count == 0)
            {
                MessageBox.Show("Can't get prices!");
                return;
            }

            lbPriceMax.Text = list[0];
            lbPriceMin.Text = list[1];
            lbPriceMiddle.Text = list[2];
            lbStockBalance.Text = stockBalance.ToString();

            priceMax = float.Parse(list[0]) * 1000;
            priceMin = float.Parse(list[1]) * 1000;
            availableStockBalance = stockBalance;

            //
            valideate();
        }
        private void onSellBalanceChanged(object sender, EventArgs e)
        {
            updateTotalPrice();

            //
            valideate();
        }

        private void onSellPriceChanged(object sender, EventArgs e)
        {
            updateTotalPrice();

            //
            valideate();
        }

        private void onSellTapped(object sender, EventArgs e)
        {
            handleTransaction();
        }

        private void onTextChanged(object sender, EventArgs e)
        {
            valideate();
        }
    }
}
