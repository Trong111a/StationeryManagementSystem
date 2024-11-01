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
    public partial class FormHoaDonNhap : Form
    {
        public FormHoaDonNhap()
        {
            InitializeComponent();
        }

        private void FormHoaDonNhap_Load(object sender, EventArgs e)
        {
            dpNgayThanhToan.Value = DateTime.Today;
            dpStart.Value = DateTime.Today;
            dpEnd.Value = DateTime.Today;
            dpNgayThanhToan.Value = DateTime.Today;
            gvHD.DataSource = HoaDonNhapDAO.findAll();
            //style date dd/mm/yyyy col1,8
            gvHD.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            gvHD.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";


            cbMaNCC.DataSource = NhaCungCapDAO.findAll();
            cbMaNCC.DisplayMember = "Mã NCC";
            cbMaNCC.ValueMember = "Mã NCC";
            cbMaNCC.SelectedIndex = -1;

            cbMaNV.DataSource = NhanVienDAO.findAll();
            cbMaNV.DisplayMember = "MaNhanVien";
            cbMaNV.ValueMember = "MaNhanVien";
            cbMaNV.SelectedIndex = -1;
            cbTrangThaiThanhToan.DataSource = new List<string> { "Chưa thanh toán", "Đã thanh toán" };
        }

        private void btnTaoLap_Click(object sender, EventArgs e)
        {
            try
            {
                int maNcc = int.Parse(cbMaNCC.SelectedValue.ToString());
                int maNV = int.Parse(cbMaNV.SelectedValue.ToString());
                try
                {
                    HoaDonNhapDAO.insert(maNV, maNcc);
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gvHD.DataSource = HoaDonNhapDAO.findAll();
                    btnReload_Click(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn nhà cung cấp và nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            FormHoaDonNhap_Load(sender, e);
            txtMaHD.Text = "";
            txtTenNV.Text = "";
            txtTenNCC.Text = "";
            dpNgayThanhToan.Enabled = true;
            dpNgayThanhToan.Value = DateTime.Today;
            lblTongTien.Visible = false;
            txtTongTien.Visible = false;
            cbTrangThaiThanhToan.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvHD.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu hóa đơn để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    int maHD = int.Parse(txtMaHD.Text);
                    string trangThai = cbTrangThaiThanhToan.Text;
                    HoaDonNhapDAO.update(maHD, trangThai);
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gvHD.DataSource = HoaDonNhapDAO.findAll();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Chọn sản hóa đơn để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pbSeach_Click(object sender, EventArgs e)
        {
            DateTime dps = dpStart.Value;
            DateTime dpe = dpEnd.Value;

            gvHD.DataSource = CommonDAO.searchHoaDon(dps, dpe, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvHD.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu hóa đơn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    int maHD = int.Parse(txtMaHD.Text);
                    CommonDAO.deleteRecord("HoaDonNhap", "MaHoaDonNhap", maHD); 
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Chọn hóa đơn để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvHD.SelectedRows.Count <= 0)
            {
                return;
            }
            var selectedRow = gvHD.SelectedRows[0];
            if (selectedRow.IsNewRow || string.IsNullOrWhiteSpace(selectedRow.Cells["maHD"].Value?.ToString()))
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu hợp lệ để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int maHD = int.Parse(gvHD.CurrentRow.Cells["maHD"].Value.ToString());
                txtMaHD.Text = maHD.ToString();
                cbMaNCC.SelectedValue = gvHD.CurrentRow.Cells["maNCC"].Value.ToString();
                cbMaNV.SelectedValue = gvHD.CurrentRow.Cells["maNV"].Value.ToString();
                txtTongTien.Text = gvHD.CurrentRow.Cells["giaTri"].Value.ToString();
                txtTenNCC.Text = gvHD.CurrentRow.Cells["tenNCC"].Value.ToString();
                txtTenNV.Text = gvHD.CurrentRow.Cells["tenNV"].Value.ToString();
                cbTrangThaiThanhToan.Text = gvHD.CurrentRow.Cells["trangThaiThanhToan"].Value.ToString();
                if (gvHD.CurrentRow.Cells["ngayThanhToan"].Value is DBNull)
                {
                    dpNgayThanhToan.Enabled = true;
                }
                else
                {
                    dpNgayThanhToan.Enabled = false;
                }

                if (gvHD.CurrentRow.Cells["trangThaiThanhToan"].Value.ToString() == "Đã thanh toán")
                {
                    cbTrangThaiThanhToan.Enabled = false;
                    txtTongTien.Enabled = false;
                    lblTongTien.Visible = true;
                    txtTongTien.Visible = true;
                }
                else
                {
                    cbTrangThaiThanhToan.Enabled = true;
                    txtTongTien.Enabled = true;
                    lblTongTien.Visible = false;
                    txtTongTien.Visible = false;
                }

                gvSP.DataSource = ChiTietHDNDAO.findAllByMaHD(maHD);
            }
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvSP.DataSource = null;
            
        }

        private void cbMaNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvSP.DataSource = null;
          
        }

        private void btnReloadSP_Click(object sender, EventArgs e)
        {
            int maHD = int.Parse(txtMaHD.Text);
            gvSP.DataSource = ChiTietHDNDAO.findAllByMaHD(maHD);
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Chọn hóa đơn cần thêm sp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormThemSanPhamVaoHDN formThemSanPhamVaoHDN = new FormThemSanPhamVaoHDN(int.Parse(txtMaHD.Text), int.Parse(cbMaNCC.Text));
            formThemSanPhamVaoHDN.ShowDialog();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {

            if (gvSP.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maHD = int.Parse(txtMaHD.Text);
            int maNCC = int.Parse(cbMaNCC.Text);
            int maSP = int.Parse(gvSP.CurrentRow.Cells[0].Value.ToString());
            FormThemSanPhamVaoHDN formThemSanPhamVaoHDN = new FormThemSanPhamVaoHDN(int.Parse(txtMaHD.Text), true, maSP, maNCC);
            formThemSanPhamVaoHDN.ShowDialog();
        }

        private void gvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvSP.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng dữ liệu hợp lệ để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            if (gvSP.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maHD = int.Parse(txtMaHD.Text);
            string trangThaiThanhToan = gvHD.CurrentRow.Cells["trangThaiThanhToan"].Value.ToString();

            if (trangThaiThanhToan == "Đã thanh toán")
            {
                MessageBox.Show("Không thể xóa sản phẩm khỏi hóa đơn đã thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int maSP = int.Parse(gvSP.CurrentRow.Cells[0].Value.ToString());

                ChiTietHDNDAO.delete(maHD, maSP);

                gvSP.DataSource = ChiTietHDNDAO.findAllByMaHD(maHD);

                MessageBox.Show("Xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
