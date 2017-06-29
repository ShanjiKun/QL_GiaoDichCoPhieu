using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_GiaoDichCoPhieu.Models;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QL_GiaoDichCoPhieu.Models
{
    class DatabaseManager
    {
        //----Public variable----
        private String connectionString;

        //----Singleton----
        private static DatabaseManager instance;
        public static DatabaseManager sharedInstance()
        {
            if (instance == null)
            {
                instance = new DatabaseManager();
            }
            return instance;
        }
        //----Private methods----
        private bool execute(String query, Func<SqlDataReader, int> onSuccess)
        {
            //----Temp----
            //------------
            if (connectionString == null)
            {
                string cnn = "Data Source="+Program.serverName+";Initial Catalog=QL_GDCP"
                        + ";User ID=linhdan" + ";password=1234";
               setConnectionString(cnn);
            }

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    onSuccess(reader);
                }
                conn.Close();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Number.ToString());
                return false;
            }
        }
        //----Public methods----
        //----Set----
        public void setConnectionString(String _connectionString)
        {
            this.connectionString = _connectionString;
        }
        //----Get----
        public List<BankAccount> getListBankAccount()
        {
            List<BankAccount> list = new List<BankAccount>();

            String query = "SELECT * FROM TAIKHOAN_NGANHANG WHERE MaNDT = '" + Program.UserName + "'";
            execute(query, (SqlDataReader reader) => {

                while (reader.Read())
                {
                    BankAccount bankAccount = new BankAccount();
                    bankAccount.accountID = (String)reader["MaTk"];
                    bankAccount.investerID = (String)reader["MaNDT"];
                    bankAccount.accountBalance = (Double)reader["SoTien"];
                    bankAccount.bankID = (String)reader["MaNH"];
                    list.Add(bankAccount);
                }
                return 1;
            });
            return list;
        }
        public List<String> getBankNameAndBalance(String accountID)
        {
            List<String> list = new List<String>();

            String query = "SELECT nh.TenNH, tk.SoTien FROM NGANHANG nh inner join(SELECT MaNH, SoTien FROM TAIKHOAN_NGANHANG WHERE MaTK = '"+accountID+"') tk on tk.MaNH = nh.MaNH";
            execute(query, (SqlDataReader reader) => {

                while (reader.Read())
                {
                    list.Add((String)reader["TenNH"]);
                    list.Add(reader["SoTien"].ToString());
                }
                return 1;
            });
            return list;
        }
        public List<ComboBoxItem> getListStock()
        {
            List<ComboBoxItem> list = new List<ComboBoxItem>();

            String query = "SELECT MaCP FROM COPHIEU";
            execute(query, (SqlDataReader reader) => {

                while (reader.Read())
                {
                    ComboBoxItem item = new ComboBoxItem() { text = reader["MaCP"].ToString(), value = reader["MaCP"].ToString() };
                    list.Add(item);
                }
                return 1;
            });
            return list;
        }
        public List<String> getStockPrices(String stockID)
        {
            List<String> list = new List<String>();

            String query = "SELECT GiaTran, GiaSan, GiaTC FROM LICHSUGIA WHERE MaCP = '"+stockID+"'";
            execute(query, (SqlDataReader reader) => {

                while (reader.Read())
                {
                    list.Add(reader["GiaTran"].ToString());
                    list.Add(reader["GiaSan"].ToString());
                    list.Add(reader["GiaTC"].ToString());
                }
                return 1;
            });
            return list;
        }

        public int getStockBalance(string stockID)
        {
            string userID = Program.UserName;
            int stockBalance = 0;
            String query = "SELECT SoLuong FROM SOHUU WHERE MaNDT = '" + userID + "' AND MaCP = '" + stockID + "'";
            execute(query, (SqlDataReader reader) => {

                while (reader.Read())
                {
                   stockBalance = reader.GetInt32(0);
                }
                return 1;
            });
            return stockBalance;
        }

        public bool checkTransactonPassword(string password)
        {
            string userID = Program.UserName;
            bool isCorrect = false;
            string query = "SELECT 1 FROM NDT WHERE MaNDT = '" + userID + "' AND MKGD = '" + password + "'";
            execute(query, (SqlDataReader reader) => {

                if (reader.Read()) isCorrect = true;
                return 1;
            });
            return isCorrect;
        }

        //---Insert----
        public bool createTransaction(string transType, string mode, int buyCount, string stockID, float price, string accountID)
        {
            bool isSuccess;
            string userID = Program.UserName;
            string query = "EXEC SP_TaoGDKhopLenh '" + transType + "', " + price + ", '" + stockID + "', " + buyCount + ", '" + userID + "', '" + accountID + "'";
            isSuccess = execute(query, (SqlDataReader reader) => {

                if (reader.Read())
                {
                    MessageBox.Show(reader[0] + " " + reader[1] + " " + reader[2]);
                    isSuccess = false;
                }
                return 1;
            });
            return isSuccess;
        }
    }
}
