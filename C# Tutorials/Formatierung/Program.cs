using System;

namespace Formatierung
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Fred";
            string test = string.Format("Name = {0}, hours = {1:hh}, minutes = {1:mm}", name, DateTime.Now);
            string FormatString1 = string.Format("{0:dddd MMMM}", DateTime.Now);
            int MyInt = 100;
            int value = 6324;
            Console.WriteLine("{5}\n{3}\n{4}\n{0}{1:D}{2}\n", "{", value, "}", FormatString1, MyInt, test);



            string test1 = "funktioniert";
            Console.WriteLine($"Auf diese Weise {test1} es auch zu {MyInt}%");

            Console.ReadKey();
        }
    }
}
