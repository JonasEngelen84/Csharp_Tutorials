using System;

namespace Finalizer_Destructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new();
            Console.WriteLine($"Länge:  {box1.Length}\nBreite: {box1.Width}\nHöhe:   {box1.Height}");

            Console.ReadKey();

            box1.~Box();
        }
    }
}
