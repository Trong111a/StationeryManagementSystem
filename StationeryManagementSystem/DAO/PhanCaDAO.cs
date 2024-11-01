using StationeryManagementSystem.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StationeryManagementSystem.GUI
{
    internal class PhanCaDAO
    {
        public static DataTable findAll()
        {
            using (SqlCommand cmd = new SqlCommand("select * from PhanCa", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }

        public static DataTable findAll(DateTime date)
        {
            using (SqlCommand cmd = new SqlCommand("select * from PhanCa where Ngay=@date", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@date", SqlDbType.Date).Value = date;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }

        }


        public static void phanCa(DateTime start, DateTime end)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_PhanCaChoNhanVien @start, @end", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@start", SqlDbType.Date).Value = start;
                cmd.Parameters.AddWithValue("@end", SqlDbType.Date).Value = end;
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }

        }

        internal static void checkIn(int manv, int maca, DateTime ngay, DateTime moctime)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_CheckIn @manv, @maca, @ngay, @moctime", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@manv", SqlDbType.Int).Value = manv;
                cmd.Parameters.AddWithValue("@maca", SqlDbType.Int).Value = maca;
                cmd.Parameters.AddWithValue("@ngay", SqlDbType.Date).Value = ngay;
                cmd.Parameters.AddWithValue("@moctime", SqlDbType.Time).Value = moctime;
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }
        }

        internal static void checkout(int manv, int maca, DateTime ngay, DateTime moctime)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_CheckOut @manv, @maca, @ngay, @moctime", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@manv", SqlDbType.Int).Value = manv;
                cmd.Parameters.AddWithValue("@maca", SqlDbType.Int).Value = maca;
                cmd.Parameters.AddWithValue("@ngay", SqlDbType.Date).Value = ngay;
                // ko lay giay
                moctime = moctime.AddSeconds(-moctime.Second);
                cmd.Parameters.AddWithValue("@moctime", SqlDbType.Time).Value = moctime;
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }
        }

        internal static void dangKiCa3(int manv, DateTime ngayca3)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_DangKiCaLamThem @manv, @ngayca3", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@manv", SqlDbType.Int).Value = manv;
                cmd.Parameters.AddWithValue("@ngayca3", SqlDbType.Date).Value = ngayca3;
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }
        }
    }
}
