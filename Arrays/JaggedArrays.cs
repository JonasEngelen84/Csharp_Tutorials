using System;

namespace Arrays
{
    public class JaggedArrays
    {
        public static void VerzweigtesArrayMitForSchleife()
        {
            int[][] jaggedArray = new int[3][]
            {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
            };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine($"Element {i} beeinhaltet:");

                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }
                Console.WriteLine();
            }

        }

        public static void VerzweigtesArrayMitForeachSchleife()
        {
            string[] Hähndelen = new string[] { "Michael", "Laura", "Mila", "Juna" };
            string[] Spielmann_Engelen = new string[] { "Wolfgang", "Birgit", "Maximilian" };
            string[] Khamis = new string[] { "Reham", "Salum", "Amr", "Eyas", "Emely" };

            string[][] Families = new string[3][]
            {
            Hähndelen,
            Spielmann_Engelen,
            Khamis
            };

            int counter = 0;
            foreach (string[] row in Families)
            {
                Console.WriteLine($"Familie {Families[counter]}");

                foreach (string column in Families[counter])
                {
                    Console.WriteLine(column);
                }
                counter++;
                Console.WriteLine();
            }
        }
    }
}