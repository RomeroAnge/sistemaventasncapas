using SistemasVentas.VISTA.LoginVistas;
using System.Security.Cryptography.X509Certificates;

namespace SistemasVentas.VISTA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static LoginUser loginuser;
        [STAThread]
        static void Main()
        {
            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(loginuser =new LoginUser());
            //Application.Run(new VendedorVistas.VendedorHistorialVentasVista());
        }
    }
}