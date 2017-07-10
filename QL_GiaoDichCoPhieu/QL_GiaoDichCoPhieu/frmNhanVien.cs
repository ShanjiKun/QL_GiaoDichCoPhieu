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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            btnFinish.Visible = false;
            btnHuy.Visible = false;
            disableLeft();
            disableRight();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_GDCPDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Connection.ConnectionString = Program.datasetConnectionString;
            this.nHANVIENTableAdapter.Fill(this.qL_GDCPDataSet.NHANVIEN);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nHANVIENBindingSource.AddNew();
  
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            btnFinish.Visible = true;
            btnHuy.Visible = true;

            enableLeft();
            enableRight();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnFinish.Visible = true;
            btnHuy.Visible = true;

            enableLeft();
            maNVTextEdit.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn thực sự có muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //string query = "exec SP_DEL_USER '"++"'";
                nHANVIENBindingSource.RemoveCurrent();
                nHANVIENTableAdapter.Update(this.qL_GDCPDataSet.NHANVIEN);
            }
        }

        void disableLeft()
        {
            phoneTextEdit.Enabled = false;
            cMNDTextEdit.Enabled = false;
            gioiTinhTextEdit.Enabled = false;
            emailTextEdit.Enabled = false;
            maNVTextEdit.Enabled = false;
            hoTenTextEdit.Enabled = false;
            ngaySinhDateEdit.Enabled = false;
            diaChiTextEdit.Enabled = false;
        }

        void disableRight()
        {
            txtTK.Enabled = false;
            txtPass.Enabled = false;
            txtCpass.Enabled = false;
            radAdmin.Enabled = false;
            radNV.Enabled = false;
        }

        void enableRight()
        {
            txtTK.Enabled = true;
            txtPass.Enabled = true;
            txtCpass.Enabled = true;
            radAdmin.Enabled = true;
            radNV.Enabled = true;
        }

        void enableLeft()
        {
            phoneTextEdit.Enabled = true;
            cMNDTextEdit.Enabled = true;
            gioiTinhTextEdit.Enabled = true;
            emailTextEdit.Enabled = true;
            maNVTextEdit.Enabled = true;
            hoTenTextEdit.Enabled = true;
            ngaySinhDateEdit.Enabled = true;
            diaChiTextEdit.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (radNV.Checked == true)
            {
                if(isNull())
                    MessageBox.Show("Không được để trống !");
                else
                {
                    string query = "exec TAO_LOGIN '" + txtTK.Text.ToString() + "','" + txtPass.Text.ToString() + "','" + maNVTextEdit.Text + "','NHANVIEN'";
                    try
                    {
                        if (Connection.ExecQueryString(query) != 0)
                            MessageBox.Show("Thêm thành công !");
                        nHANVIENBindingSource.EndEdit();
                        nHANVIENTableAdapter.Update(this.qL_GDCPDataSet.NHANVIEN);
                        txtTK.Text = "";
                        txtPass.Text = "";
                        txtCpass.Text = "";
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
                        btnFinish.Visible = false;
                        btnHuy.Visible = false;
                        disableLeft();
                        disableRight();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                if(txtTK.Text == "" || txtPass.Text == "" || txtCpass.Text == "")
                    MessageBox.Show("Không được để trống !");
                else
                {
                    if (txtCpass.Text != txtPass.Text)
                        MessageBox.Show("Mật khẩu không khớp !");
                    else
                    {
                        string query = "exec TAO_LOGIN '" + txtTK.Text.ToString() + "','" + txtPass.Text.ToString() + "','" + txtTK.Text.ToString() + "','ADMIN'";
                        try
                        {
                            if (Connection.ExecQueryString(query) != 0)
                                MessageBox.Show("Thêm thành công !");
                            txtTK.Text = "";
                            txtPass.Text = "";
                            txtCpass.Text = "";
                            btnAdd.Enabled = true;
                            btnDelete.Enabled = true;
                            btnEdit.Enabled = true;
                            btnFinish.Visible = false;
                            btnHuy.Visible = false;
                            disableLeft();
                            disableRight();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            nHANVIENBindingSource.CancelEdit();
            txtTK.Text = "";
            txtPass.Text = "";
            txtCpass.Text = "";
            radNV.Checked = true;
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnFinish.Visible = false;
            btnHuy.Visible = false;
            disableLeft();
            disableRight();
        }

        private void radNV_CheckedChanged(object sender, EventArgs e)
        {
            if(radNV.Checked == true)
            {
                enableLeft();
                enableRight();
            }else
            {
                disableLeft();
                enableRight();
            }
        }

        bool isNull()
        {
            if(phoneTextEdit.Text == "" || cMNDTextEdit.Text == "" || gioiTinhTextEdit.Text == "" || emailTextEdit.Text == "" || maNVTextEdit.Text == "" || hoTenTextEdit.Text == "" || ngaySinhDateEdit.Text == "" || diaChiTextEdit.Text == "" || txtTK.Text == "" || txtPass.Text == "" || txtCpass.Text == "")
                return true;
            return false;
        }
    }
}
