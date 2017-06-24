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
        UInt64 availableBalance = 0;

        float priceMax;
        float priceMin;

        UInt64 totalPrice;

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

        //--Method--
        //--------Handle Transaction------
        void handleTransaction()
        {
            string transID = "M";
            string mode = "LO";
            int buyCount = Decimal.ToInt32(nudBuyCount.Value);
            string stockID = cbStock.Text;
            float price = (float)nudBuyPrice.Value;
            string accountID = cbAccountID.Text;
            DatabaseManager.sharedInstance().createTransaction(transID, mode, buyCount, stockID, price, accountID);
            refreshUI();
        }
        void refreshUI()
        {
            nudBuyCount.Value = 0;
            nudBuyPrice.Value = 0;
            tbPasswordTransaction.Text = "";
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
            decimal stockCount = nudBuyCount.Value;
            decimal buyPrice = nudBuyPrice.Value;
            UInt64 total = Decimal.ToUInt64(stockCount*buyPrice*1000);
            lbTotalPrice.Text = total.ToString() + " VND";
            totalPrice = total;
        }
        void valideate()
        {
            btnBuy.Enabled = false;

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
            if (nudBuyCount.Value == 0)
            {
                Console.WriteLine("Stock Balance empty!");
                return;
            }
            if (nudBuyCount.Value > 10000000)
            {
                Console.WriteLine("Maximum of Stock balance is 10,000,000!");
                return;
            }
            //---Buy Price----
            if (nudBuyPrice.Value == 0)
            {
                Console.WriteLine("Buy price must greater than 0.0!");
                return;
            }
            if (nudBuyPrice.Value > 10000)
            {
                Console.WriteLine("Maximum of buy price is 10,000,000!");
                return;
            }
            if ((float)nudBuyPrice.Value*1000 < priceMin || (float)nudBuyPrice .Value*1000 > priceMax)
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
            //---TotalPrice----
            if (totalPrice > availableBalance)
            {
                Console.WriteLine("Your balance don't enough!");
                return;
            }

            btnBuy.Enabled = true;
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
            lbBalance.Text = double.Parse(list[1])*1000 + " VND";
            availableBalance = (UInt64)float.Parse(list[1])*1000;

            //
            valideate();
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

            priceMax = float.Parse(list[0]) * 1000;
            priceMin = float.Parse(list[1]) * 1000;

            //
            valideate();
        }

        private void onBuyBalanceChanged(object sender, EventArgs e)
        {
            updateTotalPrice();

            //
            valideate();
        }

        private void onBuyPriceChanged(object sender, EventArgs e)
        {
            updateTotalPrice();

            //
            valideate();
        }

        private void onBuyTapped(object sender, EventArgs e)
        {
            handleTransaction(); 
        }

        private void onTextChanged(object sender, EventArgs e)
        {
            valideate();
        }
    }
}
