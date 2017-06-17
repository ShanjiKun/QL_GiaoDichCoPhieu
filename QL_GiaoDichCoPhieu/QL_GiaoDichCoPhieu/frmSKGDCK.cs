using QL_GiaoDichCoPhieu.Report;
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
    public partial class frmSKGDCK : Form
    {
        public frmSKGDCK()
        {
            InitializeComponent();
        }

        private void btnSK_Click(object sender, EventArgs e)
        {
            frmReportSKLD frm = new frmReportSKLD();
            frm.Show();
        }
    }
}
