using Microsoft.Data.SqlClient;
using WinFormsApp1.Repositories.WalletRepositories;
using WinFormsApp1.Services.WalletServices;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            MainForm mainForm = new MainForm();
            AppController appController = new AppController(mainForm);

            Application.Run(mainForm);
        }
    }

    public delegate void MyEventHandler();
}