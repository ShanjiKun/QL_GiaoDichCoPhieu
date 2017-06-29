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
            // tạo kết nối đến CSDL           
            SqlConnection cnn = new SqlConnection(Program.datasetConnectionString);
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

        public static SqlDataReader getDSCP(string MaNDT)
        {       
            SqlConnection cnn = new SqlConnection(Program.datasetConnectionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_SDCP", cnn);
            cmd.Parameters.AddWithValue("@MaNDT", MaNDT);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        public static SqlDataReader getAvailableMoney(string MaTK)
        {
            SqlConnection cnn = new SqlConnection(Program.datasetConnectionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_AVAILABLEMONEY", cnn);
            cmd.Parameters.AddWithValue("@MaTK", MaTK);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }

        public static int checkMaNDT(string MaNDT)
        {
            SqlConnection cnn = new SqlConnection(Program.datasetConnectionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_CHECK_MANDT", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNDT", MaNDT);
            var returnParameter = cmd.Parameters.Add("@Returns", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            return (int)returnParameter.Value;
        }

        public static int checkMaTK(string MaTK)
        {
            SqlConnection cnn = new SqlConnection(Program.datasetConnectionString);
            if (cnn.State == ConnectionState.Closed)
                cnn.Open();
            SqlCommand cmd = new SqlCommand("SP_CHECK_MATK", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaTK", MaTK);
            var returnParameter = cmd.Parameters.Add("@Returns", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            return (int)returnParameter.Value;
        }

        public static bool addDB(addNDT ndt)
        {
            SqlConnection cnn = new SqlConnection(Program.datasetConnectionString);

            SqlCommand cmd = new SqlCommand("SP_CREATENDT", cnn);

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
            int count = 0;
            try
            {
                count = cmd.ExecuteNonQuery();
                return (count > 0);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            cnn.Close();
            return (count>0);
        }

        public static int ExecQueryString(string query)
        {
            SqlConnection cnn = new SqlConnection(Program.datasetConnectionString);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            SqlCommand cmd = new SqlCommand(query, cnn);
            int count = cmd.ExecuteNonQuery();
            return count;
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            SqlConnection cnn = new SqlConnection(Program.datasetConnectionString);
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            // đối tượng trung gian để lấy cơ sở dữ liệu
            SqlDataAdapter da = new SqlDataAdapter(cmd, cnn);
            // cmd là câu lệnh exec SP, cnn là SqlConnection
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
