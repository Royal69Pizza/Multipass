using System;
using System.Windows.Forms;

namespace Multipass
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            /**| Ordre d'apparition des form |**/
            Application.Run(new Login());
        }
    }
}
