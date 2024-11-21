using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Mutitasking
    {
        public static int Method1()
        {
            Thread.Sleep(500);
            //Console.WriteLine("10");
            return 10;
        }
        public static int Method2() {
            //Console.WriteLine("20");
            return 20;
        }
        public static int Method3() {
            //Console.WriteLine("30");
            return 30;
        }
        public static async void Method1_2()
        {
            Console.WriteLine(
                "Tesst Asnc");
            var i = await Task.Run(() => { return Method1(); });
            Console.WriteLine(i);
            int j = Method1_3(i);
            Console.WriteLine(j);

        }

        private static int Method1_3(int i)
        {
            return 10 * i;
        }
    }
}
