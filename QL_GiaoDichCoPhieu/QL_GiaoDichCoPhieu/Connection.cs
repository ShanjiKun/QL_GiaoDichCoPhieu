using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_GiaoDichCoPhieu
{
    class Connection
    {
        public static DataTable getData(string SQL)
        {
            string connectionString = "Data Source=VUTRONGTUANDBE9;Initial Catalog=QL_GDCP"
                        + ";Integrated Security=SSPI";
            //string SQL = "select MASV, HO, TEN, MALOP, PHAI, NGAYSINH, NOISINH, DIACHI, GHICHU, NGHIHOC from Sinhvien";
            // tạo kết nối đến CSDL           
            SqlConnection cnn = new SqlConnection(connectionString);
            // kiểm tra kết nối
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            // thực hiện câu lệnh query thông qua SqlCommand
            SqlCommand cmd = new SqlCommand(SQL, cnn);
            // sử dụng DataAdapter để thực hiện câu lệnh và nhận dữ liệu
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            // đưa dữ liệu vào DataTable
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
