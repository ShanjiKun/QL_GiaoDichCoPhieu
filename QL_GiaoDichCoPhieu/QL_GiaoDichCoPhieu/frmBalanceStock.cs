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
            string sql = "select SH.MaCP, SH.SoLuong, CP.TenCty from SOHUU as SH, COPHIEU as CP where SH.MaNDT = 111111";
            DataTable dtBalanceStock = Connection.getData(sql);
            BindingSource bs = new BindingSource();
            bs.DataSource = dtBalanceStock;
            gctBalanceStock.DataSource = bs;
        }
    }
}
