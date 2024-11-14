namespace StationeryManagementSystem.GUI
{
    partial class DudoanDoanhThu
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
            this.dtg_doanhthu = new System.Windows.Forms.DataGridView();
            this.btn_dudoan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.Month = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDoanhThuDuDoan = new System.Windows.Forms.Label();
            this.cbb_month = new System.Windows.Forms.ComboBox();
            this.cbb_year = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_doanhthu
            // 
            this.dtg_doanhthu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_doanhthu.Location = new System.Drawing.Point(30, 27);
            this.dtg_doanhthu.Name = "dtg_doanhthu";
            this.dtg_doanhthu.RowHeadersVisible = false;
            this.dtg_doanhthu.RowHeadersWidth = 60;
            this.dtg_doanhthu.RowTemplate.Height = 24;
            this.dtg_doanhthu.Size = new System.Drawing.Size(411, 374);
            this.dtg_doanhthu.TabIndex = 0;
            // 
            // btn_dudoan
            // 
            this.btn_dudoan.Location = new System.Drawing.Point(340, 421);
            this.btn_dudoan.Name = "btn_dudoan";
            this.btn_dudoan.Size = new System.Drawing.Size(101, 32);
            this.btn_dudoan.TabIndex = 1;
            this.btn_dudoan.Text = "Dự đoán";
            this.btn_dudoan.UseVisualStyleBackColor = true;
            this.btn_dudoan.Click += new System.EventHandler(this.btn_dudoan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dự đoán doanh thu";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(637, 12);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 22);
            this.txtThang.TabIndex = 4;
            this.txtThang.Visible = false;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(747, 54);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 22);
            this.txtNam.TabIndex = 5;
            this.txtNam.Visible = false;
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Location = new System.Drawing.Point(485, 54);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(43, 16);
            this.Month.TabIndex = 6;
            this.Month.Text = "Month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Year";
            // 
            // lblDoanhThuDuDoan
            // 
            this.lblDoanhThuDuDoan.AutoSize = true;
            this.lblDoanhThuDuDoan.Location = new System.Drawing.Point(485, 237);
            this.lblDoanhThuDuDoan.Name = "lblDoanhThuDuDoan";
            this.lblDoanhThuDuDoan.Size = new System.Drawing.Size(19, 16);
            this.lblDoanhThuDuDoan.TabIndex = 8;
            this.lblDoanhThuDuDoan.Text = "---";
            this.lblDoanhThuDuDoan.Click += new System.EventHandler(this.lblDoanhThuDuDoan_Click);
            // 
            // cbb_month
            // 
            this.cbb_month.FormattingEnabled = true;
            this.cbb_month.Location = new System.Drawing.Point(572, 51);
            this.cbb_month.Name = "cbb_month";
            this.cbb_month.Size = new System.Drawing.Size(121, 24);
            this.cbb_month.TabIndex = 9;
            // 
            // cbb_year
            // 
            this.cbb_year.FormattingEnabled = true;
            this.cbb_year.Location = new System.Drawing.Point(572, 112);
            this.cbb_year.Name = "cbb_year";
            this.cbb_year.Size = new System.Drawing.Size(121, 24);
            this.cbb_year.TabIndex = 10;
            // 
            // DudoanDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 481);
            this.Controls.Add(this.cbb_year);
            this.Controls.Add(this.cbb_month);
            this.Controls.Add(this.lblDoanhThuDuDoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dudoan);
            this.Controls.Add(this.dtg_doanhthu);
            this.Name = "DudoanDoanhThu";
            this.Text = "Dự đoán doanh thu";
            this.Load += new System.EventHandler(this.DudoanDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_doanhthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_doanhthu;
        private System.Windows.Forms.Button btn_dudoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDoanhThuDuDoan;
        private System.Windows.Forms.ComboBox cbb_month;
        private System.Windows.Forms.ComboBox cbb_year;
    }
}