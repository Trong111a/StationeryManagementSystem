using StationeryManagementSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StationeryManagementSystem.GUI
{
    public partial class FormDoanhThu : Form
    {
        public FormDoanhThu()
        {
            InitializeComponent();
        }

        private void FormDoanhThu_Load(object sender, EventArgs e)
        {
            dpLoc.Value = DateTime.Today;
            dpLoc.Format = DateTimePickerFormat.Custom;
            dpLoc.CustomFormat = "MM/yyyy";
            dpLoc.ShowUpDown = true;

            chartChiPhi.BorderlineDashStyle = ChartDashStyle.NotSet;
            chartChiPhi.BackColor = SystemColors.Control;
            chartChiPhi.ChartAreas[0].BackColor = SystemColors.Control;
            chartChiPhi.Legends[0].BackColor = System.Drawing.Color.LightYellow;

            chartDoanhThu.BorderlineDashStyle = ChartDashStyle.NotSet;
            chartDoanhThu.BackColor = SystemColors.Control;
            chartDoanhThu.ChartAreas[0].BackColor = SystemColors.Control;
            chartDoanhThu.Legends[0].BackColor = System.Drawing.Color.LightYellow;


            chartChiPhi.GetToolTipText += ChartChiPhi_GetToolTipText;
            chartDoanhThu.GetToolTipText += ChartLoiNhuan_GetToolTipText;


            LoadData();
        }

        private void LoadData()
        {
            try
            {
                int month = dpLoc.Value.Month;
                int year = dpLoc.Value.Year;

                decimal tongChiTieu = ChiPhiDAO.TongChiPhi(month, year);
                decimal tongDoanhThu = DoanhThuDAO.TongDoanhThu(month, year);
                decimal tongLuong = LuongDAO.TongLuongTrongThang(month, year);
                decimal tongNhapHang = tongChiTieu - tongLuong;

                txtChiTieu.Text = tongChiTieu.ToString();
                txtDoanhThu.Text = tongDoanhThu.ToString();
                txtDT.Text = tongDoanhThu.ToString();
                txtNhapHang.Text = tongNhapHang.ToString();
                txtTraLuong.Text = tongLuong.ToString();
                txtLoiNhuan.Text = (tongDoanhThu - tongChiTieu).ToString();

                // Cập nhật biểu đồ chi phí
                Series seriesChiPhi = chartChiPhi.Series["ChiPhi"];
                seriesChiPhi.Points.Clear();

                DataPoint pointNhapHang = new DataPoint();
                pointNhapHang.YValues = new double[] { (double)tongNhapHang };
                pointNhapHang.LegendText = "Nhập hàng";
                seriesChiPhi.Points.Add(pointNhapHang);

                DataPoint pointLuong = new DataPoint();
                pointLuong.YValues = new double[] { (double)tongLuong };
                pointLuong.LegendText = "Lương nhân viên";
                seriesChiPhi.Points.Add(pointLuong);

                // Cập nhật biểu đồ doanh thu
                Series seriesDoanhThu = chartDoanhThu.Series["DoanhThu"];
                seriesDoanhThu.Points.Clear();

                DataPoint pointDoanhThu = new DataPoint();
                pointDoanhThu.YValues = new double[] { (double)tongDoanhThu };
                pointDoanhThu.LegendText = "Doanh thu";
                seriesDoanhThu.Points.Add(pointDoanhThu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChartChiPhi_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            // Lấy điểm được hover
            var result = chartChiPhi.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // Lấy phần trăm và hiển thị trong tooltip
                var point = result.Series.Points[result.PointIndex];
                double total = chartChiPhi.Series["ChiPhi"].Points.Sum(p => p.YValues[0]);
                double percent = (point.YValues[0] / total) * 100;
                e.Text = $"{percent:0.##}%"; // Định dạng phần trăm
            }
        }

        private void ChartLoiNhuan_GetToolTipText(object sender, ToolTipEventArgs e)
        {
           
            var result = chartDoanhThu.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                
                var point = result.Series.Points[result.PointIndex];
                double total = chartDoanhThu.Series["DoanhThu"].Points.Sum(p => p.YValues[0]);
                double percent = (point.YValues[0] / total) * 100;
                e.Text = $"{percent:0.##}%"; 
            }
        }

        private void lblChiTietNhapHang_Click(object sender, EventArgs e)
        {
            int month = dpLoc.Value.Month;
            int year = dpLoc.Value.Year;
            FormChiTietNhapHang formChiTietNhapHang = new FormChiTietNhapHang(month, year);
            formChiTietNhapHang.Show();
        }

        private void lblChiTietLuong_Click(object sender, EventArgs e)
        {
            int month = dpLoc.Value.Month;
            int year = dpLoc.Value.Year;
            FormChiTietLuong formChiTietLuong = new FormChiTietLuong(month, year);
            formChiTietLuong.Show();
        }

        private void lblChiTietDoanhThu_Click(object sender, EventArgs e)
        {
            int month = dpLoc.Value.Month;
            int year = dpLoc.Value.Year;
            FormChiTietDoanhThu formChiTietDoanhThu = new FormChiTietDoanhThu(month, year);
            formChiTietDoanhThu.Show();
        }

        private void dpLoc_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
