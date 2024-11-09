using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    public class AuthenticationDAO
    {
        public static string myAuthenticateUser(string username, string password)
        {
            MyDB.OpenConnection();
            string sql = "exec spAuthenticateUser @Username, @Password";
            SqlCommand cmd = new SqlCommand(sql, MyDB.GetConnection);
            cmd.Parameters.AddWithValue("@Username", SqlDbType.NVarChar).Value = username;
            cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string manhanvien  = reader["Role"].ToString();
                return manhanvien;
            }
            else
            {
                return null; // Trả về null nếu thông tin đăng nhập không đúng
            }

            MyDB.CloseConnection();

            return null;
        }
    }
}
