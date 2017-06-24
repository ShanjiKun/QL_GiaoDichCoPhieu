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
    public partial class frmChangePassword : Form
    {
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_GDCPDataSet.NDT' table. You can move, or remove it, as needed.
            this.nDTTableAdapter.Fill(this.qL_GDCPDataSet.NDT);
            DataRow dt = this.qL_GDCPDataSet.NDT.Take(1).FirstOrDefault();
            txtName.Text = dt[1].ToString();
            txtID.Text = dt[6].ToString();
            txtPhone.Text = dt[5].ToString();
            txtEmail.Text = dt[8].ToString();
        }

        private void cmbMaNDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaNDT.SelectedValue != null)
            {
                string MaNDT = cmbMaNDT.SelectedValue.ToString();
                DataRow dt = this.qL_GDCPDataSet.NDT.Where(c => c.MaNDT == MaNDT).FirstOrDefault();
                txtName.Text = dt[1].ToString();
                txtID.Text = dt[6].ToString();
                txtPhone.Text = dt[5].ToString();
                txtEmail.Text = dt[8].ToString();
            }
        }

        void checkNotNull()
        {
            if (txtOldPass.Text != "" && txtNewPass.Text != "" && txtConfirm.Text != "")
                btnCreate.Enabled = true;
            else btnCreate.Enabled = false;
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtNewPass_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtConfirm_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirm.Text == txtNewPass.Text)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
            checkNotNull();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
