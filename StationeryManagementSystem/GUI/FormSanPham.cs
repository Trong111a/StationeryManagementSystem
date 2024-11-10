using Guna.UI2.WinForms;
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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void FormSanPham_Load(object sender, EventArgs e)
        {
            try
            {
                dpSPBan.Value = DateTime.Today;
                gvSP.DataSource = SanPhamDAO.findAll();
                gvSPTrongNgay.Columns["ngayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
                gvSPTrongNgay.DataSource = SanPhamDAO.getXemSoLuongSanPhamDaBanTrongNgay(DateTime.Now);
                cbMaLoai.DataSource = LoaiSanPhamDAO.findAll();
                cbMaLoai.DisplayMember = "MaLoaiSanPham";
                cbMaLoai.ValueMember = "TenLoaiSanPham";
                cbMaLoai.SelectedIndex = -1;
                txtTenLoai.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pbSearch_MouseEnter(object sender, EventArgs e)
        {
            pbSearch.Size = new Size(pbSearch.Width + 10, pbSearch.Height + 10);
            pbSearch.Location = new Point(pbSearch.Location.X - 5, pbSearch.Location.Y - 5);
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            pbSearch.Size = new Size(pbSearch.Width - 10, pbSearch.Height - 10);
            pbSearch.Location = new Point(pbSearch.Location.X + 5, pbSearch.Location.Y + 5);
        }

        private void cbMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLoai.SelectedIndex == -1 || cbMaLoai.SelectedValue == null)
            {
                txtTenLoai.Text = "";
                return;
            }
            txtTenLoai.Text = cbMaLoai.SelectedValue.ToString();
        }


        private void gvSP_Click(object sender, EventArgs e)
        {
            if (gvSP.CurrentRow != null)
            {
                txtMaSP.Text = gvSP.CurrentRow.Cells["maSP"].Value?.ToString() ?? string.Empty;
                txtTenSP.Text = gvSP.CurrentRow.Cells["tenSP"].Value?.ToString() ?? string.Empty;
                txtTenLoai.Text = gvSP.CurrentRow.Cells["tenLoai"].Value?.ToString() ?? string.Empty;

                if (gvSP.CurrentRow.Cells["tenLoai"].Value == DBNull.Value)
                {
                    cbMaLoai.SelectedIndex = -1;
                }
                else
                {
                    cbMaLoai.SelectedValue = gvSP.CurrentRow.Cells["tenLoai"].Value.ToString();
                }


                txtMaNCC.Text = gvSP.CurrentRow.Cells["maNCC"].Value?.ToString() ?? string.Empty;
                txtTenNCC.Text = gvSP.CurrentRow.Cells["tenNCC"].Value?.ToString() ?? string.Empty;
                txtGiaNhap.Text = gvSP.CurrentRow.Cells["giaNhap"].Value?.ToString() ?? string.Empty;
                txtGiaBan.Text = gvSP.CurrentRow.Cells["giaBan"].Value?.ToString() ?? string.Empty;
                txtSoLuong.Text = gvSP.CurrentRow.Cells["soLuong"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSP.Text;
            int maLoai = int.Parse(cbMaLoai.Text);
            try
            {
                SanPhamDAO.insert(tenSP, maLoai);
                gvSP.DataSource = SanPhamDAO.findAll();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearh_TextChanged(object sender, EventArgs e)
        {
            gvSP.DataSource = CommonDAO.search("SanPham", txtSearh.Text);
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            try
            {
                gvSPTrongNgay.DataSource = SanPhamDAO.getXemSoLuongSanPhamDaBanTrongNgay(dpSPBan.Value);
                gvSPTrongNgay.Columns["ngayLap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int maSP = int.Parse(txtMaSP.Text);
                string tenSP = txtTenSP.Text;
                float giaNhap = float.Parse(txtGiaNhap.Text);
                float giaBan = float.Parse(txtGiaBan.Text);
                int maLoai = int.Parse(cbMaLoai.Text);
                int soLuong = int.Parse(txtSoLuong.Text);

                SanPhamDAO.update(maSP, tenSP, giaNhap, giaBan, maLoai, soLuong);

                gvSP.DataSource = SanPhamDAO.findAll();

                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Chọn sản phẩm để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int maSP = int.Parse(txtMaSP.Text);
                CommonDAO.deleteRecord("SanPham", "MaSanPham", maSP);
                gvSP.DataSource = SanPhamDAO.findAll();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Chọn sản phẩm để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            gvSP.DataSource = SanPhamDAO.findAll();
            txtMaSP.Text = "";
            txtTenSP.Text = "";

            cbMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtSoLuong.Text = "0";
            txtGiaNhap.Text = "0";
            txtGiaBan.Text = "0";
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
        }

        private void gvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
