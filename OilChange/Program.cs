using System;
using System.Windows.Forms;

namespace OilChange
{
    static class Global
    {
        public static string FileTarget { get; set; } = "G:\\temp\\test.csv";

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
