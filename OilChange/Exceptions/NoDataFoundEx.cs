using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilChange.Exceptions
{
    class NoDataFoundException: Exception
    {
        public NoDataFoundException(String message) : base(message)
        {
        }
    }
}
