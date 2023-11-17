using System;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Lambda.Ausgabe1();
            Lambda.Ausgabe2();
            Console.WriteLine();
            DelegatesUndLambda.DoSomething();
            Console.ReadKey();
        }
    }
}
