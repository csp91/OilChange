using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using OilChange.Dto;

namespace OilChange.Util
{
    static class Toggler
    {
        public static void ToggleReadOnly(params object[] arr)
        {
            foreach(object item in arr)
            {
                if (item is System.Windows.Forms.TextBoxBase i) i.ReadOnly = !i.ReadOnly;
            }
        }
    }

    static class FileUtils
    {
        public static void CloseFileStreamers(params object[] streams)
        {
            foreach (object item in streams)
            {
                Stream s = null;
                TextWriter sw = null;
                TextReader sr = null;
                if ((s = item as Stream) is Stream || 
                    (sw = item as TextWriter) is TextWriter ||
                    (sr = item as TextReader) is TextReader)
                {
                    s?.Close();
                    sw?.Close();
                    sr?.Close();
                }
            }
        }

        public static void OpenFileStreamers(ref FileStream fsw, ref FileStream fsr, ref StreamReader sr, ref StreamWriter sw, FileMode writeMode = FileMode.Append)
        {
            string fileTarget = Global.FileTargetPath;
            if (!File.Exists(fileTarget))
            {
                File.Create(fileTarget).Close();

                for (int i = 0; i > 3; i++)
                {
                    if (File.Exists(fileTarget)) break;
                    Thread.Sleep(1500);
                }
            }

            fsw = new FileStream(fileTarget, writeMode, FileAccess.Write, FileShare.ReadWrite);
            fsr = new FileStream(fileTarget, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            sw = new StreamWriter(fsw);
            sr = new StreamReader(fsr);
        }
    }
}
