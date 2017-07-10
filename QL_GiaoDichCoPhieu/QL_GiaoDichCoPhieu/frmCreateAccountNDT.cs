using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GiaoDichCoPhieu
{
    public partial class frmCreateAccountNDT : Form
    {
        public frmCreateAccountNDT()
        {
            InitializeComponent();
            btnCreate.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            addNDT temp = new addNDT();
            temp.maNDT = txtMaNDT.Text;
            temp.gioiTinh = radNam.Checked ? "Nam" : "Nu";
            temp.ngaySinh = dtpBirthDay.Value;
            temp.CMND = txtID.Text;
            temp.maTK = txtMaTK.Text;
            temp.nganHang = cmbBank.SelectedValue.ToString();
            temp.MKGD = txtPasswordGD.Text;
            temp.soTien = float.Parse(txtMoney.Text);
            temp.hoTen = txtName.Text;
            temp.diaChi = txtAddress.Text;
            temp.SDT = txtPhone.Text;
            temp.email = txtEmail.Text;

            try
            {
                string query = "exec TAO_LOGIN '" + txtTK.Text.ToString() + "','" + txtMK.Text.ToString() + "','" + txtMaNDT.Text + "','NDT'";
                if (Connection.ExecQueryString(query) != 0)
                    if (Connection.addDB(temp))
                        MessageBox.Show("Thêm nhà đầu tư thành công !", "Message", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCreateAccountNDT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_GDCPDataSet.NGANHANG' table. You can move, or remove it, as needed.
            this.nGANHANGTableAdapter.Connection.ConnectionString = Program.datasetConnectionString;
            this.nGANHANGTableAdapter.Fill(this.qL_GDCPDataSet.NGANHANG);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtMoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtCofirm_TextChanged(object sender, EventArgs e)
        {
            if (txtCofirm.Text == txtPasswordGD.Text)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
            checkNotNull();
        }

        private void txtMaNDT_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtMaTK_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtPasswordGD_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        void checkNotNull()
        {
            if (txtMoney.Text != "" && txtEmail.Text != "" && txtPhone.Text != "" &&
                txtAddress.Text != "" && txtName.Text != "" && txtPasswordGD.Text != ""
                && txtMaTK.Text != "" && txtID.Text != "" && txtMaNDT.Text != ""
                && txtCofirm.Text != "" && txtTK.Text != "" && txtXMK.Text != "" && txtMK.Text != "")
                btnCreate.Enabled = true;
            else btnCreate.Enabled = false;

        }

        private void txtMaNDT_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Connection.checkMaNDT(txtMaNDT.Text) == 1)
                {
                    MessageBox.Show("Mã nhà đầu tư đã tồn tại!");
                    txtMaNDT.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            checkNotNull();
        }

        private void txtXMK_TextChanged(object sender, EventArgs e)
        {
            if (txtMK.Text == txtXMK.Text)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
            checkNotNull();
        }
    }
}
