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

    public partial class frmLK : Form

    {

        public frmLK()

        {

            InitializeComponent();

        }



        private void frmLK_Load(object sender, EventArgs e)

        {
            this.sP_LKTableAdapter.Connection.ConnectionString = Program.datasetConnectionString;
            this.sP_LKTableAdapter.Fill(this.qL_GDCPDataSet.SP_LK, dtpToDate.Value, dtpFromDate.Value);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            this.sP_LKTableAdapter.Connection.ConnectionString = Program.datasetConnectionString;
            this.sP_LKTableAdapter.Fill(this.qL_GDCPDataSet.SP_LK, dtpToDate.Value, dtpFromDate.Value);
        }

        private void btnSK_Click(object sender, EventArgs e)
        {
            string toDate = dtpFromDate.Value.ToString();
            string fromDate = dtpToDate.Value.ToString();
            Report.frmSKDSLD frm = new Report.frmSKDSLD(fromDate, toDate);
            frm.ShowDialog();
        }
    }

}

