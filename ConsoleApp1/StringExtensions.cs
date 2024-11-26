using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class StringExtensions
    {
        public static string IsNullOrEmpty(string str) 
        {
            if (str != null && !string.IsNullOrEmpty(str))
            {
                return str;
            }
            else { 
                return string.Empty;
            }
        }

        public static object IsNullOrEmpty(object str)
        {
            if (str != null )
            {
                return str;
            }
            else
            {
                return string.Empty;
            }
        }


    }
}
