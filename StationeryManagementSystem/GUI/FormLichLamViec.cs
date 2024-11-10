using StationeryManagementSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryManagementSystem.GUI
{
    public partial class FormLichLamViec : Form
    {
        public FormLichLamViec()
        {
            InitializeComponent();
        }

        private void FormLichLamViec_Load(object sender, EventArgs e)
        {
            try
            {
                dpStart.Value = DateTime.Today;
                dpEnd.Value = DateTime.Today;
                dpHienThi.Value = DateTime.Today;
                dpCa3.Value = DateTime.Today;
                dpNgayLuong.Value = DateTime.Today;
                gvPhanCa.DataSource = PhanCaDAO.findAll(DateTime.Today);
                gvPhanCa.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
                cbMaNV.DataSource = NhanVienDAO.findAll();
                cbMaNV.DisplayMember = "MaNhanVien";
                cbMaNV.ValueMember = "MaNhanVien";
                cbMaNV.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPhanCa_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = dpStart.Value;
                DateTime end = dpEnd.Value;
                try
                {
                    PhanCaDAO.phanCa(start, end);
                    MessageBox.Show("Phân ca thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(gvPhanCa.CurrentRow.Cells[0].Value.ToString());
            int maca = int.Parse(gvPhanCa.CurrentRow.Cells[1].Value.ToString());
            DateTime ngay = DateTime.Parse(gvPhanCa.CurrentRow.Cells[2].Value.ToString());
            DateTime moctime = dp_moctime.Value;
            try
            {
                PhanCaDAO.checkIn(manv, maca, ngay, moctime);
                MessageBox.Show("Check in thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(gvPhanCa.CurrentRow.Cells[0].Value.ToString());
            int maca = int.Parse(gvPhanCa.CurrentRow.Cells[1].Value.ToString());
            DateTime ngay = DateTime.Parse(gvPhanCa.CurrentRow.Cells[2].Value.ToString());
            DateTime moctime = dp_moctime.Value;
            try
            {
                PhanCaDAO.checkout(manv, maca, ngay, moctime);
                MessageBox.Show("Check out thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                gvPhanCa.DataSource = PhanCaDAO.findAll(dpHienThi.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                gvPhanCa.DataSource = PhanCaDAO.findAll(dpHienThi.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbSearchLuong_Click(object sender, EventArgs e)
        {
            try
            {
                gvLuong.DataSource = LuongDAO.LuongTrongNgay(dpNgayLuong.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbSearchLuong_MouseEnter(object sender, EventArgs e)
        {
            pbSearchLuong.Size = new Size(pbSearchLuong.Width + 10, pbSearchLuong.Height + 10);
            pbSearchLuong.Location = new Point(pbSearchLuong.Location.X - 5, pbSearchLuong.Location.Y - 5);
        }

        private void pbSearchLuong_MouseLeave(object sender, EventArgs e)
        {
            pbSearchLuong.Size = new Size(pbSearchLuong.Width - 10, pbSearchLuong.Height - 10);
            pbSearchLuong.Location = new Point(pbSearchLuong.Location.X + 5, pbSearchLuong.Location.Y + 5);
        }

        private void btnDKCa3_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(cbMaNV.Text);
            DateTime ngayca3 = dpCa3.Value;
            try
            {
                PhanCaDAO.dangKiCa3(manv, ngayca3);
                MessageBox.Show("Đăng kí ca 3 thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
