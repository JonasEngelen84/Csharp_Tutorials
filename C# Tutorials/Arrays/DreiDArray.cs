using System;

namespace Arrays
{
    class DreiDArray
    {
        public static void Ausgabe()
        {
            Console.WriteLine("\n\n3D Array:");

            String[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"},
                    {"Jonas ", "Engelen"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Reham ", "Khamis"}
                }
            };

            Console.WriteLine($"bei 1,2,0 ist:  {array3D[1,2,0]}\n\n");
        }
    }
}
