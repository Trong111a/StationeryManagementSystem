using StationeryManagementSystem;
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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTiltle = new System.Windows.Forms.Label();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.roundedButton_dudoan = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_thoat = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_qldt = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_qlkh = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_ncc = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_hdn = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_hdb = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_qlsp = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_lv = new StationeryManagementSystem.RoundedButton();
            this.roundedButton_qlnv = new StationeryManagementSystem.RoundedButton();
            this.roundedButton6 = new StationeryManagementSystem.RoundedButton();
            this.panelTitleBar.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitleBar.Controls.Add(this.lblTiltle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitleBar.Location = new System.Drawing.Point(320, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1107, 92);
            this.panelTitleBar.TabIndex = 4;
            this.panelTitleBar.TabStop = true;
            // 
            // lblTiltle
            // 
            this.lblTiltle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiltle.ForeColor = System.Drawing.Color.White;
            this.lblTiltle.Location = new System.Drawing.Point(81, 9);
            this.lblTiltle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiltle.Name = "lblTiltle";
            this.lblTiltle.Size = new System.Drawing.Size(1105, 60);
            this.lblTiltle.TabIndex = 0;
            this.lblTiltle.Text = "Home";
            this.lblTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo.Controls.Add(this.roundedButton6);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(2);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(320, 92);
            this.panel_logo.TabIndex = 0;
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.Controls.Add(this.roundedButton_dudoan);
            this.panel_menu.Controls.Add(this.roundedButton_thoat);
            this.panel_menu.Controls.Add(this.roundedButton_qldt);
            this.panel_menu.Controls.Add(this.roundedButton_qlkh);
            this.panel_menu.Controls.Add(this.roundedButton_ncc);
            this.panel_menu.Controls.Add(this.roundedButton_hdn);
            this.panel_menu.Controls.Add(this.roundedButton_hdb);
            this.panel_menu.Controls.Add(this.roundedButton_qlsp);
            this.panel_menu.Controls.Add(this.roundedButton_lv);
            this.panel_menu.Controls.Add(this.roundedButton_qlnv);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_menu.MaximumSize = new System.Drawing.Size(320, 2061);
            this.panel_menu.MinimumSize = new System.Drawing.Size(72, 811);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(320, 879);
            this.panel_menu.TabIndex = 3;
            // 
            // panel_childForm
            // 
            this.panel_childForm.AutoScroll = true;
            this.panel_childForm.AutoSize = true;
            this.panel_childForm.BackColor = System.Drawing.Color.Transparent;
            this.panel_childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_childForm.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.panel_childForm.Location = new System.Drawing.Point(322, 92);
            this.panel_childForm.Margin = new System.Windows.Forms.Padding(2);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Size = new System.Drawing.Size(1100, 780);
            this.panel_childForm.TabIndex = 5;
            // 
            // roundedButton_dudoan
            // 
            this.roundedButton_dudoan.BackColor = System.Drawing.Color.White;
            this.roundedButton_dudoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_dudoan.FlatAppearance.BorderSize = 0;
            this.roundedButton_dudoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_dudoan.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_dudoan.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_dudoan.Image = global::StationeryManagementSystem.Properties.Resources.doanhthu;
            this.roundedButton_dudoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_dudoan.Location = new System.Drawing.Point(0, 641);
            this.roundedButton_dudoan.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_dudoan.Name = "roundedButton_dudoan";
            this.roundedButton_dudoan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton_dudoan.Size = new System.Drawing.Size(320, 61);
            this.roundedButton_dudoan.TabIndex = 14;
            this.roundedButton_dudoan.Text = "   Dự đoán doanh thu";
            this.roundedButton_dudoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_dudoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_dudoan.UseVisualStyleBackColor = true;
            this.roundedButton_dudoan.Click += new System.EventHandler(this.roundedButton_dudoan_Click);
            // 
            // roundedButton_thoat
            // 
            this.roundedButton_thoat.BackColor = System.Drawing.Color.White;
            this.roundedButton_thoat.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_thoat.FlatAppearance.BorderSize = 0;
            this.roundedButton_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_thoat.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_thoat.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_thoat.Image = global::StationeryManagementSystem.Properties.Resources.thoat;
            this.roundedButton_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_thoat.Location = new System.Drawing.Point(0, 580);
            this.roundedButton_thoat.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_thoat.Name = "roundedButton_thoat";
            this.roundedButton_thoat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton_thoat.Size = new System.Drawing.Size(320, 61);
            this.roundedButton_thoat.TabIndex = 13;
            this.roundedButton_thoat.Text = "   Thoát";
            this.roundedButton_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_thoat.UseVisualStyleBackColor = true;
            this.roundedButton_thoat.Click += new System.EventHandler(this.roundedButton_thoat_Click);
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
            this.roundedButton_qldt.Location = new System.Drawing.Point(0, 519);
            this.roundedButton_qldt.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_qldt.Name = "roundedButton_qldt";
            this.roundedButton_qldt.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton_qldt.Size = new System.Drawing.Size(320, 61);
            this.roundedButton_qldt.TabIndex = 12;
            this.roundedButton_qldt.Text = "   Thống kê";
            this.roundedButton_qldt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qldt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_qldt.UseVisualStyleBackColor = true;
            this.roundedButton_qldt.Click += new System.EventHandler(this.roundedButton_qldt_Click);
            // 
            // roundedButton_qlkh
            // 
            this.roundedButton_qlkh.BackColor = System.Drawing.Color.White;
            this.roundedButton_qlkh.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_qlkh.FlatAppearance.BorderSize = 0;
            this.roundedButton_qlkh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_qlkh.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_qlkh.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_qlkh.Image = global::StationeryManagementSystem.Properties.Resources.khachhangden;
            this.roundedButton_qlkh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qlkh.Location = new System.Drawing.Point(0, 458);
            this.roundedButton_qlkh.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_qlkh.Name = "roundedButton_qlkh";
            this.roundedButton_qlkh.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton_qlkh.Size = new System.Drawing.Size(320, 61);
            this.roundedButton_qlkh.TabIndex = 10;
            this.roundedButton_qlkh.Text = "   Quản lý khách hàng";
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
            this.roundedButton_ncc.Location = new System.Drawing.Point(0, 397);
            this.roundedButton_ncc.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_ncc.Name = "roundedButton_ncc";
            this.roundedButton_ncc.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton_ncc.Size = new System.Drawing.Size(320, 61);
            this.roundedButton_ncc.TabIndex = 9;
            this.roundedButton_ncc.Text = "   Quản lý nhà cung cấp";
            this.roundedButton_ncc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_ncc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_ncc.UseVisualStyleBackColor = true;
            this.roundedButton_ncc.Click += new System.EventHandler(this.roundedButton_ncc_Click);
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
            this.roundedButton_hdn.Location = new System.Drawing.Point(0, 336);
            this.roundedButton_hdn.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_hdn.Name = "roundedButton_hdn";
            this.roundedButton_hdn.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton_hdn.Size = new System.Drawing.Size(320, 61);
            this.roundedButton_hdn.TabIndex = 8;
            this.roundedButton_hdn.Text = "   Quản lý HĐ Nhập";
            this.roundedButton_hdn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_hdn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_hdn.UseVisualStyleBackColor = true;
            this.roundedButton_hdn.Click += new System.EventHandler(this.roundedButton_hdn_Click);
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
            this.roundedButton_hdb.Location = new System.Drawing.Point(0, 275);
            this.roundedButton_hdb.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_hdb.Name = "roundedButton_hdb";
            this.roundedButton_hdb.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton_hdb.Size = new System.Drawing.Size(320, 61);
            this.roundedButton_hdb.TabIndex = 7;
            this.roundedButton_hdb.Text = "   Quản lý HĐ Bán";
            this.roundedButton_hdb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_hdb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_hdb.UseVisualStyleBackColor = true;
            this.roundedButton_hdb.Click += new System.EventHandler(this.roundedButton_hdb_Click);
            // 
            // roundedButton_qlsp
            // 
            this.roundedButton_qlsp.BackColor = System.Drawing.Color.White;
            this.roundedButton_qlsp.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton_qlsp.FlatAppearance.BorderSize = 0;
            this.roundedButton_qlsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton_qlsp.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton_qlsp.ForeColor = System.Drawing.Color.Black;
            this.roundedButton_qlsp.Image = global::StationeryManagementSystem.Properties.Resources.sanpham_den;
            this.roundedButton_qlsp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qlsp.Location = new System.Drawing.Point(0, 214);
            this.roundedButton_qlsp.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_qlsp.Name = "roundedButton_qlsp";
            this.roundedButton_qlsp.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton_qlsp.Size = new System.Drawing.Size(320, 61);
            this.roundedButton_qlsp.TabIndex = 6;
            this.roundedButton_qlsp.Text = "   Quản lý sản phẩm";
            this.roundedButton_qlsp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qlsp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_qlsp.UseVisualStyleBackColor = true;
            this.roundedButton_qlsp.Click += new System.EventHandler(this.roundedButton_qlsp_Click);
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
            this.roundedButton_lv.Location = new System.Drawing.Point(0, 153);
            this.roundedButton_lv.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_lv.Name = "roundedButton_lv";
            this.roundedButton_lv.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton_lv.Size = new System.Drawing.Size(320, 61);
            this.roundedButton_lv.TabIndex = 5;
            this.roundedButton_lv.Text = "   Quản lý lịch làm việc";
            this.roundedButton_lv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_lv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_lv.UseVisualStyleBackColor = true;
            this.roundedButton_lv.Click += new System.EventHandler(this.roundedButton_lv_Click);
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
            this.roundedButton_qlnv.Location = new System.Drawing.Point(0, 92);
            this.roundedButton_qlnv.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton_qlnv.Name = "roundedButton_qlnv";
            this.roundedButton_qlnv.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton_qlnv.Size = new System.Drawing.Size(320, 61);
            this.roundedButton_qlnv.TabIndex = 4;
            this.roundedButton_qlnv.Text = "   Quản lý nhân viên";
            this.roundedButton_qlnv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton_qlnv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton_qlnv.UseVisualStyleBackColor = true;
            this.roundedButton_qlnv.Click += new System.EventHandler(this.roundedButton_qlnv_Click);
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
            this.roundedButton6.Location = new System.Drawing.Point(0, 31);
            this.roundedButton6.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton6.Name = "roundedButton6";
            this.roundedButton6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton6.Size = new System.Drawing.Size(320, 61);
            this.roundedButton6.TabIndex = 6;
            this.roundedButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton6.UseVisualStyleBackColor = true;
            this.roundedButton6.Click += new System.EventHandler(this.roundedButton6_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1427, 879);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.panel_menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panelTitleBar.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedButton button_nv;
        private RoundedButton button_khachhang;
        private RoundedButton button_account;
        private RoundedButton btn_dangxuat;
        private RoundedButton roundedButton1;
        private RoundedButton button_phong;
        private RoundedButton button_bill;
        private RoundedButton button_dichvu;
        private RoundedButton button_dangkythuetra;
        private RoundedButton roundedButton_ca_lich;
        private RoundedButton roundedButton_bc_thu_chi;
        private RoundedButton roundedButton_khaibaotp = new RoundedButton();
        private RoundedButton button1;
        private Panel panelTitleBar;
        private Label lblTiltle;
        private RoundedButton roundedButton_thoat;
        private RoundedButton roundedButton_qldt;
        private RoundedButton roundedButton_qlkh;
        private RoundedButton roundedButton_ncc;
        private RoundedButton roundedButton_hdn;
        private RoundedButton roundedButton_hdb;
        private RoundedButton roundedButton6;
        private RoundedButton roundedButton_qlsp;
        private RoundedButton roundedButton_lv;
        private RoundedButton roundedButton_qlnv;
        private Panel panel_logo;
        private Panel panel_menu;
        private Panel panel_childForm;
        private RoundedButton roundedButton_dudoan;
    }
}