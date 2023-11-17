using Entkapselung.Gaz;
using System;

namespace Entkapselung
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new ();
            person.SetBirthdate(new DateTime(1989, 2, 18));
            Console.WriteLine(person.GetBirthdate());
            Console.ReadLine();
        }
    }
}
