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

namespace StationeryManagementSystem
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                gvNhanVien.DataSource = NhanVienDAO.findAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LamTrongField();
            try
            {
                gvNhanVien.DataSource = NhanVienDAO.findAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvNhanVien.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = gvNhanVien.SelectedRows[0];

            if (selectedRow.IsNewRow || string.IsNullOrWhiteSpace(selectedRow.Cells["maNV"].Value?.ToString()))
            {
                MessageBox.Show("Dòng được chọn không hợp lệ. Vui lòng chọn một dòng dữ liệu hợp lệ để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNV = int.Parse(selectedRow.Cells["maNV"].Value.ToString());
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh = dpNgaySinh.Value;
            string gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            string diaChi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            int chucVu = rdBanHang.Checked ? 1 : (rdKiemKho.Checked ? 2 : 0);
            if (chucVu == 0)
            {
                MessageBox.Show("Vui lòng chọn chức vụ cho nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                NhanVienDAO.update(maNV, hoTen, ngaySinh, gioiTinh, diaChi, sdt, email, chucVu);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String hoTen = txtHoTen.Text;
            DateTime ngaySinh = dpNgaySinh.Value;
            String gioiTinh = "";
            if (rdNam.Checked)
            {
                gioiTinh = "Nam";
            }
            if (rdNu.Checked)
            {
                gioiTinh = "Nữ";
            }

            String diaChi = txtDiaChi.Text;
            String sdt = txtSDT.Text;
            String email = txtEmail.Text;
            int chucVu = 0;
            if (rdBanHang.Checked)
            {
                chucVu = 1;
            }
            if (rdKiemKho.Checked)
            {
                chucVu = 2;
            }


            try
            {
                NhanVienDAO.insert(hoTen, ngaySinh, gioiTinh, diaChi, sdt, email, chucVu);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            var selectedRow = gvNhanVien.SelectedRows[0];
            if (selectedRow.IsNewRow || string.IsNullOrWhiteSpace(selectedRow.Cells["maNV"].Value?.ToString()))
            {
                MessageBox.Show("Dòng được chọn không hợp lệ. Vui lòng chọn dòng dữ liệu hợp lệ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNV = int.Parse(txtMaNV.Text);
            try
            {
                CommonDAO.deleteRecord("NhanVien", "MaNhanVien", maNV); ;
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void gvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvNhanVien.CurrentRow == null || gvNhanVien.CurrentRow.Cells[0].Value == null)
            {
                return;
            }

            txtMaNV.Text = gvNhanVien.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
            txtHoTen.Text = gvNhanVien.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;

            string ngaySinhText = gvNhanVien.CurrentRow.Cells[2].Value?.ToString();
            if (!string.IsNullOrEmpty(ngaySinhText))
            {
                DateTime ngaySinh;
                if (DateTime.TryParse(ngaySinhText, out ngaySinh))
                {
                    dpNgaySinh.Value = ngaySinh;
                }
                else
                {
                    dpNgaySinh.Value = DateTime.Today;
                }
            }
            else
            {
                dpNgaySinh.Value = DateTime.Today;
            }

            rdNam.Checked = gvNhanVien.CurrentRow.Cells[3].Value?.ToString().Equals("Nam") ?? false;
            rdNu.Checked = gvNhanVien.CurrentRow.Cells[3].Value?.ToString().Equals("Nữ") ?? false;

            txtDiaChi.Text = gvNhanVien.CurrentRow.Cells[4].Value?.ToString() ?? string.Empty;
            txtSDT.Text = gvNhanVien.CurrentRow.Cells[5].Value?.ToString() ?? string.Empty;
            txtEmail.Text = gvNhanVien.CurrentRow.Cells[6].Value?.ToString() ?? string.Empty;

            rdBanHang.Checked = gvNhanVien.CurrentRow.Cells[7].Value?.ToString().Contains("án") ?? false;
            rdKiemKho.Checked = gvNhanVien.CurrentRow.Cells[7].Value?.ToString().Contains("ho") ?? false;

            txtLuong.Text = gvNhanVien.CurrentRow.Cells[8].Value?.ToString() ?? string.Empty;
        }

        private void LamTrongField()
        {
            txtMaNV.Text = "";
            txtHoTen.Clear();
            dpNgaySinh.Value = DateTime.Today;
            rdNam.Checked = false;
            rdNu.Checked = false;
            txtDiaChi.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            rdBanHang.Checked = false;
            rdKiemKho.Checked = false;
            txtLuong.Clear();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            /*if (txtSearch.Text == "")
            {
                gvNhanVien.DataSource = NhanVienDAO.findAll();
                return;
            }
            string input = txtSearch.Text;
            int maNV;
            DataTable dt = (DataTable)gvNhanVien.DataSource;
            bool isNumber = int.TryParse(input, out maNV);  // Chuyển đổi chuỗi thành số (nếu có thể)

            if (isNumber)
            {
                // Nếu input là số, sử dụng bộ lọc cho Mã SP là số và các cột khác là chuỗi
                dt.DefaultView.RowFilter = "[manhanvien] = " + maNV +
                                           " OR [hoten] LIKE '%" + input + "%' " +
                                           " OR [TenChucVu] LIKE '%" + input + "%' ";
            }
            else
            {
                // Nếu input không phải là số, chỉ áp dụng bộ lọc cho các cột chuỗi
                dt.DefaultView.RowFilter = "[hoten] LIKE '%" + input + "%' " +
                                           " OR [TenChucVu] LIKE '%" + input + "%' ";
            }

            gvNhanVien.DataSource = dt;*/
            gvNhanVien.DataSource = CommonDAO.search("NhanVien", txtSearch.Text);
        }

        private void gvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
