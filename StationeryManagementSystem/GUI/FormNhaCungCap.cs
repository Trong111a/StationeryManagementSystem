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
    public partial class FormNhaCungCap : Form
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            try
            {
                gvNhaCungCap.DataSource = NhaCungCapDAO.findAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenNhaCungCap = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSDT.Text;

            try
            {
                NhaCungCapDAO.insert(tenNhaCungCap, diaChi, soDienThoai);
                MessageBox.Show("Thêm nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtHoTen.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            txtMaNCC.Text = "";
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            try
            {
                gvNhaCungCap.DataSource = NhaCungCapDAO.findAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvNhaCungCap.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu nhà cung cấp để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = gvNhaCungCap.SelectedRows[0];

            if (selectedRow.IsNewRow || string.IsNullOrWhiteSpace(selectedRow.Cells["maNCC"].Value?.ToString()))
            {
                MessageBox.Show("Dòng được chọn không hợp lệ. Vui lòng chọn một dòng dữ liệu hợp lệ để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int maNCC = int.Parse(selectedRow.Cells["maNCC"].Value.ToString());
            string tenNhaCungCap = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSDT.Text;

            try
            {
                NhaCungCapDAO.update(maNCC, tenNhaCungCap, diaChi, soDienThoai);
                MessageBox.Show("Sửa nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvNhaCungCap.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu nhà cung cấp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var selectedRow = gvNhaCungCap.SelectedRows[0];
                if (selectedRow.IsNewRow || string.IsNullOrWhiteSpace(selectedRow.Cells["maNCC"].Value?.ToString()))
                {
                    MessageBox.Show("Dòng được chọn không hợp lệ. Vui lòng chọn dòng dữ liệu hợp lệ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maNhaCungCap = int.Parse(txtMaNCC.Text);
                try
                {
                    CommonDAO.deleteRecord("NhaCungCap", "MaNhaCungCap", maNhaCungCap);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvNhaCungCap_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (gvNhaCungCap.CurrentRow == null || gvNhaCungCap.CurrentRow.Cells[0].Value == null)
            {
                return;
            }

            txtMaNCC.Text = gvNhaCungCap.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
            txtHoTen.Text = gvNhaCungCap.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            txtDiaChi.Text = gvNhaCungCap.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;
            txtSDT.Text = gvNhaCungCap.CurrentRow.Cells[3].Value?.ToString() ?? string.Empty;
        }

        private void txtSearh_TextChanged(object sender, EventArgs e)
        {
            gvNhaCungCap.DataSource = CommonDAO.search("NhaCungCap", txtSearh.Text);
        }
    }
}
