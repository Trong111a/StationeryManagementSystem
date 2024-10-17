﻿using Guna.UI2.WinForms;
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
        private void FormSanPham_Load(object sender, EventArgs e)
        {
            gvSP.DataSource = SanPhamDAO.findAll();
            dataGridView1.DataSource = SanPhamDAO.getXemSoLuongSanPhamDaBanTrongNgay(DateTime.Now);
            cbMaLoai.DataSource = LoaiSanPhamDAO.findAll();
            cbMaLoai.DisplayMember = "MaLoaiSanPham";
            cbMaLoai.ValueMember = "TenLoaiSanPham";
            cbMaLoai.SelectedIndex = -1;
            txtTenLoai.Enabled = false;
            cbMaNCC.DataSource = NhaCungCapDAO.findAll();
            cbMaNCC.DisplayMember = "Mã NCC";
            cbMaNCC.SelectedIndex = -1;
            cbMaNCC.ValueMember = "Mã NCC";
        }

        private void gvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvSP_Click(object sender, EventArgs e)
        {
            //display
            txtMaSP.Text = gvSP.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = gvSP.CurrentRow.Cells[1].Value.ToString();
            txtTenLoai.Text = gvSP.CurrentRow.Cells[2].Value.ToString();
            if (gvSP.CurrentRow.Cells[3].Value is DBNull)
            {
                cbMaLoai.SelectedIndex = -1;
            }
            else
            {
                cbMaLoai.SelectedValue = gvSP.CurrentRow.Cells[3].Value.ToString();
            }

            if (gvSP.CurrentRow.Cells[5].Value is DBNull)
            {
                cbMaNCC.SelectedIndex = -1;
            }
            else
            {
                cbMaNCC.SelectedValue = gvSP.CurrentRow.Cells[4].Value.ToString();
            }
            txtGiaNhap.Text = gvSP.CurrentRow.Cells[6].Value.ToString();
            
            txtGiaBan.Text = gvSP.CurrentRow.Cells[7].Value.ToString();
            txtSoLuong.Text = gvSP.CurrentRow.Cells[8].Value.ToString();
          


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

        private void btnThem_Click(object sender, EventArgs e)
        {
            //if (gvSP.CurrentRow == null || gvSP.CurrentRow.Cells[0].Value == null)
            //{
            //    return;
            //}

            //string tenLoai = gvSP.CurrentRow.Cells[3].Value?.ToString() ?? string.Empty;
            //string maLoai = gvSP.CurrentRow.Cells[2].Value?.ToString() ?? string.Empty;

            //string tenNCC = gvSP.CurrentRow.Cells[5].Value?.ToString() ?? string.Empty;
            //int maNCC = int.Parse(gvSP.CurrentRow.Cells[4].Value?.ToString() ?? "0");
            //if (maNCC == 0)
            //{
            //    MessageBox.Show("Vui lòng chọn nhà cung cấp");
            //    return;
            //}
            //cbMaNCC.Text = maNCC.ToString();
            //txtMaSP.Text = gvSP.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
            //txtTenSP.Text = gvSP.CurrentRow.Cells[1].Value?.ToString() ?? string.Empty;
            //txtTenLoai.Text = gvSP.CurrentRow.Cells[3].Value?.ToString() ?? string.Empty;
            //txtGiaNhap.Text = gvSP.CurrentRow.Cells[6].Value?.ToString() ?? string.Empty;
            //txtGiaBan.Text = gvSP.CurrentRow.Cells[7].Value?.ToString() ?? string.Empty;
            //txtSoLuong.Text = gvSP.CurrentRow.Cells[8].Value?.ToString() ?? string.Empty;

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

        private void gbListSP_Click(object sender, EventArgs e)
        {
            


        }

        private void txtSearh_TextChanged(object sender, EventArgs e)
        {
            if (txtSearh.Text == "")
            {
                gvSP.DataSource = SanPhamDAO.findAll();
                return;
            }
            String input = txtSearh.Text;
            int maSP;
            DataTable dt = (DataTable)gvSP.DataSource;
            bool isNumber = int.TryParse(input, out maSP);  // Chuyển đổi chuỗi thành số (nếu có thể)

            if (isNumber)
            {
                // Nếu input là số, sử dụng bộ lọc cho Mã SP là số và các cột khác là chuỗi
                dt.DefaultView.RowFilter = "[Mã SP] = " + maSP +
                                           " OR [Tên SP] LIKE '%" + input + "%' " +
                                           " OR [Tên Loại SP] LIKE '%" + input + "%' " +
                                           " OR [Tên NCC] LIKE '%" + input + "%'";
            }
            else
            {
                // Nếu input không phải là số, chỉ áp dụng bộ lọc cho các cột chuỗi
                dt.DefaultView.RowFilter = "[Tên SP] LIKE '%" + input + "%' " +
                                           " OR [Tên Loại SP] LIKE '%" + input + "%' " +
                                           " OR [Tên NCC] LIKE '%" + input + "%'";
            }

            gvSP.DataSource = dt;
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SanPhamDAO.getXemSoLuongSanPhamDaBanTrongNgay(dpsáchBan.Value);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(txtMaSP.Text);
            string tenSP = txtTenSP.Text;
            float giaNhap = float.Parse(txtGiaNhap.Text);
            float giaBan = float.Parse(txtGiaBan.Text);
            int maLoai = int.Parse(cbMaLoai.Text);
            int soLuong = int.Parse(txtSoLuong.Text);
            try
            {
                SanPhamDAO.update(maSP, tenSP, giaNhap, giaBan, maLoai, soLuong);
                gvSP.DataSource = SanPhamDAO.findAll();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
      
}
