using ConsoleTest;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Calci calci = new Calci(Add);
        calci(1, 2);
        calci.Invoke(2, 4);
        calci = new Calci(Mul);
        calci.Invoke(2, 4);

        static void Mul(int a, int b)
        {

            Console.WriteLine(a + " * " + b);
            Console.WriteLine(a * b);

        }

        Calci calci1 = new Calci(Mul);
        calci1 += Add;
        calci1.Invoke(4, 6);

        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Subtract(4, 2));

        List<int> listint = new List<int>() { 1, 2, 3, 4 };
        listint.Where(a=> a % 2==0).ToList().ForEach(a=>Console.WriteLine(a));

var oobj=Singleton.Instance;
Console.WriteLine(oobj);
Console.WriteLine(" ");
Console.WriteLine(Singleton.Instance);

string result="123";
result.IsNullOrEmpty();

        Console.Read();

    }

    private static void Add(int a, int b)
    {
        Console.WriteLine(a + " + " + b);
        Console.WriteLine(a + b);
    }
}

delegate void Calci(int a, int b);
