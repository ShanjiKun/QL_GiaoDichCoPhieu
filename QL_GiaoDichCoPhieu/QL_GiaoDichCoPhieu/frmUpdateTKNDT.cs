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
    public partial class frmUpdateTKNDT : Form
    {

        public frmUpdateTKNDT()
        {
            InitializeComponent();
            btnCreate.Enabled = false; 
        }

        private void frmUpdateTKNDT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_GDCPDataSet.NDT' table. You can move, or remove it, as needed.
            this.nDTTableAdapter.Fill(this.qL_GDCPDataSet.NDT);
            // TODO: This line of code loads data into the 'qL_GDCPDataSet.NGANHANG' table. You can move, or remove it, as needed.
            this.nGANHANGTableAdapter.Fill(this.qL_GDCPDataSet.NGANHANG);
            DataRow dt = this.qL_GDCPDataSet.NDT.Take(1).FirstOrDefault();
            txtName.Text = dt[1].ToString();
            txtID.Text = dt[6].ToString();
            txtPhone.Text = dt[5].ToString();
            txtEmail.Text = dt[8].ToString();
        }

        private void txtMaTK_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        void checkNotNull()
        {
            if (txtMaTK.Text != "" && txtMoney.Text != "")
                btnCreate.Enabled = true;
            else btnCreate.Enabled = false;
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
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

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string MaTK = txtMaTK.Text;
            string MaNDT = cmbMaNDT.SelectedValue.ToString();
            string MaNH = cmbBank.SelectedValue.ToString();
            string SoTien = txtMoney.Text;
            string SQL = "INSERT INTO TAIKHOAN_NGANHANG (MaTK, MaNDT, MaNH, SoTien)  VALUES('"+MaTK+"','"+MaNDT+"','"+MaNH+"',"+SoTien+")";
            if (Connection.ExecQueryString(SQL)>0)
            {
                MessageBox.Show("Cập nhật thành công!");
                txtMaTK.Text = "";
                txtMoney.Text = "";
            }
            else{
                MessageBox.Show("Câp nhật thất bại!");
            }
        }

        private void txtMaTK_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Connection.checkMaTK(txtMaTK.Text) == 1)
                {
                    MessageBox.Show("Mã tài khoản đã tồn tại!");
                    txtMaTK.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
