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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizedLogin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

  
        private static bool connectionServer(string connectionString)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            try
            {
                if (cnn.State == ConnectionState.Closed)
                    cnn.Open();
                if (cnn.State == ConnectionState.Open && connectionString != null)
                {
                    cnn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private static SqlDataReader ExecSqlDataReader(string query, string connectionString)
        {
            SqlDataReader myreader;
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.CommandType = CommandType.Text;
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            myreader = cmd.ExecuteReader();
            return myreader;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string cnn = "Data Source="+Program.serverName+";Initial Catalog=QL_GDCP"
                        + ";User ID=" + username + ";password=" + password;
            if (connectionServer(cnn))
            {
                string query = "exec SP_DANGNHAP '" + username + "'";
                SqlDataReader sdr = ExecSqlDataReader(query, cnn);
                if (sdr == null)
                    return;
                sdr.Read();

                Program.UserName = sdr.GetString(0);
                Program.Name = sdr.GetString(2);

                frmMain frmMain = new frmMain();
                this.Hide();
                frmMain.Show();
            }
        }
    }
}
