using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_GiaoDichCoPhieu
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }

        public static int media_id = 1;
        public static string Id;
        public static string UserName;
        public static string Name;
        public static string serverName = Environment.MachineName + "";
        public static string datasetConnectionString = "Data Source = " + serverName + "; Initial Catalog = QL_GDCP; Integrated Security = True";
    }
}
