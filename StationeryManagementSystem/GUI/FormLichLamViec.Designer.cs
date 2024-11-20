namespace StationeryManagementSystem.GUI
{
    partial class FormLichLamViec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbPhanCa = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblNgay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dp_moctime = new System.Windows.Forms.DateTimePicker();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.btnHienThi = new Guna.UI2.WinForms.Guna2Button();
            this.dpHienThi = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.gvPhanCa = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPhanCa = new Guna.UI2.WinForms.Guna2Button();
            this.dpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblPhanCa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbCa3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblMaNV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblChonNgay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbMaNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnDKCa3 = new Guna.UI2.WinForms.Guna2Button();
            this.dpCa3 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gbLuong = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pbSearchLuong = new System.Windows.Forms.PictureBox();
            this.dpNgayLuong = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gvLuong = new System.Windows.Forms.DataGridView();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gbPhanCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanCa)).BeginInit();
            this.gbCa3.SuspendLayout();
            this.gbLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPhanCa
            // 
            this.gbPhanCa.BorderRadius = 10;
            this.gbPhanCa.BorderThickness = 2;
            this.gbPhanCa.Controls.Add(this.lblNgay);
            this.gbPhanCa.Controls.Add(this.dp_moctime);
            this.gbPhanCa.Controls.Add(this.guna2Button1);
            this.gbPhanCa.Controls.Add(this.btnReload);
            this.gbPhanCa.Controls.Add(this.btnHienThi);
            this.gbPhanCa.Controls.Add(this.dpHienThi);
            this.gbPhanCa.Controls.Add(this.btnCheckIn);
            this.gbPhanCa.Controls.Add(this.btnCheckOut);
            this.gbPhanCa.Controls.Add(this.gvPhanCa);
            this.gbPhanCa.Controls.Add(this.btnPhanCa);
            this.gbPhanCa.Controls.Add(this.dpEnd);
            this.gbPhanCa.Controls.Add(this.dpStart);
            this.gbPhanCa.Controls.Add(this.lblPhanCa);
            this.gbPhanCa.Controls.Add(this.lblDen);
            this.gbPhanCa.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbPhanCa.FillColor = System.Drawing.SystemColors.Control;
            this.gbPhanCa.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhanCa.ForeColor = System.Drawing.Color.White;
            this.gbPhanCa.Location = new System.Drawing.Point(12, 12);
            this.gbPhanCa.Name = "gbPhanCa";
            this.gbPhanCa.Size = new System.Drawing.Size(548, 709);
            this.gbPhanCa.TabIndex = 59;
            this.gbPhanCa.Text = "Phân ca";
            // 
            // lblNgay
            // 
            this.lblNgay.BackColor = System.Drawing.SystemColors.Control;
            this.lblNgay.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.ForeColor = System.Drawing.Color.Teal;
            this.lblNgay.Location = new System.Drawing.Point(5, 183);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(71, 21);
            this.lblNgay.TabIndex = 81;
            this.lblNgay.Text = "Chọn ngày";
            // 
            // dp_moctime
            // 
            this.dp_moctime.CustomFormat = "HH:mm";
            this.dp_moctime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_moctime.Location = new System.Drawing.Point(22, 618);
            this.dp_moctime.Name = "dp_moctime";
            this.dp_moctime.Size = new System.Drawing.Size(86, 34);
            this.dp_moctime.TabIndex = 74;
            // 
            // btnReload
            // 
            this.btnReload.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnReload.BorderRadius = 10;
            this.btnReload.BorderThickness = 2;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.FillColor = System.Drawing.Color.Linen;
            this.btnReload.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReload.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReload.Location = new System.Drawing.Point(360, 611);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(97, 41);
            this.btnReload.TabIndex = 78;
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnHienThi.BorderRadius = 10;
            this.btnHienThi.BorderThickness = 2;
            this.btnHienThi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHienThi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHienThi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHienThi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHienThi.FillColor = System.Drawing.Color.Linen;
            this.btnHienThi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHienThi.Image = global::StationeryManagementSystem.Properties.Resources.xacnhan;
            this.btnHienThi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHienThi.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHienThi.Location = new System.Drawing.Point(415, 168);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(121, 41);
            this.btnHienThi.TabIndex = 77;
            this.btnHienThi.Text = "      Hiển thị";
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // dpHienThi
            // 
            this.dpHienThi.BackColor = System.Drawing.SystemColors.Control;
            this.dpHienThi.BorderColor = System.Drawing.Color.Teal;
            this.dpHienThi.BorderRadius = 10;
            this.dpHienThi.BorderThickness = 1;
            this.dpHienThi.Checked = true;
            this.dpHienThi.FillColor = System.Drawing.Color.White;
            this.dpHienThi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpHienThi.ForeColor = System.Drawing.Color.Teal;
            this.dpHienThi.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpHienThi.Location = new System.Drawing.Point(104, 173);
            this.dpHienThi.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpHienThi.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpHienThi.Name = "dpHienThi";
            this.dpHienThi.Size = new System.Drawing.Size(305, 36);
            this.dpHienThi.TabIndex = 75;
            this.dpHienThi.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckIn.BorderRadius = 10;
            this.btnCheckIn.BorderThickness = 2;
            this.btnCheckIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckIn.FillColor = System.Drawing.Color.Linen;
            this.btnCheckIn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckIn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckIn.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCheckIn.Location = new System.Drawing.Point(123, 611);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(106, 41);
            this.btnCheckIn.TabIndex = 74;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckOut.BorderRadius = 10;
            this.btnCheckOut.BorderThickness = 2;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.Linen;
            this.btnCheckOut.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCheckOut.Location = new System.Drawing.Point(241, 611);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(103, 41);
            this.btnCheckOut.TabIndex = 73;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // gvPhanCa
            // 
            this.gvPhanCa.BackgroundColor = System.Drawing.Color.White;
            this.gvPhanCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPhanCa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gvPhanCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPhanCa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.maCa,
            this.ngay,
            this.checkIn,
            this.checkOut});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPhanCa.DefaultCellStyle = dataGridViewCellStyle7;
            this.gvPhanCa.GridColor = System.Drawing.Color.White;
            this.gvPhanCa.Location = new System.Drawing.Point(22, 267);
            this.gvPhanCa.Name = "gvPhanCa";
            this.gvPhanCa.ReadOnly = true;
            this.gvPhanCa.RowHeadersWidth = 51;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Green;
            this.gvPhanCa.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gvPhanCa.RowTemplate.Height = 24;
            this.gvPhanCa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPhanCa.Size = new System.Drawing.Size(514, 317);
            this.gvPhanCa.TabIndex = 72;
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "MaNhanVien";
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.ReadOnly = true;
            this.maNV.Width = 170;
            // 
            // maCa
            // 
            this.maCa.DataPropertyName = "MaCa";
            this.maCa.HeaderText = "Mã ca";
            this.maCa.MinimumWidth = 6;
            this.maCa.Name = "maCa";
            this.maCa.ReadOnly = true;
            this.maCa.Width = 125;
            // 
            // ngay
            // 
            this.ngay.DataPropertyName = "Ngay";
            this.ngay.HeaderText = "Ngày";
            this.ngay.MinimumWidth = 6;
            this.ngay.Name = "ngay";
            this.ngay.ReadOnly = true;
            this.ngay.Width = 125;
            // 
            // checkIn
            // 
            this.checkIn.DataPropertyName = "CheckIn";
            this.checkIn.HeaderText = "Check In";
            this.checkIn.MinimumWidth = 6;
            this.checkIn.Name = "checkIn";
            this.checkIn.ReadOnly = true;
            this.checkIn.Width = 125;
            // 
            // checkOut
            // 
            this.checkOut.DataPropertyName = "CheckOut";
            this.checkOut.HeaderText = "Check Out";
            this.checkOut.MinimumWidth = 6;
            this.checkOut.Name = "checkOut";
            this.checkOut.ReadOnly = true;
            this.checkOut.Width = 125;
            // 
            // btnPhanCa
            // 
            this.btnPhanCa.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnPhanCa.BorderRadius = 10;
            this.btnPhanCa.BorderThickness = 2;
            this.btnPhanCa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhanCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhanCa.FillColor = System.Drawing.Color.Linen;
            this.btnPhanCa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPhanCa.Image = global::StationeryManagementSystem.Properties.Resources.plus;
            this.btnPhanCa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhanCa.Location = new System.Drawing.Point(415, 53);
            this.btnPhanCa.Name = "btnPhanCa";
            this.btnPhanCa.Size = new System.Drawing.Size(121, 76);
            this.btnPhanCa.TabIndex = 66;
            this.btnPhanCa.Text = "    Phân ca";
            this.btnPhanCa.Click += new System.EventHandler(this.btnPhanCa_Click);
            // 
            // dpEnd
            // 
            this.dpEnd.BackColor = System.Drawing.SystemColors.Control;
            this.dpEnd.BorderColor = System.Drawing.Color.Teal;
            this.dpEnd.BorderRadius = 10;
            this.dpEnd.BorderThickness = 1;
            this.dpEnd.Checked = true;
            this.dpEnd.FillColor = System.Drawing.Color.White;
            this.dpEnd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEnd.ForeColor = System.Drawing.Color.Teal;
            this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpEnd.Location = new System.Drawing.Point(104, 98);
            this.dpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(305, 36);
            this.dpEnd.TabIndex = 71;
            this.dpEnd.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // dpStart
            // 
            this.dpStart.BackColor = System.Drawing.SystemColors.Control;
            this.dpStart.BorderColor = System.Drawing.Color.Teal;
            this.dpStart.BorderRadius = 10;
            this.dpStart.BorderThickness = 1;
            this.dpStart.Checked = true;
            this.dpStart.FillColor = System.Drawing.Color.White;
            this.dpStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStart.ForeColor = System.Drawing.Color.Teal;
            this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpStart.Location = new System.Drawing.Point(104, 53);
            this.dpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(305, 36);
            this.dpStart.TabIndex = 70;
            this.dpStart.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // lblPhanCa
            // 
            this.lblPhanCa.BackColor = System.Drawing.SystemColors.Control;
            this.lblPhanCa.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanCa.ForeColor = System.Drawing.Color.Teal;
            this.lblPhanCa.Location = new System.Drawing.Point(3, 58);
            this.lblPhanCa.Name = "lblPhanCa";
            this.lblPhanCa.Size = new System.Drawing.Size(75, 21);
            this.lblPhanCa.TabIndex = 60;
            this.lblPhanCa.Text = "Phân ca từ";
            // 
            // lblDen
            // 
            this.lblDen.BackColor = System.Drawing.SystemColors.Control;
            this.lblDen.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDen.ForeColor = System.Drawing.Color.Teal;
            this.lblDen.Location = new System.Drawing.Point(3, 108);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(28, 21);
            this.lblDen.TabIndex = 62;
            this.lblDen.Text = "đến";
            // 
            // gbCa3
            // 
            this.gbCa3.BorderRadius = 10;
            this.gbCa3.BorderThickness = 2;
            this.gbCa3.Controls.Add(this.lblMaNV);
            this.gbCa3.Controls.Add(this.lblChonNgay);
            this.gbCa3.Controls.Add(this.cbMaNV);
            this.gbCa3.Controls.Add(this.btnDKCa3);
            this.gbCa3.Controls.Add(this.dpCa3);
            this.gbCa3.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbCa3.FillColor = System.Drawing.SystemColors.Control;
            this.gbCa3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCa3.ForeColor = System.Drawing.Color.White;
            this.gbCa3.Location = new System.Drawing.Point(577, 12);
            this.gbCa3.Name = "gbCa3";
            this.gbCa3.Size = new System.Drawing.Size(504, 221);
            this.gbCa3.TabIndex = 73;
            this.gbCa3.Text = "Ca làm thêm giờ";
            // 
            // lblMaNV
            // 
            this.lblMaNV.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaNV.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.Teal;
            this.lblMaNV.Location = new System.Drawing.Point(13, 135);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(93, 21);
            this.lblMaNV.TabIndex = 80;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // lblChonNgay
            // 
            this.lblChonNgay.BackColor = System.Drawing.SystemColors.Control;
            this.lblChonNgay.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonNgay.ForeColor = System.Drawing.Color.Teal;
            this.lblChonNgay.Location = new System.Drawing.Point(13, 81);
            this.lblChonNgay.Name = "lblChonNgay";
            this.lblChonNgay.Size = new System.Drawing.Size(71, 21);
            this.lblChonNgay.TabIndex = 79;
            this.lblChonNgay.Text = "Chọn ngày";
            // 
            // cbMaNV
            // 
            this.cbMaNV.BackColor = System.Drawing.Color.Transparent;
            this.cbMaNV.BorderColor = System.Drawing.Color.Teal;
            this.cbMaNV.BorderRadius = 10;
            this.cbMaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaNV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbMaNV.ItemHeight = 30;
            this.cbMaNV.Location = new System.Drawing.Point(139, 125);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(140, 36);
            this.cbMaNV.TabIndex = 79;
            // 
            // btnDKCa3
            // 
            this.btnDKCa3.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnDKCa3.BorderRadius = 10;
            this.btnDKCa3.BorderThickness = 2;
            this.btnDKCa3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDKCa3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDKCa3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDKCa3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDKCa3.FillColor = System.Drawing.Color.Linen;
            this.btnDKCa3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDKCa3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDKCa3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDKCa3.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDKCa3.Location = new System.Drawing.Point(297, 120);
            this.btnDKCa3.Name = "btnDKCa3";
            this.btnDKCa3.Size = new System.Drawing.Size(118, 41);
            this.btnDKCa3.TabIndex = 77;
            this.btnDKCa3.Text = "Đăng kí ca 3";
            this.btnDKCa3.Click += new System.EventHandler(this.btnDKCa3_Click);
            // 
            // dpCa3
            // 
            this.dpCa3.BackColor = System.Drawing.SystemColors.Control;
            this.dpCa3.BorderColor = System.Drawing.Color.Teal;
            this.dpCa3.BorderRadius = 10;
            this.dpCa3.BorderThickness = 1;
            this.dpCa3.Checked = true;
            this.dpCa3.FillColor = System.Drawing.Color.White;
            this.dpCa3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpCa3.ForeColor = System.Drawing.Color.Teal;
            this.dpCa3.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpCa3.Location = new System.Drawing.Point(139, 71);
            this.dpCa3.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpCa3.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpCa3.Name = "dpCa3";
            this.dpCa3.Size = new System.Drawing.Size(305, 36);
            this.dpCa3.TabIndex = 75;
            this.dpCa3.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // gbLuong
            // 
            this.gbLuong.BorderRadius = 10;
            this.gbLuong.BorderThickness = 2;
            this.gbLuong.Controls.Add(this.pbSearchLuong);
            this.gbLuong.Controls.Add(this.dpNgayLuong);
            this.gbLuong.Controls.Add(this.lblNgayLuong);
            this.gbLuong.Controls.Add(this.gvLuong);
            this.gbLuong.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbLuong.FillColor = System.Drawing.SystemColors.Control;
            this.gbLuong.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuong.ForeColor = System.Drawing.Color.White;
            this.gbLuong.Location = new System.Drawing.Point(577, 279);
            this.gbLuong.Name = "gbLuong";
            this.gbLuong.Size = new System.Drawing.Size(504, 442);
            this.gbLuong.TabIndex = 74;
            this.gbLuong.Text = "Lương nhân viên trong ngày";
            // 
            // pbSearchLuong
            // 
            this.pbSearchLuong.BackgroundImage = global::StationeryManagementSystem.Properties.Resources.Search;
            this.pbSearchLuong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSearchLuong.Location = new System.Drawing.Point(421, 53);
            this.pbSearchLuong.Name = "pbSearchLuong";
            this.pbSearchLuong.Size = new System.Drawing.Size(50, 36);
            this.pbSearchLuong.TabIndex = 63;
            this.pbSearchLuong.TabStop = false;
            this.pbSearchLuong.Click += new System.EventHandler(this.pbSearchLuong_Click);
            this.pbSearchLuong.MouseEnter += new System.EventHandler(this.pbSearchLuong_MouseEnter);
            this.pbSearchLuong.MouseLeave += new System.EventHandler(this.pbSearchLuong_MouseLeave);
            // 
            // dpNgayLuong
            // 
            this.dpNgayLuong.BackColor = System.Drawing.SystemColors.Control;
            this.dpNgayLuong.BorderColor = System.Drawing.Color.Teal;
            this.dpNgayLuong.BorderRadius = 10;
            this.dpNgayLuong.BorderThickness = 1;
            this.dpNgayLuong.Checked = true;
            this.dpNgayLuong.FillColor = System.Drawing.Color.White;
            this.dpNgayLuong.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNgayLuong.ForeColor = System.Drawing.Color.Teal;
            this.dpNgayLuong.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpNgayLuong.Location = new System.Drawing.Point(133, 53);
            this.dpNgayLuong.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpNgayLuong.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpNgayLuong.Name = "dpNgayLuong";
            this.dpNgayLuong.Size = new System.Drawing.Size(282, 36);
            this.dpNgayLuong.TabIndex = 62;
            this.dpNgayLuong.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // lblNgayLuong
            // 
            this.lblNgayLuong.BackColor = System.Drawing.SystemColors.Control;
            this.lblNgayLuong.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLuong.ForeColor = System.Drawing.Color.Teal;
            this.lblNgayLuong.Location = new System.Drawing.Point(34, 63);
            this.lblNgayLuong.Name = "lblNgayLuong";
            this.lblNgayLuong.Size = new System.Drawing.Size(71, 21);
            this.lblNgayLuong.TabIndex = 61;
            this.lblNgayLuong.Text = "Chọn ngày";
            // 
            // gvLuong
            // 
            this.gvLuong.BackgroundColor = System.Drawing.Color.White;
            this.gvLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
            this.tenNhanVien,
            this.tongLuong});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvLuong.DefaultCellStyle = dataGridViewCellStyle10;
            this.gvLuong.GridColor = System.Drawing.Color.White;
            this.gvLuong.Location = new System.Drawing.Point(17, 111);
            this.gvLuong.Name = "gvLuong";
            this.gvLuong.ReadOnly = true;
            this.gvLuong.RowHeadersWidth = 51;
            this.gvLuong.RowTemplate.Height = 24;
            this.gvLuong.Size = new System.Drawing.Size(467, 315);
            this.gvLuong.TabIndex = 57;
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "Mã NV";
            this.maNhanVien.HeaderText = "Mã nhân viên";
            this.maNhanVien.MinimumWidth = 6;
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            this.maNhanVien.Width = 200;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "Họ Tên";
            this.tenNhanVien.HeaderText = "Tên nhân viên";
            this.tenNhanVien.MinimumWidth = 6;
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.ReadOnly = true;
            this.tenNhanVien.Width = 200;
            // 
            // tongLuong
            // 
            this.tongLuong.DataPropertyName = "Lương Ngày";
            this.tongLuong.HeaderText = "Lương trong ngày";
            this.tongLuong.MinimumWidth = 6;
            this.tongLuong.Name = "tongLuong";
            this.tongLuong.ReadOnly = true;
            this.tongLuong.Width = 250;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Linen;
            this.guna2Button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(241, 658);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(97, 41);
            this.guna2Button1.TabIndex = 78;
            this.guna2Button1.Text = "Báo nghỉ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FormLichLamViec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1097, 733);
            this.Controls.Add(this.gbLuong);
            this.Controls.Add(this.gbCa3);
            this.Controls.Add(this.gbPhanCa);
            this.Name = "FormLichLamViec";
            this.Text = "FormLichLamViec";
            this.Load += new System.EventHandler(this.FormLichLamViec_Load);
            this.gbPhanCa.ResumeLayout(false);
            this.gbPhanCa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanCa)).EndInit();
            this.gbCa3.ResumeLayout(false);
            this.gbCa3.PerformLayout();
            this.gbLuong.ResumeLayout(false);
            this.gbLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhanCa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDen;
        private Guna.UI2.WinForms.Guna2Button btnPhanCa;
        private Guna.UI2.WinForms.Guna2GroupBox gbPhanCa;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpStart;
        private Guna.UI2.WinForms.Guna2GroupBox gbCa3;
        private System.Windows.Forms.DataGridView gvPhanCa;
        private Guna.UI2.WinForms.Guna2Button btnCheckIn;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2Button btnDKCa3;
        private Guna.UI2.WinForms.Guna2Button btnHienThi;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpHienThi;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private System.Windows.Forms.DateTimePicker dp_moctime;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaNV;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpCa3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChonNgay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgay;
        private Guna.UI2.WinForms.Guna2GroupBox gbLuong;
        private System.Windows.Forms.DataGridView gvLuong;
        private System.Windows.Forms.PictureBox pbSearchLuong;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpNgayLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOut;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}