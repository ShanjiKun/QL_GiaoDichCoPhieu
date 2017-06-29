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

            string sql = "select * from LENHKHOP";
            DataTable dtLK = Connection.getData(sql);
            BindingSource bs = new BindingSource();
            bs.DataSource = dtLK;
            gctLK.DataSource = bs;

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string toDate = dtpToDate.Value.ToString();
            string fromDate = dtpFromDate.Value.ToString();

            string sql = "select * from LENHKHOP where NgayGD >= '" + fromDate + "' and NgayGD <= '" + toDate + "'";

            DataTable dtGD = Connection.getData(sql);

            BindingSource bs = new BindingSource();

            bs.DataSource = dtGD;

            gctLK.DataSource = bs;
        }
    }

}

