using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Classb : ClassA
    {
        public  Classb()
        {
            Console.WriteLine("Constructor in class B");

        }
        public override int add(int a, int b)
        {
            return a + b+1;
        }
    }
}
