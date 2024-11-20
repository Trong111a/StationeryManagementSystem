using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    public class DatabaseHelper
    {
        

        public DataTable GetRevenueData()
        {
            using (SqlCommand cmd = new SqlCommand("select * from DoanhThuThang", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }
        
        public List<RevenueData> ConvertToRevenueList(DataTable dataTable)
        {
            var list = new List<RevenueData>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(new RevenueData
                {
                    Year = Convert.ToSingle(row["year"]),   // Chuyển từ int sang float
                    Month = Convert.ToSingle(row["month"]), // Chuyển từ int sang float
                    Revenue = Convert.ToSingle(row["revenue"]) // Chuyển từ int sang float
                });
            }
            return list;
        }
    }
}
