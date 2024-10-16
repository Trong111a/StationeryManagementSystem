﻿using StationeryManagementSystem;
using System.Windows.Forms;

namespace StationeryManagementSystem
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.lblTiltle = new System.Windows.Forms.Label();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.roundedButton_thoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedButton2 = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_qlkh = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_ncc = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_lv = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_qldt = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_hdb = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_hdn = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_qlsp = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_qlnv = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_qltk = new StationeryManagementSystem.RoundedButton();
            this.roundedButton6 = new StationeryManagementSystem.RoundedButton();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel_childForm.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.Controls.Add(this.roundedButton2);
            this.panel_menu.Controls.Add(this.roundedButton_thoat);
            this.panel_menu.Controls.Add(this.roundedButton_qlkh);
            this.panel_menu.Controls.Add(this.roundedButton_ncc);
            this.panel_menu.Controls.Add(this.roundedButton_lv);
            this.panel_menu.Controls.Add(this.roundedButton_qldt);
            this.panel_menu.Controls.Add(this.roundedButton_hdb);
            this.panel_menu.Controls.Add(this.roundedButton_hdn);
            this.panel_menu.Controls.Add(this.roundedButton_qlsp);
            this.panel_menu.Controls.Add(this.roundedButton_qlnv);
            this.panel_menu.Controls.Add(this.roundedButton_qltk);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_menu.MaximumSize = new System.Drawing.Size(256, 1649);
            this.panel_menu.MinimumSize = new System.Drawing.Size(58, 649);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(256, 676);
            this.panel_menu.TabIndex = 0;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo.Controls.Add(this.roundedButton6);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(2);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(256, 74);
            this.panel_logo.TabIndex = 0;
            // 
            // lblTiltle
            // 
            this.lblTiltle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiltle.ForeColor = System.Drawing.Color.White;
            this.lblTiltle.Location = new System.Drawing.Point(65, 7);
            this.lblTiltle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiltle.Name = "lblTiltle";
            this.lblTiltle.Size = new System.Drawing.Size(974, 48);
            this.lblTiltle.TabIndex = 0;
            this.lblTiltle.Text = "Home";
            this.lblTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_childForm
            // 
            this.panel_childForm.AutoScroll = true;
            this.panel_childForm.BackColor = System.Drawing.Color.Transparent;
            this.panel_childForm.Controls.Add(this.pictureBox1);
            this.panel_childForm.Controls.Add(this.label1);
            this.panel_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childForm.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.panel_childForm.Location = new System.Drawing.Point(256, 74);
            this.panel_childForm.Margin = new System.Windows.Forms.Padding(2);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Size = new System.Drawing.Size(976, 602);
            this.panel_childForm.TabIndex = 2;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitleBar.Controls.Add(this.lblTiltle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitleBar.Location = new System.Drawing.Point(256, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(976, 74);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.TabStop = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 55.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(188, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 233);
            this.label1.TabIndex = 1;
            this.label1.Text = "CHÀO MỪNG BẠN ĐẾN VỚI NHÓM 20";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // roundedButton_thoat
            // 
            this.roundedButton_thoat.BackColor = System.Drawing.Color.Red;
            this.roundedButton_thoat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roundedButton_thoat.FlatAppearance.BorderSize = 0;
            this.roundedButton_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_thoat.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_thoat.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_thoat.Image = global::StationeryManagementSystem.Properties.Resources.thoat;
            this.roundedButton_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_thoat.Location = new System.Drawing.Point(0, 627);
            this.roundedButton_thoat.Margin = new System.Windows.Forms.Padding(0);
            this.roundedButton_thoat.Name = "roundedButton_thoat";
            this.roundedButton_thoat.Size = new System.Drawing.Size(256, 49);
            this.roundedButton_thoat.TabIndex = 11;
            this.roundedButton_thoat.Text = "Thoát";
            this.roundedButton_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.roundedButton_thoat.UseVisualStyleBackColor = false;
            this.roundedButton_thoat.Click += new System.EventHandler(this.roundedButton_thoat_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StationeryManagementSystem.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(41, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(716, 524);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.White;
            this.roundedButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton2.ForeColor = System.Drawing.Color.Black;
            this.roundedButton2.Image = global::StationeryManagementSystem.Properties.Resources.userden;
            this.roundedButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton2.Location = new System.Drawing.Point(0, 515);
            this.roundedButton2.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton2.Size = new System.Drawing.Size(256, 49);
            this.roundedButton2.TabIndex = 13;
            this.roundedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton2.UseVisualStyleBackColor = true;
            // 
            // roundedButton_qlkh
            // 
            this.roundedButton_qlkh.BackColor = System.Drawing.Color.White;
            this.roundedButton_qlkh.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_qlkh.FlatAppearance.BorderSize = 0;
            this.roundedButton_qlkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_qlkh.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_qlkh.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_qlkh.Image = global::StationeryManagementSystem.Properties.Resources.khachhang;
            this.roundedButton_qlkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qlkh.Location = new System.Drawing.Point(0, 466);
            this.roundedButton_qlkh.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_qlkh.Name = "roundedButton_qlkh";
            this.roundedButton_qlkh.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton_qlkh.Size = new System.Drawing.Size(256, 49);
            this.roundedButton_qlkh.TabIndex = 12;
            this.roundedButton_qlkh.Text = "   Khách hàng";
            this.roundedButton_qlkh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qlkh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_qlkh.UseVisualStyleBackColor = true;
            this.roundedButton_qlkh.Click += new System.EventHandler(this.roundedButton_qlkh_Click);
            // 
            // roundedButton_ncc
            // 
            this.roundedButton_ncc.BackColor = System.Drawing.Color.White;
            this.roundedButton_ncc.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_ncc.FlatAppearance.BorderSize = 0;
            this.roundedButton_ncc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_ncc.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_ncc.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_ncc.Image = global::StationeryManagementSystem.Properties.Resources.cungcap;
            this.roundedButton_ncc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_ncc.Location = new System.Drawing.Point(0, 417);
            this.roundedButton_ncc.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_ncc.Name = "roundedButton_ncc";
            this.roundedButton_ncc.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton_ncc.Size = new System.Drawing.Size(256, 49);
            this.roundedButton_ncc.TabIndex = 10;
            this.roundedButton_ncc.Text = "   Quản lý nhà cung cấp";
            this.roundedButton_ncc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_ncc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_ncc.UseVisualStyleBackColor = true;
            this.roundedButton_ncc.Click += new System.EventHandler(this.roundedButton_ncc_Click);
            // 
            // roundedButton_lv
            // 
            this.roundedButton_lv.BackColor = System.Drawing.Color.White;
            this.roundedButton_lv.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_lv.FlatAppearance.BorderSize = 0;
            this.roundedButton_lv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_lv.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_lv.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_lv.Image = global::StationeryManagementSystem.Properties.Resources.lichlv;
            this.roundedButton_lv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_lv.Location = new System.Drawing.Point(0, 368);
            this.roundedButton_lv.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_lv.Name = "roundedButton_lv";
            this.roundedButton_lv.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton_lv.Size = new System.Drawing.Size(256, 49);
            this.roundedButton_lv.TabIndex = 9;
            this.roundedButton_lv.Text = "   Quản lý lịch làm việc";
            this.roundedButton_lv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_lv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_lv.UseVisualStyleBackColor = true;
            this.roundedButton_lv.Click += new System.EventHandler(this.roundedButton_lv_Click);
            // 
            // roundedButton_qldt
            // 
            this.roundedButton_qldt.BackColor = System.Drawing.Color.White;
            this.roundedButton_qldt.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_qldt.FlatAppearance.BorderSize = 0;
            this.roundedButton_qldt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_qldt.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_qldt.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_qldt.Image = global::StationeryManagementSystem.Properties.Resources.doanhthu;
            this.roundedButton_qldt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qldt.Location = new System.Drawing.Point(0, 319);
            this.roundedButton_qldt.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_qldt.Name = "roundedButton_qldt";
            this.roundedButton_qldt.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton_qldt.Size = new System.Drawing.Size(256, 49);
            this.roundedButton_qldt.TabIndex = 8;
            this.roundedButton_qldt.Text = "   Thống kê";
            this.roundedButton_qldt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qldt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_qldt.UseVisualStyleBackColor = true;
            this.roundedButton_qldt.Click += new System.EventHandler(this.roundedButton_qldt_Click);
            // 
            // roundedButton_hdb
            // 
            this.roundedButton_hdb.BackColor = System.Drawing.Color.White;
            this.roundedButton_hdb.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_hdb.FlatAppearance.BorderSize = 0;
            this.roundedButton_hdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_hdb.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_hdb.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_hdb.Image = global::StationeryManagementSystem.Properties.Resources.hoadonban;
            this.roundedButton_hdb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_hdb.Location = new System.Drawing.Point(0, 270);
            this.roundedButton_hdb.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_hdb.Name = "roundedButton_hdb";
            this.roundedButton_hdb.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton_hdb.Size = new System.Drawing.Size(256, 49);
            this.roundedButton_hdb.TabIndex = 7;
            this.roundedButton_hdb.Text = "   Quản lý HĐ Bán";
            this.roundedButton_hdb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_hdb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_hdb.UseVisualStyleBackColor = true;
            this.roundedButton_hdb.Click += new System.EventHandler(this.roundedButton_hdb_Click);
            // 
            // roundedButton_hdn
            // 
            this.roundedButton_hdn.BackColor = System.Drawing.Color.White;
            this.roundedButton_hdn.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_hdn.FlatAppearance.BorderSize = 0;
            this.roundedButton_hdn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_hdn.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_hdn.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_hdn.Image = global::StationeryManagementSystem.Properties.Resources.hoadonnhap;
            this.roundedButton_hdn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_hdn.Location = new System.Drawing.Point(0, 221);
            this.roundedButton_hdn.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_hdn.Name = "roundedButton_hdn";
            this.roundedButton_hdn.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton_hdn.Size = new System.Drawing.Size(256, 49);
            this.roundedButton_hdn.TabIndex = 6;
            this.roundedButton_hdn.Text = "   Quản lý HĐ Nhập";
            this.roundedButton_hdn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_hdn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_hdn.UseVisualStyleBackColor = true;
            this.roundedButton_hdn.Click += new System.EventHandler(this.roundedButton_hdn_Click);
            // 
            // roundedButton_qlsp
            // 
            this.roundedButton_qlsp.BackColor = System.Drawing.Color.White;
            this.roundedButton_qlsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_qlsp.FlatAppearance.BorderSize = 0;
            this.roundedButton_qlsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_qlsp.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_qlsp.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_qlsp.Image = ((System.Drawing.Image)(resources.GetObject("roundedButton_qlsp.Image")));
            this.roundedButton_qlsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qlsp.Location = new System.Drawing.Point(0, 172);
            this.roundedButton_qlsp.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_qlsp.Name = "roundedButton_qlsp";
            this.roundedButton_qlsp.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton_qlsp.Size = new System.Drawing.Size(256, 49);
            this.roundedButton_qlsp.TabIndex = 5;
            this.roundedButton_qlsp.Text = "   Quản lý sản phẩm";
            this.roundedButton_qlsp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qlsp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_qlsp.UseVisualStyleBackColor = true;
            this.roundedButton_qlsp.Click += new System.EventHandler(this.roundedButton_qlsp_Click);
            // 
            // roundedButton_qlnv
            // 
            this.roundedButton_qlnv.BackColor = System.Drawing.Color.White;
            this.roundedButton_qlnv.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_qlnv.FlatAppearance.BorderSize = 0;
            this.roundedButton_qlnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_qlnv.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_qlnv.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_qlnv.Image = global::StationeryManagementSystem.Properties.Resources.employeeden;
            this.roundedButton_qlnv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qlnv.Location = new System.Drawing.Point(0, 123);
            this.roundedButton_qlnv.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_qlnv.Name = "roundedButton_qlnv";
            this.roundedButton_qlnv.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton_qlnv.Size = new System.Drawing.Size(256, 49);
            this.roundedButton_qlnv.TabIndex = 4;
            this.roundedButton_qlnv.Text = "   Quản lý nhân viên";
            this.roundedButton_qlnv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qlnv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_qlnv.UseVisualStyleBackColor = true;
            this.roundedButton_qlnv.Click += new System.EventHandler(this.roundedButton_qlnv_Click);
            // 
            // roundedButton_qltk
            // 
            this.roundedButton_qltk.BackColor = System.Drawing.Color.White;
            this.roundedButton_qltk.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_qltk.FlatAppearance.BorderSize = 0;
            this.roundedButton_qltk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_qltk.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_qltk.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_qltk.Image = global::StationeryManagementSystem.Properties.Resources.userden;
            this.roundedButton_qltk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qltk.Location = new System.Drawing.Point(0, 74);
            this.roundedButton_qltk.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_qltk.Name = "roundedButton_qltk";
            this.roundedButton_qltk.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton_qltk.Size = new System.Drawing.Size(256, 49);
            this.roundedButton_qltk.TabIndex = 3;
            this.roundedButton_qltk.Text = "   Quản lý tài khoản";
            this.roundedButton_qltk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qltk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_qltk.UseVisualStyleBackColor = true;
            this.roundedButton_qltk.Click += new System.EventHandler(this.roundedButton_qltk_Click);
            // 
            // roundedButton6
            // 
            this.roundedButton6.BackColor = System.Drawing.Color.White;
            this.roundedButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roundedButton6.FlatAppearance.BorderSize = 0;
            this.roundedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton6.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton6.ForeColor = System.Drawing.Color.Black;
            this.roundedButton6.Image = global::StationeryManagementSystem.Properties.Resources.menu;
            this.roundedButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton6.Location = new System.Drawing.Point(0, 25);
            this.roundedButton6.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton6.Name = "roundedButton6";
            this.roundedButton6.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.roundedButton6.Size = new System.Drawing.Size(256, 49);
            this.roundedButton6.TabIndex = 6;
            this.roundedButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton6.UseVisualStyleBackColor = true;
            this.roundedButton6.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1232, 676);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel_menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_childForm.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Label lblTiltle;
        private System.Windows.Forms.Panel panel_childForm;
        private RoundedButton button_nv;
        private RoundedButton button_khachhang;
        private RoundedButton button_account;
        private RoundedButton btn_dangxuat;
        private Panel panel_logo;
        private RoundedButton roundedButton1;
        private RoundedButton button_phong;
        private RoundedButton button_bill;
        private RoundedButton button_dichvu;
        private RoundedButton button_dangkythuetra;
        private RoundedButton roundedButton_ca_lich;
        private RoundedButton roundedButton_bc_thu_chi;
        private RoundedButton roundedButton_khaibaotp = new RoundedButton();
        private RoundedButton button1;
        private RoundedButton roundedButton_qltk;
        private RoundedButton roundedButton_qlnv;
        private RoundedButton roundedButton_hdn;
        private RoundedButton roundedButton_qlsp;
        private RoundedButton roundedButton6;
        private RoundedButton roundedButton_ncc;
        private RoundedButton roundedButton_lv;
        private RoundedButton roundedButton_qldt;
        private RoundedButton roundedButton_hdb;
        private Button roundedButton_thoat;
        private RoundedButton roundedButton_qlkh;
        private Panel panelTitleBar;
        private RoundedButton roundedButton2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}