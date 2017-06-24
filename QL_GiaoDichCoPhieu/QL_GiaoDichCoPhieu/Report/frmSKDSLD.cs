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
    public partial class frmSKDSLD : Form
    {
        string fromDate;
        string toDate;

        public frmSKDSLD(string fromDate, string toDate)
        {
            InitializeComponent();
            this.fromDate = fromDate;
            this.toDate = toDate;
        }

        private void crvSKDSLD_Load(object sender, EventArgs e)
        {
            rptSKDSLD rpt = new rptSKDSLD();
            string query = @"exec SP_SKDSLD '"+fromDate+"', '"+toDate+"'";
            DataTable dt = Connection.getData(query);
            rpt.SetDataSource(dt);
            crvSKDSLD.ReportSource = rpt;
        }
    }
}
