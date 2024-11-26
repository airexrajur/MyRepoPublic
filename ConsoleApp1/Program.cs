using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void Calci(int a, int b);
    delegate int mt();
    delegate void Llink();
    internal class Program
    {
        public static object AsyncState { get;  set; }
        public static AsyncCallback cb { get;  set; }

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

            // Console.WriteLine("Calss A called");

            // Console.WriteLine("Calsssb Called");
          //  ClassA classb = new Classb();
            Console.WriteLine("");
            Classb classbb = new Classb();

            Console.WriteLine(classbb.add(1, 2));
            ClassA classa = new ClassA();

            Console.WriteLine(classa.add(1, 2));

            Linqtest linqtest = new Linqtest();
            Llink llink = new Llink(linqtest.getALLstudents);
            llink += linqtest.groupby;
            llink += linqtest.getStudentwithGrade;
            llink += linqtest.oldeststud;
            llink += linqtest.pagination;
            llink.Invoke();
            //IAsyncResult asyncResult = llink.BeginInvoke( cb,  AsyncState);
            //llink.EndInvoke(asyncResult);

            Calci calci = new Calci(Add);
            //calci(2, 3);
            // calci += Mul;
            //calci.Invoke(2, 3);
            
            IAsyncResult asyncCalciResult = calci.BeginInvoke(2, 3, cb, AsyncState);
            //Begin invoek can be called only fro one method
            //calci.EndInvoke(asyncCalciResult);

            ClassDEmoDispose classDEmoDispose = new ClassDEmoDispose();
            classDEmoDispose.Dispose();
            if (!string.IsNullOrEmpty(asyncCalciResult) && asyncCalciResult.IsCompleted)
            {
                calci.EndInvoke(asyncCalciResult);
            }
            Console.WriteLine("Delegate End");

            Sqltest.Testconnection();
            mt objmt = new mt(Mutitasking.Method1);
            objmt += Mutitasking.Method2;
            objmt += Mutitasking.Method3;
            Console.WriteLine("Multitask Start");
            Task task1 = Task.Run(() => { Console.WriteLine(Mutitasking.Method1()); });
           Task task2 = Task.Run(() => { Console.WriteLine(); Console.WriteLine(Mutitasking.Method2()); });
            Mutitasking.Method1_2();
            Task task3 = Task.Run(() => {Console.WriteLine(Mutitasking.Method3());});
            Console.WriteLine("Mutitask end");
            ReflectionCs.getAssembly();

            Console.Read();
        }
    }
}
