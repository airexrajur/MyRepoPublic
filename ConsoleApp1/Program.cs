using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void Calci(int a, int b);
    delegate int mt();
    internal class Program
    {
        public static void Add(int a, int b) 
        {
            Console.WriteLine(a + " + " + b);
            Console.WriteLine(a + b);
        }

        public static void Mul(int a, int b) 
        {
            Console.WriteLine(a + " * " + b);
            Console.WriteLine(a * b);

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Calss A called");
            Console.WriteLine("Calsssb classed");
            return;
            Calci calci = new Calci(Add);
            //calci(2, 3);
            calci += Mul;
            calci.Invoke(2, 3);
            ClassDEmoDispose classDEmoDispose = new ClassDEmoDispose();
            classDEmoDispose.Dispose();
            Console.WriteLine("Delegate End");

            Sqltest.Testconnection();
            mt objmt = new mt(Mutitasking.Method1);
            objmt += Mutitasking.Method2;
            objmt += Mutitasking.Method3;
            Console.WriteLine("Multitask Start");
            //Task task1 = Task.Run(() => { Console.WriteLine(Mutitasking.Method1()); });
           Task task2 = Task.Run(() => { Console.WriteLine(); Console.WriteLine(Mutitasking.Method2()); });
            Mutitasking.Method1_2();
            Task task3 = Task.Run(() => {Console.WriteLine(Mutitasking.Method3());});
            Console.WriteLine("Mutitask end");
            ReflectionCs.getAssembly();

            Console.Read();
        }
    }
}
