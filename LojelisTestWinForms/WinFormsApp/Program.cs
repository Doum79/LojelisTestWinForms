using System;
using System.Windows.Forms;
using WinFormsApp.Classes;

namespace WinFormsApp.Forms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ScoreSerializer.CreateSamples();
            Application.Run(new Form1());
        }
    }
}
