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
        
        private ModelHelper modelHelper = new ModelHelper();
        private DatabaseHelper dbHelper = new DatabaseHelper();
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
            try
            {

                dtg_doanhthu.DataSource = dbHelper.GetRevenueData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static bool IsFutureMonthYear(int selectedMonth, int selectedYear)
        {
            // Lấy ngày hiện tại
            DateTime currentDate = DateTime.Now;

            // Tạo một DateTime từ tháng và năm đã chọn (ngày 1 của tháng đó)
            DateTime selectedDate = new DateTime(selectedYear, selectedMonth, 1);

            // Kiểm tra xem ngày đã chọn có lớn hơn ngày hiện tại không
            return selectedDate > currentDate;
        }

        private void btn_dudoan_Click(object sender, EventArgs e)
        {
            try
            {
                int year = int.Parse(cbb_year.SelectedItem.ToString());
                int month = int.Parse(cbb_month.SelectedItem.ToString());

                if (!IsFutureMonthYear(month, year))
                {
                    MessageBox.Show("Just predict the furture months!", "Warning", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    return;
                }    

                var dataTable = dbHelper.GetRevenueData();
                var revenueList = dbHelper.ConvertToRevenueList(dataTable);

                var model = modelHelper.TrainModel(revenueList);
                float prediction = modelHelper.PredictNextMonthRevenue(model, year, month);

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
