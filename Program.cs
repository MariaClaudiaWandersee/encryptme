using System;
using System.Windows.Forms;
using Views;

namespace EncryptMe
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Login());
        }
    }
}