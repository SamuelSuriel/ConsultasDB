using ConsultasDB.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ConsultasDB.Clases
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
            Application.Run(new frmConsultaBiblioteca());
        }
    }
}