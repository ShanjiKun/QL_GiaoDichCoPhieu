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

        public static bool addDB(addNDT ndt)
        {
            string connectionString = "Data Source=VUTRONGTUANDBE9;Initial Catalog=QL_GDCP"
                        + ";Integrated Security=SSPI";
            SqlConnection cnn = new SqlConnection(connectionString);
            string SQL = "createNDT";

            SqlCommand cmd = new SqlCommand(SQL, cnn);

            // truyền tham số vào SqlCommand
            cmd.Parameters.AddWithValue("@MaNDT", ndt.maNDT);
            cmd.Parameters.AddWithValue("@HoTen", ndt.hoTen);
            cmd.Parameters.AddWithValue("@NgaySinh", ndt.ngaySinh);
            cmd.Parameters.AddWithValue("@MKGD", ndt.MKGD);
            cmd.Parameters.AddWithValue("@DiaChi", ndt.diaChi);
            cmd.Parameters.AddWithValue("@Phone", ndt.SDT);
            cmd.Parameters.AddWithValue("@CMND", ndt.CMND);
            cmd.Parameters.AddWithValue("@GioiTinh", ndt.gioiTinh);
            cmd.Parameters.AddWithValue("@Email", ndt.email);
            cmd.Parameters.AddWithValue("@MaTK", ndt.maTK);
            cmd.Parameters.AddWithValue("@MaNH", ndt.nganHang);
            cmd.Parameters.AddWithValue("@SoTien", ndt.soTien);

            cmd.CommandType = CommandType.StoredProcedure;

            // kiểm tra SqlConnection
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }

            int count = cmd.ExecuteNonQuery();
            cnn.Close();
            return (count > 0);
        }
    }
}
