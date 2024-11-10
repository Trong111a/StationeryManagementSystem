using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StationeryManagementSystem.DAO;

namespace StationeryManagementSystem.GUI
{
    public partial class FormThemSanPhamVaoHDB : Form
    {
        public FormThemSanPhamVaoHDB()
        {
            InitializeComponent();
        }

        public FormThemSanPhamVaoHDB(int maHD) : this()
        {
            this.maHD = maHD;
        }
        public FormThemSanPhamVaoHDB(int maHD, bool isSua, int maSP) : this()
        {
            this.maHD = maHD;
            this.isSua = true;
            this.maSP = maSP;
        }

        int maHD, maSP;
        bool isSua = false;
        bool isLoaded = false;


        private void txtSearh_TextChanged(object sender, EventArgs e)
        {
            try { 
            gvSP.DataSource = CommonDAO.search("SanPham", txtSearh.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!isSua)
            {

                int maSP = int.Parse(cbMaSP.SelectedValue.ToString());
                int soLuong = int.Parse(txtSoLuong.Text);
                try
                {
                    ChiTietHDBDAO.insert(maHD, maSP, soLuong);
                    MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                int maSP = int.Parse(cbMaSP.SelectedValue.ToString());
                int soLuong = int.Parse(txtSoLuong.Text);
                try
                {
                    ChiTietHDBDAO.update(maHD, maSP, soLuong);
                    MessageBox.Show("Sữa sản phẩm vào hóa đơn thành công");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvSP_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(gvSP.CurrentRow.Cells[0].Value.ToString());
            cbMaSP.SelectedValue = maSP;
            cbTenSP.SelectedValue = maSP;
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;

            cbTenSP.SelectedValue = cbMaSP.SelectedValue;
            for (int i = 0; i < gvSP.Rows.Count; i++)
            {
                if (int.Parse(gvSP.Rows[i].Cells[0].Value.ToString()) == int.Parse(cbMaSP.SelectedValue.ToString()))
                {
                    gvSP.Rows[i].Selected = true;
                    gvSP.CurrentCell = gvSP.Rows[i].Cells[0];
                    break;
                }
            }
        }

        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            cbMaSP.SelectedValue = cbTenSP.SelectedValue;
            //click vào sản phẩm trong data grid view
            for (int i = 0; i < gvSP.Rows.Count; i++)
            {
                if (int.Parse(gvSP.Rows[i].Cells[0].Value.ToString()) == int.Parse(cbMaSP.SelectedValue.ToString()))
                {
                    gvSP.Rows[i].Selected = true;
                    gvSP.CurrentCell = gvSP.Rows[i].Cells[0];
                    break;
                }
            }
        }

        private void FormThemSanPhamVaoHDB_Load(object sender, EventArgs e)
        {
            try { 
            gvSP.DataSource = SanPhamDAO.findAll();

            cbTenSP.DataSource = DAO.SanPhamDAO.findAll();
            cbTenSP.DisplayMember = "Tên SP";
            cbTenSP.ValueMember = "Mã SP";
            cbTenSP.SelectedIndex = -1;
            cbMaSP.DataSource = DAO.SanPhamDAO.findAll();
            cbMaSP.DisplayMember = "Mã SP";
            cbMaSP.ValueMember = "Mã SP";
            cbMaSP.SelectedIndex = -1;
            txtMaHD.Text = maHD.ToString();
            isLoaded = true;
            if (isSua)
            {
                cbMaSP.SelectedValue = maSP;
                cbTenSP.SelectedValue = maSP;
                cbMaSP.Enabled = false;
                cbTenSP.Enabled = false;
                gvSP.Enabled = false;

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các tính năng" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
