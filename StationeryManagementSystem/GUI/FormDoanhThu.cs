﻿using System;
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
            // Lấy điểm được hover
            var result = chartDoanhThu.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // Lấy phần trăm và hiển thị trong tooltip
                var point = result.Series.Points[result.PointIndex];
                double total = chartDoanhThu.Series["DoanhThu"].Points.Sum(p => p.YValues[0]);
                double percent = (point.YValues[0] / total) * 100;
                e.Text = $"{percent:0.##}%"; // Định dạng phần trăm
            }
        }

        private void lblChiTietNhapHang_Click(object sender, EventArgs e)
        {
            FormChiTietNhapHang formChiTietNhapHang = new FormChiTietNhapHang();
            formChiTietNhapHang.Show();
        }

        private void lblChiTietLuong_Click(object sender, EventArgs e)
        {
            FormChiTietLuong formChiTietLuong = new FormChiTietLuong();
            formChiTietLuong.Show();
        }

        private void lblChiTietDoanhThu_Click(object sender, EventArgs e)
        {
            FormChiTietDoanhThu formChiTietDoanhThu = new FormChiTietDoanhThu();
            formChiTietDoanhThu.Show();
        }
    }
}