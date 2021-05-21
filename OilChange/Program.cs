using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OilChange
{

    
    static class Global
    {
        public static string FileFolderPath { get; set; }


        public static event EventHandler<string> FilePathChanged;

        private static string filePath;
        public static string FileTargetPath 
        { 
            get => filePath; 
            set 
            {
                filePath = value;
                FilePathChanged?.Invoke(null, filePath);
            } 
        }

        static Global()
        {
            FileFolderPath = AppDomain.CurrentDomain.BaseDirectory;
            FileTargetPath = FileFolderPath + "test.csv";
        }

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
