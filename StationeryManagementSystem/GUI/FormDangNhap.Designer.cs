namespace StationeryManagementSystem
{
    partial class FormDangNhap
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
            this.lblQuen = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pbCloseEye = new System.Windows.Forms.PictureBox();
            this.pbUserName = new System.Windows.Forms.PictureBox();
            this.pbEye = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuen
            // 
            this.lblQuen.AutoSize = true;
            this.lblQuen.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuen.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblQuen.Location = new System.Drawing.Point(389, 283);
            this.lblQuen.Name = "lblQuen";
            this.lblQuen.Size = new System.Drawing.Size(138, 23);
            this.lblQuen.TabIndex = 12;
            this.lblQuen.Text = "Quên mật khẩu";
            this.lblQuen.Click += new System.EventHandler(this.lblQuen_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(389, 233);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 30);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(389, 174);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(260, 30);
            this.txtUserName.TabIndex = 7;
            // 
            // pbCloseEye
            // 
            this.pbCloseEye.BackColor = System.Drawing.Color.White;
            this.pbCloseEye.BackgroundImage = global::StationeryManagementSystem.Properties.Resources.Invisible;
            this.pbCloseEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCloseEye.Location = new System.Drawing.Point(330, 233);
            this.pbCloseEye.Name = "pbCloseEye";
            this.pbCloseEye.Size = new System.Drawing.Size(42, 30);
            this.pbCloseEye.TabIndex = 10;
            this.pbCloseEye.TabStop = false;
            this.pbCloseEye.Click += new System.EventHandler(this.pbCloseEye_Click);
            // 
            // pbUserName
            // 
            this.pbUserName.BackColor = System.Drawing.Color.White;
            this.pbUserName.BackgroundImage = global::StationeryManagementSystem.Properties.Resources.user;
            this.pbUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUserName.Location = new System.Drawing.Point(330, 174);
            this.pbUserName.Name = "pbUserName";
            this.pbUserName.Size = new System.Drawing.Size(42, 30);
            this.pbUserName.TabIndex = 9;
            this.pbUserName.TabStop = false;
            // 
            // pbEye
            // 
            this.pbEye.BackColor = System.Drawing.Color.White;
            this.pbEye.BackgroundImage = global::StationeryManagementSystem.Properties.Resources.Eye;
            this.pbEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEye.Location = new System.Drawing.Point(330, 233);
            this.pbEye.Name = "pbEye";
            this.pbEye.Size = new System.Drawing.Size(42, 30);
            this.pbEye.TabIndex = 11;
            this.pbEye.TabStop = false;
            this.pbEye.Click += new System.EventHandler(this.pbEye_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnLogin.Location = new System.Drawing.Point(433, 334);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(124, 33);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StationeryManagementSystem.Properties.Resources.vpp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 487);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblQuen);
            this.Controls.Add(this.pbCloseEye);
            this.Controls.Add(this.pbUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pbEye);
            this.DoubleBuffered = true;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblQuen;
        private System.Windows.Forms.PictureBox pbCloseEye;
        private System.Windows.Forms.PictureBox pbUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.PictureBox pbEye;
        private System.Windows.Forms.Button btnLogin;
    }
}