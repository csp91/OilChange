using OilChange.Dto;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OilChange
{
    static class Global
    {
        //PRIVATE FIELDS
        private static string filePath;

        //PUBLIC GLOBAL FIELDS
        public static event EventHandler<string> FilePathChanged;
        public static string BaseDirectory { get; set; }
        public static string FileTargetPath
        {
            get => filePath;
            set
            {
                filePath = value;
                FilePathChanged?.Invoke(null, filePath);
            }
        }

        public static List<OilChangeInfo> MainArraySource { get; set; }

        //Constructor
        static Global()
        {
            BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            FileTargetPath = BaseDirectory + "test.csv";
            MainArraySource = new List<OilChangeInfo>();
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
