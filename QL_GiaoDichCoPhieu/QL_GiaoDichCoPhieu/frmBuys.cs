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
    public partial class frmBuys : Form
    {
        public frmBuys()
        {
            InitializeComponent();
        }

        private void onFormLoaded(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString();
        }
    }
}
