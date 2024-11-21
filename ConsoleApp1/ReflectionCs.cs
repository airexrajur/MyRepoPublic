using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class ReflectionCs
    {
        public static void getAssembly()
        { 
            Assembly assembly= Assembly.GetExecutingAssembly();
            if (assembly != null)
            {
                FileVersionInfo fileVersionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
                Console.WriteLine($" File Version  {fileVersionInfo.FileVersion} Full Name  {assembly.FullName }");

            }
        }
    }
}
