using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    public class MyDB
    {
        static SqlConnection conn = new SqlConnection(@"Server=localhost,1433;Database=StationeryManagementSystem;User Id=sa;Password=123456;");

        //static SqlConnection conn = new SqlConnection(@"Data Source= ;Initial Catalog=QuanLyVanPhongPham;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True");


        public static SqlConnection GetConnection
        {
            get
            {
                return conn;
            }
        }
        public static void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public static void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
