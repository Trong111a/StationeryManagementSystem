using StationeryManagementSystem.DAO;
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
            string query = "select count(*) from Account where Username = '" + taiKhoan + "' and Password = '" + matKhau + "' ";
            MyDB.ConnString=MyDB.ConnAdmin;
            SqlCommand cmd = new SqlCommand(query, MyDB.GetConnection);
            MyDB.OpenConnection();
            if ((int)cmd.ExecuteScalar() > 0)
            {
                MyDB.CloseConnection();
                MyDB.Conn = null;
                return true;
            }
            MyDB.CloseConnection();
            return false;

        }

    }
}
