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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnSL_Click(object sender, EventArgs e)
        {
            string sql = "BACKUP DATABASE QL_GDCP TO Bk_GDCP";
            if(Connection.ExecQueryString(sql) > 0)
                MessageBox.Show("Backup thành công !");
            else
                MessageBox.Show("Thất bại !");
        }
    }
}
