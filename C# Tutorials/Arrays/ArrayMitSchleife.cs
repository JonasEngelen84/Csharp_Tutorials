using System;

namespace Arrays
{
    class ArrayMitSchleife
    {
        public static void Ausgabe()
        {
            Console.WriteLine("\n\nArray mit Schleife:");

            String[] names = new string[]
            { 
                "Skrotum",
                "Maxwell",
                "Dillion",
                "Lulu",
                "Bebe"
            };

            foreach (String name in names)
            {
                Console.WriteLine("Hallo " + name);
            }
        }
    }
}
