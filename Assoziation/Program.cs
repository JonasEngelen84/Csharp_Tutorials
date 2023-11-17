using Assoziation.Gaz;
using System;

namespace Assoziation
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new("gaz");
            Card card = new ("312513624623");
            manager.Login(card);
            Console.ReadLine();
        }
    }
}
