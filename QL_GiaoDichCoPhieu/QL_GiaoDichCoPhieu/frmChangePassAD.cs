using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GiaoDichCoPhieu
{
    public partial class frmChangePassAD : Form
    {
        public frmChangePassAD()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtNewLogin.Text.ToString() == "" || txtCfLogin.Text.ToString() == "")
                MessageBox.Show("Không được để trống !");
            else if(txtCfLogin.Text.ToString() != txtNewLogin.Text.ToString())
                MessageBox.Show("Xác nhận mật khẩu không đúng !");
            else
            {
                string sql = "ALTER LOGIN "+Program.Id+" WITH PASSWORD = '"+txtCfLogin.Text.ToString()+"'";
                try
                {
                    if(Connection.ExecQueryString(sql) != 0)
                    {
                        MessageBox.Show("Cập nhật thành công !");
                        this.Close();
                    }          
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
