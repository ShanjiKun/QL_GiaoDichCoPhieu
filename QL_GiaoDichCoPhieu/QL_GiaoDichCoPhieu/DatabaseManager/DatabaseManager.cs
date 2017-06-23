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
        private void getData(String query, Func<SqlDataReader, int> onSuccess)
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
                command.Parameters.AddWithValue("@zip", "india");

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    onSuccess(reader);
                }
                conn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Number.ToString());
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

            String query = "SELECT * FROM TAIKHOAN_NGANHANG";
            getData(query, (SqlDataReader reader) => {

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
            getData(query, (SqlDataReader reader) => {

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
            getData(query, (SqlDataReader reader) => {

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
            getData(query, (SqlDataReader reader) => {

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
        //---Insert----
        public int createTransaction(string transType, string mode, int buyCount, string stockID, float price, string accountID)
        {
            string query = "INSERT INTO LENHDAT(NgayGD, LoaiLenh, PhuongThuc, SoLuong, MaCP, Gia, MaTK, TrangThai)"
                            +"VALUES("
                            +DateTime.Now + ", "
                            +transType + ", "
                            +mode +", "
                            +buyCount +", "
                            +stockID +", "
                            +price +", "
                            +accountID +", "
                            +"Cho"
                            +")";
            return 0;
        }
    }
}
