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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
            this.sP_STTBACKUPTableAdapter.Connection.ConnectionString = Program.datasetConnectionString;
            this.sP_STTBACKUPTableAdapter.Fill(this.qL_GDCPDataSet.SP_STTBACKUP, Program.media_id);
        }

        private void btnSL_Click(object sender, EventArgs e)
        {
            bool isReset = checkBoxReset.Checked;
            bool isSuccess = DatabaseManager.sharedInstance().backupDB(isReset);
            if (isSuccess)
            {
                MessageBox.Show("Backup thành công !");
                this.sP_STTBACKUPTableAdapter.Connection.ConnectionString = Program.datasetConnectionString;
                this.sP_STTBACKUPTableAdapter.Fill(this.qL_GDCPDataSet.SP_STTBACKUP, Program.media_id);
            }
            else
                MessageBox.Show("Thất bại !");
        }

    }
}
