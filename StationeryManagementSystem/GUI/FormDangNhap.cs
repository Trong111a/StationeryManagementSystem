using StationeryManagementSystem.DAO;
using StationeryManagementSystem.GUI;
using StationeryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryManagementSystem
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            pbUserName.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffc900");
            pbCloseEye.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffc900");
            pbEye.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffc900");
            lblQuen.BackColor = System.Drawing.ColorTranslator.FromHtml("#ffc900");
        }

        private void pbCloseEye_Click(object sender, EventArgs e)
        {

            if (txtPassword.PasswordChar == '*')
            {
                pbEye.BringToFront();
                txtPassword.PasswordChar = '\0';
            }
        }

        private void pbEye_Click(object sender, EventArgs e)
        {

            if (txtPassword.PasswordChar == '\0')
            {
                pbCloseEye.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == null || txtUserName.Text == "" || txtPassword.Text == null || txtPassword.Text == "")
            {
                MessageBox.Show("vui lòng nhập tên người dùng và  mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Form f = new FormMain();
            if (txtUserName.Text == "admin" && txtPassword.Text == "123")
            {
                MyDB.ConnString = MyDB.ConnAdmin;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                if (KiemTraDangNhap(txtUserName.Text, txtPassword.Text))
                {
                    MyDB.setConection(txtUserName.Text, txtPassword.Text);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool KiemTraDangNhap(string taiKhoan, string matKhau)
        {
            MyDB.ConnString = MyDB.ConnAdmin;

            string query = "SELECT MaNhanVien FROM ACCOUNT WHERE Username = @username AND Password = @password AND isAdmin = 0";
            SqlCommand cmd = new SqlCommand(query, MyDB.GetConnection);
            cmd.Parameters.AddWithValue("@username", taiKhoan);
            cmd.Parameters.AddWithValue("@password", matKhau);

            MyDB.OpenConnection();

            var employeeID = cmd.ExecuteScalar();
            if (employeeID != null)
            {
                Session.EmployeeID = employeeID.ToString(); 
                MyDB.CloseConnection();
                MyDB.Conn = null;
                return true;
            }

            MyDB.CloseConnection();
            return false;
        }

        private void lblQuen_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuenMatKhau fquenMK = new FormQuenMatKhau();
            fquenMK.FormClosed += (s, args) => this.Show();

            fquenMK.ShowDialog();
        }
    }
}
