using System;

namespace Get_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Get_Set box1 = new Get_Set();
            box1.setLength(5);
            box1.setheight(5);
            box1.setwidth(5);
            box1.Display();

            Properties box2 = new Properties
            {
                Length = 2,
                Width = 2,
                Height = -2
            };

            box2.Display();

            Console.ReadKey();
        }
    }
}
