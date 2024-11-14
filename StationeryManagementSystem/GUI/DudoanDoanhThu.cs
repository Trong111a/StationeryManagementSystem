using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StationeryManagementSystem.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StationeryManagementSystem.GUI
{
    public partial class DudoanDoanhThu : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private ModelHelper modelHelper = new ModelHelper();
        public DudoanDoanhThu()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                cbb_month.Items.Add(i);
            }
            for (int i  = 2024; i<=2026;i++)
            {
                cbb_year.Items.Add(i);
            }    
        }

        private void DudoanDoanhThu_Load(object sender, EventArgs e)
        {
            dtg_doanhthu.DataSource = dbHelper.GetRevenueData();

        }

        private void btn_dudoan_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(cbb_year.SelectedItem.ToString());
                int month = int.Parse(cbb_month.SelectedItem.ToString());

                var dataTable = dbHelper.GetRevenueData();
                var revenueList = dbHelper.ConvertToRevenueList(dataTable);

                var model = modelHelper.TrainModel(revenueList);
                var prediction = modelHelper.PredictNextMonthRevenue(model, year, month);

                lblDoanhThuDuDoan.Text = $"Doanh thu dự đoán: {prediction:N0} VNĐ";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblDoanhThuDuDoan_Click(object sender, EventArgs e)
        {

        }
    }
}
