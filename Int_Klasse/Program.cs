using System;

namespace Klasse_int
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "333";


            int int1 = int.Parse(string1);
            Console.WriteLine("Von string zu int parsen:" + int1.ToString().PadLeft(19, '-'));

            bool bool1 = int.TryParse(string1, out _);
            Console.WriteLine("TryParse: Test auf geglücktes parsen:    " + bool1);

            string string2 = int1.ToString();
            Console.WriteLine("Von int zu string konvertieren:" + string2.ToString().PadLeft(13));

            double double1 = (double)int1 + 0.5;
            Console.WriteLine("Von int zu double casten:" + double1.ToString().PadLeft(21));

            Console.WriteLine("string und int zusammenfügen:" +  (string2 + int1).ToString().PadLeft(18));

            Console.WriteLine("Addieren mit int-Werten:" + (int1 + int1).ToString().PadLeft(20));

            int1 = int.MaxValue;
            Console.WriteLine("Ausgabe des höchsten int-Wertes:" + int1.ToString().PadLeft(19, '*'));

            int1 = int.MinValue;
            Console.WriteLine("Ausgabe des niedrigsten int-Wertes:" + int1.ToString().PadLeft(17));
        }
    }
}
