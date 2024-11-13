using StationeryManagementSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryManagementSystem.GUI
{
    public partial class FormQuenMatKhau : Form
    {
        private string connAdmin = MyDB.ConnAdmin;

        public FormQuenMatKhau()
        {
            InitializeComponent();
        }

        private void pbCloseEye1_Click(object sender, EventArgs e)
        {

            if (txtAdminPass.PasswordChar == '*')
            {
                pbEye1.BringToFront();
                txtAdminPass.PasswordChar = '\0';
            }
        }

        private void pbEye1_Click(object sender, EventArgs e)
        {
            if (txtAdminPass.PasswordChar == '\0')
            {
                pbCloseEye1.BringToFront();
                txtAdminPass.PasswordChar = '*';
            }
        }

        private void pbEye2_Click(object sender, EventArgs e)
        {
            if (txtUserPass.PasswordChar == '\0')
            {
                pbCloseEye2.BringToFront();
                txtUserPass.PasswordChar = '*';
            }
        }

        private void pbCloseEye2_Click(object sender, EventArgs e)
        {
            if (txtUserPass.PasswordChar == '*')
            {
                pbEye2.BringToFront();
                txtUserPass.PasswordChar = '\0';
            }
        }

        private void btnForgot_Click(object sender, EventArgs e)
        {
            string adminUsername = txtAdminName.Text;
            string adminPassword = txtAdminPass.Text;
            string employeeUsername = txtUserName.Text;
            string newPassword = txtUserPass.Text;

            if (string.IsNullOrEmpty(adminUsername) || string.IsNullOrEmpty(adminPassword) || string.IsNullOrEmpty(employeeUsername) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthenticateAdmin(adminUsername, adminPassword))
            {
                ResetEmployeePassword(employeeUsername, newPassword);
            }
            else
            {
                MessageBox.Show("Admin authentication failed. Please check your credentials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateAdmin(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connAdmin))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM ACCOUNT WHERE Username = @username AND Password = @password AND isAdmin = 1";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int result = (int)cmd.ExecuteScalar();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error authenticating admin: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void ResetEmployeePassword(string username, string newPassword)
        {
            using (SqlConnection conn = new SqlConnection(connAdmin))
            {
                try
                {
                    conn.Open();

                    string updateAccountQuery = "UPDATE ACCOUNT SET Password = @newPassword WHERE Username = @username";
                    using (SqlCommand cmd = new SqlCommand(updateAccountQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@newPassword", newPassword);
                        cmd.Parameters.AddWithValue("@username", username);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                           
                            string updateLoginQuery = $"ALTER LOGIN [{username}] WITH PASSWORD = '{newPassword}'";
                            using (SqlCommand alterCmd = new SqlCommand(updateLoginQuery, conn))
                            {
                                alterCmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Password reset successfully for user " + username, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User not found or failed to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error resetting password: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
