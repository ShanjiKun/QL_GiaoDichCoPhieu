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

    public partial class frmGD : Form

    {

        public frmGD()

        {

            InitializeComponent();

        }



        private void frmGD_Load(object sender, EventArgs e)

        {
            // TODO: This line of code loads data into the 'qL_GDCPDataSet.LENHDAT' table. You can move, or remove it, as needed.
            this.lENHDATTableAdapter.Connection.ConnectionString = Program.datasetConnectionString;
            this.lENHDATTableAdapter.Fill(this.qL_GDCPDataSet.LENHDAT);

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
      
            this.lENHDATTableAdapter.GetDataByDate(dtpFromDate.Value, dtpToDate.Value);

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

