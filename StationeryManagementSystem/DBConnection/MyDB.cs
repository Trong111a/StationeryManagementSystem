using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace StationeryManagementSystem.DAO
{
    public class MyDB
    {
        static String connAdmin= @"Data Source=TuoiTho\SQLEXPRESS;Initial Catalog=StationeryManagementSystem;User Id=sa; Password=123456;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True";
        static String connString = null;
        static SqlConnection conn= null;
        //static SqlConnection conn = new SqlConnection(@"Server=localhost,1433;Database=StationeryManagementSystem;User Id=sa;Password=123456;");

        //static SqlConnection conn = new SqlConnection(@"Data Source= ;Initial Catalog=QuanLyVanPhongPham;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True");
        public static void setConection(String username, String password) => connString = @"Data Source=TuoiTho\SQLEXPRESS;Initial Catalog=StationeryManagementSystem;User Id=" + username + "; Password=" + password + ";Connect Timeout=30;Encrypt=True;TrustServerCertificate=True";

        public static SqlConnection GetConnection
        {
            get
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connString);
                }
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
        //get,set 
        public static String ConnString { get => connString; set => connString = value; }
        public static String ConnAdmin { get => connAdmin; set => connAdmin = value; }
        public static SqlConnection Conn { get => conn; set => conn = value; }
    }
}
