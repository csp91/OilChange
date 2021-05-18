using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
