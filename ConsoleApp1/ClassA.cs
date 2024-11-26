using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class ClassA
    {
        public  ClassA()
        {
            Console.WriteLine("Constructor in class A");

        }
        public virtual int add(int a, int b) 
        {
            return a + b;
        }
    }
}
