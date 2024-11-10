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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                gvKH.DataSource = KhachHangDAO.findAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LamTrongField()
        {
            txtMaKH.Text = "";
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LamTrongField();
            try
            {
                gvKH.DataSource = KhachHangDAO.findAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvKH.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = gvKH.SelectedRows[0];

            if (selectedRow.IsNewRow || string.IsNullOrWhiteSpace(selectedRow.Cells["maKH"].Value?.ToString()))
            {
                MessageBox.Show("Dòng được chọn không hợp lệ. Vui lòng chọn một dòng dữ liệu hợp lệ để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int maKH = int.Parse(txtMaKH.Text);
                string hoTen = txtHoTen.Text;
                string diaChi = txtDiaChi.Text;
                string sdt = txtSDT.Text;
                KhachHangDAO.update(maKH, hoTen, diaChi, sdt);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Chọn khách hàng để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String hoTen = txtHoTen.Text;
            String diaChi = txtDiaChi.Text;
            String sdt = txtSDT.Text;
            try
            {
                KhachHangDAO.insert(hoTen, diaChi, sdt);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvKH.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    int maKH = int.Parse(txtMaKH.Text);
                    CommonDAO.deleteRecord("KhachHang", "MaKhachHang", maKH);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Chọn sản khách hàng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gvKH.DataSource = CommonDAO.search("KhachHang", txtSearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvKH_Click(object sender, EventArgs e)
        {
            var selectedRow = gvKH.SelectedRows[0];
            if (selectedRow.IsNewRow || string.IsNullOrWhiteSpace(selectedRow.Cells["maKH"].Value?.ToString()))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu hợp lệ để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int maKH = int.Parse(gvKH.CurrentRow.Cells["maKH"].Value.ToString());
                txtMaKH.Text = maKH.ToString();
                txtHoTen.Text = gvKH.CurrentRow.Cells["tenKH"].Value.ToString();
                txtDiaChi.Text = gvKH.CurrentRow.Cells["diaChi"].Value.ToString();
                txtSDT.Text = gvKH.CurrentRow.Cells["soDienThoai"].Value.ToString();
            }
        }
    }
}
