using StationeryManagementSystem;
using StationeryManagementSystem.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryManagementSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormDangNhap formDangNhap = new FormDangNhap();
            if (formDangNhap.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormMain());
            }
        }
    }
}
