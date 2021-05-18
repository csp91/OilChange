using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace OilChange
{

    
    static class Global
    {
        public static event EventHandler<string> FilePathChanged;

        public static string FileFolderPath { get; set; }
        private static string file;
        public static string FileTarget 
        { 
            get => file; 
            set 
            {
                file = value;
                FileChanged();
            } 
        }

        static Global()
        {
            FileFolderPath = AppDomain.CurrentDomain.BaseDirectory;
            FileTarget = FileFolderPath + "test.csv";
        }

        public static void FileChanged()
        {
            FilePathChanged?.Invoke(null, FileTarget);
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
