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
        private string connectionString = "Data Source=DESKTOP-09KCOMQ\\SQLEXPRESS;Initial Catalog=StationeryManagementSystem;Integrated Security=True;";

        public DataTable GetRevenueData()
        {
            string query = "SELECT * FROM DoanhThuThang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
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
