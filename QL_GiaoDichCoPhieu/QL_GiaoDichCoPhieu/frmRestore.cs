using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_GiaoDichCoPhieu.Models;

namespace QL_GiaoDichCoPhieu
{
    public partial class frmRestore : Form
    {
        public frmRestore()
        {
            InitializeComponent();
            this.sP_STTBACKUPTableAdapter.Connection.ConnectionString = Program.datasetConnectionString;
            this.sP_STTBACKUPTableAdapter.Fill(this.qL_GDCPDataSet.SP_STTBACKUP, Program.media_id);
        }

        private void btnSL_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)gridControl1.MainView).GetSelectedRows();
            DataRowView selRow = (DataRowView)(((GridView)gridControl1.MainView).GetRow(selRows[0]));
            string pos = selRow["position"].ToString();

            btnSL.Enabled = false;

            bool isSuccess = DatabaseManager.sharedInstance().restoreDB(pos);
            if (isSuccess)
            {
                MessageBox.Show("Khôi phục về phiên bản "+pos+" thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Khôi phục thất bại!");
                btnSL.Enabled = true;
            }
        }
    }
}
