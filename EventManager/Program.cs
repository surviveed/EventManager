using EventManager.Views.HomeAdmin;
using System;
using System.Windows.Forms;

namespace EventManager
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmHomeAdmin());
        }
    }
}
