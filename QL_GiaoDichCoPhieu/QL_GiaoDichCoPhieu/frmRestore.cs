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
    public partial class frmRestore : Form
    {
        public frmRestore()
        {
            InitializeComponent();
            this.sP_STTBACKUPTableAdapter.Connection.ConnectionString = Program.datasetConnectionString;
            this.sP_STTBACKUPTableAdapter.Fill(this.qL_GDCPDataSet.SP_STTBACKUP, 1);
        }

        private void btnSL_Click(object sender, EventArgs e)
        {
            
        }
    }
}
