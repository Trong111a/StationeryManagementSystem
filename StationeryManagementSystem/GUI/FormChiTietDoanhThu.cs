using StationeryManagementSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryManagementSystem.GUI
{
    public partial class FormChiTietDoanhThu : Form
    {
        private int thang;
        private int nam;
        public FormChiTietDoanhThu(int month, int year)
        {
            InitializeComponent();
            this.thang = month;
            this.nam = year;
        }

        private void FormChiTietDoanhThu_Load(object sender, EventArgs e)
        {
            try
            {
                gvDoanhThu.DataSource = HoaDonBanDAO.DoanhThuTrongThang(thang, nam);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
