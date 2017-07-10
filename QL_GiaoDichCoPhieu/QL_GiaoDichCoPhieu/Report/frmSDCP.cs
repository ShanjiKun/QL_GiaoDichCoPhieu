using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GiaoDichCoPhieu.Report
{
    public partial class frmSDCP : Form
    {
        public frmSDCP()
        {
            InitializeComponent();
        }

        private void frmSDCP_Load(object sender, EventArgs e)
        {
            rptSDCP rpt = new rptSDCP();
            string query = @"exec SP_SDCP '"+Program.UserName+"'";
            DataTable dt = Connection.getData(query);
            rpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rpt;
        }
    }
}
