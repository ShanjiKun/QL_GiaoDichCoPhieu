using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GiaoDichCoPhieu
{
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_GDCPDataSet.NDT' table. You can move, or remove it, as needed.
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtOldLogin.Text.ToString() == "" || txtNewLogin.Text.ToString() == "" || txtCfLogin.Text.ToString() == "" || txtOld.Text.ToString() == "" || txtNew.Text.ToString() == "" || txtCf.Text.ToString() == "")
                MessageBox.Show("Không được để trống !");
            else if(txtNewLogin.Text.ToString() != txtCfLogin.Text.ToString())
                MessageBox.Show("Xác nhận mật khẩu đăng nhập không khớp !");
            else if(txtNew.Text.ToString() != txtCf.Text.ToString())
                MessageBox.Show("Xác nhận mật khẩu giao dịch không khớp !");
            else
            {
                string connection = "Data Source=" + Program.serverName + ";" +
                         "Initial Catalog=QL_GDCP;" +
                         "User id=" + Program.Id + ";" +
                         "Password=" + txtOldLogin.Text.ToString() + ";";
                try
                {
                    string sql = "ALTER LOGIN " + Program.Id + " WITH PASSWORD = '" + txtCfLogin.Text.ToString() + "'";
                    if (Connection.ExecQueryString(sql) != 0)
                    {
                        check(connection);
                        MessageBox.Show("Cập nhật thành công !");
                        this.Close();
                    }               
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mật khẩu đăng nhập không đúng");
                }
                
            }

        }

        void check(string connection)
        {
            SqlConnection cnn = new SqlConnection(connection);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_CHECKMK", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNDT", Program.UserName);
            cmd.Parameters.AddWithValue("@MKGD", txtOld.Text.ToString());
            cmd.Parameters.AddWithValue("@NMKGD", txtNew.Text.ToString());
            var returnParameter = cmd.Parameters.Add("@Returns", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            if ((int)returnParameter.Value == 0)
                MessageBox.Show("Mật khẩu giao dịch không đúng !");
        }
    }
}
