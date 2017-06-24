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
    public partial class frmBalanceStock : Form
    {
        public frmBalanceStock()
        {
            InitializeComponent();
        }

        private void frmBalanceStock_Load(object sender, EventArgs e)
        {
            gctBalanceStock.DataSource = Connection.getDSCP("111111");
        }
    }
}
