using StationeryManagementSystem.DAO;
using StationeryManagementSystem.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
            
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            string role  =  AuthenticationDAO.myAuthenticateUser(username, password);
            if (role == "Invalid credentials") {
                MessageBox.Show("Username or password is not correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Form f = new FormMain(role);
            f.Show();
            this.Hide();
        }
    }
}
