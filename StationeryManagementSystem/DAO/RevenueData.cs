using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    public class RevenueData
    {
        public float Year { get; set; }  // Chuyển từ int sang float
        public float Month { get; set; } // Chuyển từ int sang float
        public float Revenue { get; set; } // Label cho doanh thu cũng cần kiểu float
    }
    public class RevenuePrediction
    {
        [ColumnName("Score")]
        public float NextMonthRevenue { get; set; }
    }
}