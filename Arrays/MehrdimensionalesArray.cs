using System;

namespace Arrays
{
    class MehrdimensionalesArray
    {
        public static void Ausgabe()
        {
            Console.WriteLine("\n\nMehrdimensionales Array:");

            // , <= Das Komma und Angabe der Anzahl der Zeilen und Spalten ist ZWINGEND!!!!!!
            String[,] names = new string[4, 2]
            {
                { "Jonas ", "Engelen"},
                {"Max ", "Engelen" },
                { "Dillon ", "Cornelius" },
                { "Luca ", "Schmidt" }
            };
            

            //names.Length = gesamte Array Länge / names.Rank = Dimensionenanzahl

            //Da names.Length die gesamte Anzahl der Werte beinhaltet (8),
            //muss "Length" durch "Rank" geteilt werden, weil "Rank" die tatsächliche
            //Anzahl an Arrays beinhaltet (4).
            for (int i = 0; i < (names.Length / names.Rank); i++)
            {
                for (int j = 0; j < names.Rank; j++)
                {
                    Console.Write(names[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
