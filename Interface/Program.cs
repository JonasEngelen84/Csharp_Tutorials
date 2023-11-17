using System;
using Interface.Gaz;
using Interface.WEINI;

namespace Interface
{
    class Program
    {
        static void Print(IDrucker p)
        {
            p.Print();
        }

        static void Main(string[] args)
        {
            //WEINI
            //Console.WriteLine("WEINI");
            Bildschirm bildschirm1 = new ();
            Datei datei1 = new ();

            Print(bildschirm1);
            Print(datei1);


            Console.WriteLine("\n\nGAZ");


            //GAZ
            ConsoleLogger consoleLogger = new();
            MyProgram program = new(consoleLogger);
            program.MakeSometingRight();
            program.MakeSometingWrong();
            program.MakeSometingRight();

            Console.ReadLine();
        }
    }
}
