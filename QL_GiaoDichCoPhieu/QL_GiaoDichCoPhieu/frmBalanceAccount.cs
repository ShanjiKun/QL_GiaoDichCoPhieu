using QL_GiaoDichCoPhieu.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GiaoDichCoPhieu
{
    public partial class frmBalanceAccount : Form
    {

        DataTable dtAccount;

        public frmBalanceAccount()
        {
            InitializeComponent();
        }

        private void frmBalanceAccount_Load(object sender, EventArgs e)
        {
            this.sP_SDCPTableAdapter.Connection.ConnectionString = Program.datasetConnectionString;
            this.sP_SDCPTableAdapter.Fill(this.qL_GDCPDataSet.SP_SDCP, Program.UserName);

            string sql = "exec SP_GETACCNDT '"+ Program.UserName +"'";
            dtAccount = Connection.getData(sql);
            cmbAccount.DataSource = dtAccount;
            cmbAccount.DisplayMember = "MaTK";
            cmbAccount.ValueMember = "MaTK";

            lblNameAccount.Text = dtAccount.Rows[0][3].ToString();
            lblBalanceAccount.Text = dtAccount.Rows[0][1].ToString();
            lblIdBank.Text = dtAccount.Rows[0][0].ToString();
            lblNameBank.Text = dtAccount.Rows[0][2].ToString();

            SqlDataReader sdr = Connection.getAvailableMoney(cmbAccount.SelectedValue.ToString());
            if (sdr.Read())
            {
                int total = Convert.ToInt32(dtAccount.Rows[0][1]);
                int allow = Convert.ToInt32(sdr[0]);
                lblAllowBalance.Text = (total - allow).ToString();
            }
            else lblAllowBalance.Text = dtAccount.Rows[0][1].ToString();
        }

        private void cmbAccount_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cmbAccount.SelectedValue == null)
                return;

            int index = cmbAccount.SelectedIndex;
            lblNameAccount.Text = dtAccount.Rows[index][3].ToString();
            lblBalanceAccount.Text = dtAccount.Rows[index][1].ToString();
            lblIdBank.Text = dtAccount.Rows[index][0].ToString();
            lblNameBank.Text = dtAccount.Rows[index][2].ToString();
            SqlDataReader sdr = Connection.getAvailableMoney(cmbAccount.SelectedValue.ToString());
            if (sdr.Read())
            {
                string sql = "select SoTien from TAIKHOAN_NGANHANG where MaTK = '"+cmbAccount.SelectedValue+"'";
                SqlDataReader reader = Connection.ExecSqlDataReader(sql);
                if (reader.Read())
                {
                    int total = Convert.ToInt32(reader[0]);
                    int allow = Convert.ToInt32(sdr[0]);
                    lblAllowBalance.Text = (total - allow).ToString();
                }
            }
            else lblAllowBalance.Text = dtAccount.Rows[index][1].ToString();
        }

        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmSDCP frm = new frmSDCP();
            frm.ShowDialog();
        }

    }
}
