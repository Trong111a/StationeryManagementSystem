﻿using StationeryManagementSystem;
using StationeryManagementSystem.GUI;
using System;
using System.Drawing;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace StationeryManagementSystem
{
    public partial class FormMain : Form
    {
        private Form activeForm;
        private Button currentButton;

        public FormMain()
        {
            InitializeComponent();
            InitializeButtonImages();
        }

        private void InitializeButtonImages()
        {
            try
            {
                roundedButton_qltk.Image = Image.FromFile("..\\..\\Resources\\userden.png");
                roundedButton_qlnv.Image = Image.FromFile("..\\..\\Resources\\employeeden.png");
                roundedButton_qlsp.Image = Image.FromFile("..\\..\\Resources\\sanpham_den.png");
                roundedButton_hdn.Image = Image.FromFile("..\\..\\Resources\\hoadonnhap.png");
                roundedButton_hdb.Image = Image.FromFile("..\\..\\Resources\\hoadonban.png");
                roundedButton_qldt.Image = Image.FromFile("..\\..\\Resources\\doanhthu.png");
                roundedButton_lv.Image = Image.FromFile("..\\..\\Resources\\lichlv.png");
                roundedButton_ncc.Image = Image.FromFile("..\\..\\Resources\\cungcap.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading images: " + ex.Message);
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Size = new Size(800, 600);
            childForm.Dock = DockStyle.Fill;
            this.panel_childForm.Controls.Add(childForm);
            this.panel_childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTiltle.Text = childForm.Text;
           
        }

        private void ActivateButton(object btnSender)
        {
            Color color = Color.FromArgb(0, 108, 225);
            if (btnSender != null)
            {
                RoundedButton roundedButton = btnSender as RoundedButton;
                if (roundedButton != null && currentButton != roundedButton)
                {
                    DisableButton();
                    currentButton = roundedButton;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Verdana", 10.2F, FontStyle.Regular);

                    SetButtonImage(roundedButton, true); 
                    panel_logo.BackColor = Color.Transparent;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel_menu.Controls)
            {
                if (previousBtn is RoundedButton roundedButton)
                {
                    roundedButton.BackColor = Color.White;
                    roundedButton.ForeColor = Color.Black;
                    roundedButton.Font = new Font("Verdana", 10.2F, FontStyle.Regular);
                    SetButtonImage(roundedButton, false); 
                }
            }
        }

        private void SetButtonImage(RoundedButton button, bool isActive)
        {
            string imagePath = "..\\..\\Resources\\";
            if (button.Name == "roundedButton_qltk")
                button.Image = Image.FromFile(imagePath + (isActive ? "usertrang.png" : "userden.png"));
            else if (button.Name == "roundedButton_qlnv")
                button.Image = Image.FromFile(imagePath + (isActive ? "employeetrang.png" : "employeeden.png"));
            else if (button.Name == "roundedButton_qlsp")
                button.Image = Image.FromFile(imagePath + (isActive ? "sanpham_trang.png" : "sanpham_den.png"));
            else if (button.Name == "roundedButton_hdn")
                button.Image = Image.FromFile(imagePath + (isActive ? "hoadonnhap_trang.png" : "hoadonnhap.png"));
            else if (button.Name == "roundedButton_hdb")
                button.Image = Image.FromFile(imagePath + (isActive ? "hoadonban_trang.png" : "hoadonban.png"));
            else if (button.Name == "roundedButton_qldt")
                button.Image = Image.FromFile(imagePath + (isActive ? "doanhthu_trang.png" : "doanhthu.png"));
            else if (button.Name == "roundedButton_lv")
                button.Image = Image.FromFile(imagePath + (isActive ? "lichlv_trang.png" : "lichlv.png"));
            else if (button.Name == "roundedButton_ncc")
                button.Image = Image.FromFile(imagePath + (isActive ? "cungcap_trang.png" : "cungcap.png"));
        }


        bool isCollapsed = false;

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                panel_menu.Size = panel_menu.MinimumSize;
                foreach (Control bt in panel_menu.Controls)
                {
                    if (bt is RoundedButton)
                    {
                        bt.Text = "";
                    }
                }
                isCollapsed = true;
            }
            else
            {
                panel_menu.Size = panel_menu.MaximumSize;
                isCollapsed = false;
                roundedButton_qltk.Text = "   Quản lý tài khoản";
                roundedButton_qlnv.Text = "   Quản lý nhân viên";
                roundedButton_qlsp.Text = "   Quản lý sản phẩm";
                roundedButton_hdn.Text = "   Quản lý hóa đơn nhập";
                roundedButton_hdb.Text = "   Quản lý hóa đơn bán";
                roundedButton_qldt.Text = "   Quản lý doanh thu";
                roundedButton_lv.Text = "   Quản lý lịch làm việc";
                roundedButton_ncc.Text = "   Quản lý nhà cung cấp";
            }
        }

        private void roundedButton_qltk_Click(object sender, EventArgs e)
        {
            FormTaiKhoan formTaiKhoan = new FormTaiKhoan();
            OpenChildForm(formTaiKhoan, sender);
            lblTiltle.Text = "Quản lý tài khoản";
        }

        private void roundedButton_qlnv_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            OpenChildForm(formNhanVien, sender);
            lblTiltle.Text = "Quản lý nhân viên";
        }

        private void roundedButton_qlsp_Click(object sender, EventArgs e)
        {
            FormSanPham formSanPham = new FormSanPham();
            OpenChildForm(formSanPham, sender);
            lblTiltle.Text = "Quản lý sản phẩm";
        }

        private void roundedButton_hdn_Click(object sender, EventArgs e)
        {
            FormHoaDonNhap formHoaDonNhap  = new FormHoaDonNhap();
            OpenChildForm(formHoaDonNhap, sender);
            lblTiltle.Text = "Quản lý hóa đơn nhập";
        }

        private void roundedButton_hdb_Click(object sender, EventArgs e)
        {
            FormHoaDonBan formHoaDonBan = new FormHoaDonBan();
            OpenChildForm(formHoaDonBan, sender);
            lblTiltle.Text = "Quản lý hóa đơn bán";
        }

        private void roundedButton_qldt_Click(object sender, EventArgs e)
        {
            FormDoanhThu formDoanhThu = new FormDoanhThu();
            OpenChildForm(formDoanhThu, sender);
            lblTiltle.Text = "Quản lý doanh thu";
        }

        private void roundedButton_lv_Click(object sender, EventArgs e)
        {
            FormLichLamViec formLichLamViec = new FormLichLamViec();
            OpenChildForm(formLichLamViec, sender);
            lblTiltle.Text = "Quản lý lịch làm việc";
        }

        private void roundedButton_ncc_Click(object sender, EventArgs e)
        {
            FormNhaCungCap formNhaCungCap = new FormNhaCungCap();
            OpenChildForm(formNhaCungCap, sender);
            lblTiltle.Text = "Quản lý nhà cung cấp";
        }

        
    }
}
