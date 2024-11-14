using StationeryManagementSystem.DAO;
using StationeryManagementSystem.GUI;
using StationeryManagementSystem.Model;
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
    public partial class FormHoaDonBan : Form
    {
        public FormHoaDonBan()
        {
            InitializeComponent();
        }

        private void FormHoaDonBan_Load(object sender, EventArgs e)
        {
            try
            {
                dpNgayThanhToan.Value = DateTime.Today;
                dpStart.Value = DateTime.Today;
                dpEnd.Value = DateTime.Today;
                gvHD.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                gvHD.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";

                gvHD.DataSource = HoaDonBanDAO.findAll();

                cbMaKH.DataSource = KhachHangDAO.findAll();
                cbMaKH.DisplayMember = "Mã KH";
                cbMaKH.ValueMember = "Mã KH";
                cbMaKH.SelectedIndex = -1;
                if (!string.IsNullOrEmpty(Session.EmployeeID))
                {
                    cbMaNV.DataSource = NhanVienDAO.findAll();
                    cbMaNV.DisplayMember = "MaNhanVien";
                    cbMaNV.ValueMember = "MaNhanVien";

                    cbMaNV.SelectedValue = Session.EmployeeID;
                    cbMaNV.Enabled = false;
                }
                else
                {
                    cbMaNV.DataSource = NhanVienDAO.findAll();
                    cbMaNV.DisplayMember = "MaNhanVien";
                    cbMaNV.ValueMember = "MaNhanVien";
                    cbMaNV.SelectedIndex = -1;
                }
                cbTrangThaiThanhToan.DataSource = new List<string> { "Chưa thanh toán", "Đã thanh toán" };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Chọn hóa đơn cần thêm sp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormThemSanPhamVaoHDB formThemSanPhamVaoHDB = new FormThemSanPhamVaoHDB(int.Parse(txtMaHD.Text));
            formThemSanPhamVaoHDB.ShowDialog();
        }

        private void btnReloadSP_Click(object sender, EventArgs e)
        {
            try
            {
                int maHD = int.Parse(txtMaHD.Text);
                gvSP.DataSource = ChiTietHDBDAO.findAllByMaHD(maHD);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chọn hóa đơn để xem sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (gvSP.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu sản phẩm để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maHD = int.Parse(txtMaHD.Text);
            int maSP = int.Parse(gvSP.CurrentRow.Cells[0].Value.ToString());
            FormThemSanPhamVaoHDB formThemSanPhamVaoHDB = new FormThemSanPhamVaoHDB(int.Parse(txtMaHD.Text), true, maSP);
            formThemSanPhamVaoHDB.ShowDialog();
        }

        private void btnTaoLap_Click(object sender, EventArgs e)
        {

            int maKH = int.Parse(cbMaKH.SelectedValue.ToString());
            int maNV = int.Parse(cbMaNV.SelectedValue.ToString());
            try
            {
                HoaDonBanDAO.insert(maNV, maKH);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvHD.DataSource = HoaDonBanDAO.findAll();
                btnReload_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            FormHoaDonBan_Load(sender, e);
            txtMaHD.Text = "";
            txtTenNV.Text = "";
            txtTenKH.Text = "";
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
                    HoaDonBanDAO.update(maHD, trangThai);
                    MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gvHD.DataSource = HoaDonBanDAO.findAll();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Chọn hóa đơn để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void pbSearch_Click(object sender, EventArgs e)
        {
            DateTime dps = dpStart.Value;
            DateTime dpe = dpEnd.Value;
            try
            {
                gvHD.DataSource = CommonDAO.searchHoaDon(dps, dpe, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    CommonDAO.deleteRecord("HoaDonBan", "MaHoaDonBan", maHD);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void gvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var selectedRow = gvHD.SelectedRows[0];
            if (selectedRow.IsNewRow || string.IsNullOrWhiteSpace(selectedRow.Cells["maHD"].Value?.ToString()))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu hợp lệ để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int maHD = int.Parse(gvHD.CurrentRow.Cells["maHD"].Value.ToString());
                txtMaHD.Text = maHD.ToString();
                cbMaKH.SelectedValue = gvHD.CurrentRow.Cells["maKH"].Value.ToString();
                cbMaNV.SelectedValue = gvHD.CurrentRow.Cells["maNV"].Value.ToString();
                txtTongTien.Text = gvHD.CurrentRow.Cells["giaTri"].Value.ToString();
                txtTenKH.Text = gvHD.CurrentRow.Cells["tenKH"].Value.ToString();
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
                try { 
                gvSP.DataSource = ChiTietHDBDAO.findAllByMaHD(maHD);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            gvSP.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gvSP.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

            try
            {
                int maSP = int.Parse(gvSP.CurrentRow.Cells[0].Value.ToString());

                ChiTietHDBDAO.delete(maHD, maSP);

                gvSP.DataSource = ChiTietHDBDAO.findAllByMaHD(maHD);

                MessageBox.Show("Xóa sản phẩm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}