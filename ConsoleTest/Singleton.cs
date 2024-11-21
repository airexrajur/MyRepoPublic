using System.Diagnostics.Metrics;
using System.Reflection;

namespace ConsoleTest
{
    public sealed class Singleton
    {
        private static Singleton? instance = null;
        private static int _counter = 0;
        private static readonly object padlock = new object();

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                            Console.WriteLine("First instance of Singleton");
                        }
                        Console.WriteLine("Existing instance of Singleton");
                       
                    }
                }
                Console.WriteLine("Existing instance of Singleton2");
                return instance;
            }
        }

        private Singleton()
        {
            _counter++;
            Console.WriteLine("Counter Value " + _counter.ToString());
        }
    }
}