using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtMaNDT.Text == "")
                MessageBox.Show("Vui lòng nhập mã đầu tư !", "Message", MessageBoxButtons.OK);
            else if(txtID.Text == "")
                MessageBox.Show("Vui lòng nhập chứng minh nhân dân !", "Message", MessageBoxButtons.OK);
            else if(txtPasswordGD.Text == "")
                MessageBox.Show("Vui lòng nhập mật khẩu giao dịch !", "Message", MessageBoxButtons.OK);
            else if(txtMoney.Text == "")
                MessageBox.Show("Vui lòng nhập số tiền !", "Message", MessageBoxButtons.OK);
            else if(txtName.Text == "")
                MessageBox.Show("Vui lòng nhập tên !", "Message", MessageBoxButtons.OK);
            else if(txtAddress.Text == "")
                MessageBox.Show("Vui lòng nhập địa chỉ !", "Message", MessageBoxButtons.OK);
            else if(txtPhone.Text == "")
                MessageBox.Show("Vui lòng nhập số điện thoại !", "Message", MessageBoxButtons.OK);
            else if(txtEmail.Text == "")
                MessageBox.Show("Vui lòng nhập email !", "Message", MessageBoxButtons.OK);
            else
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

                if (Connection.addDB(temp))
                    MessageBox.Show("Thêm nhà đầu tư thành công !", "Message", MessageBoxButtons.OK);
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
    }
}
