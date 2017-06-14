﻿using System;
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
    public partial class frmBalanceAccount : Form
    {

        DataTable dtAccount;

        public frmBalanceAccount()
        {
            InitializeComponent();
        }

        private void frmBalanceAccount_Load(object sender, EventArgs e)
        {
            string sql = "select TN.MaTK, TN.SoTien, NH.TenNH, NDT.HoTen from TAIKHOAN_NGANHANG as TN, NDT, NGANHANG as NH where TN.MaNH = NH.MaNH and TN.MaNDT = NDT.MaNDT and NDT.MaNDT = 111111";
            dtAccount = Connection.getData(sql);
            cmbAccount.DataSource = dtAccount;
            cmbAccount.DisplayMember = "MaTK";
            cmbAccount.ValueMember = "MaTK";

            lblNameAccount.Text = dtAccount.Rows[0][3].ToString();
            lblBalanceAccount.Text = dtAccount.Rows[0][1].ToString();
            lblIdBank.Text = dtAccount.Rows[0][0].ToString();
            lblNameBank.Text = dtAccount.Rows[0][2].ToString();
        }

        private void cmbAccount_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cmbAccount.SelectedIndex;
            lblNameAccount.Text = dtAccount.Rows[index][3].ToString();
            lblBalanceAccount.Text = dtAccount.Rows[index][1].ToString();
            lblIdBank.Text = dtAccount.Rows[index][0].ToString();
            lblNameBank.Text = dtAccount.Rows[index][2].ToString();
        }
    }
}
