using SuwarSuwirApp.Controllers;
using SuwarSuwirApp.Models;
using SuwarSuwirApp.Views;
using System;
using System.Windows.Forms;

namespace SuwarSuwirApp
{
    internal static class Program
    {
        // Connection string default sesuai permintaan
        public static string ConnectionString = "Host=localhost;Port=5432;Database=suwarsuwirfixplis;Username=postgres;Password=postgresql;";

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Inisialisasi DbContextFactory singleton sederhana
            M_DbContextFactory factory = new M_DbContextFactory(ConnectionString);

            // Buka form login utama
            Application.Run(new V_LoginForm(factory));
        }
    }
}
