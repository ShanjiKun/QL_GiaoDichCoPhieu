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

            string sql = "select * from LENHDAT";

            DataTable dtGD = Connection.getData(sql);

            BindingSource bs = new BindingSource();

            bs.DataSource = dtGD;

            gctGD.DataSource = bs;

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string toDate = dtpToDate.Value.ToShortDateString();
            string fromDate = dtpFromDate.Value.ToShortDateString();

            string sql = "select * from LENHDAT where NgayGD < " + fromDate + " and NgayGD > " + toDate;

            DataTable dtGD = Connection.getData(sql);

            BindingSource bs = new BindingSource();

            bs.DataSource = dtGD;

            gctGD.DataSource = bs;
        }
    }

}

