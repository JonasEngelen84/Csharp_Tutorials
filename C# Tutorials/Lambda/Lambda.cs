using System;

namespace Lambda
{
    class Lambda
    {
        static void Test()
        {
            Console.WriteLine("Es funtioniert!");
        }

        public static void Ausgabe1()
        {
            Test();
        }

        //Lambda Schreibform
        public static void Ausgabe2() => Test();
    }
}
