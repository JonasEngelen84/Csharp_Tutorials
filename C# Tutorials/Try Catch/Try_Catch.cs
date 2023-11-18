using System;

namespace Try_Catch
{
    class Try_Catch
    {
        public static void Ausgabe()
        {
            //Mit der try Anweisung können Sie einen Codeblock definieren,
            //der während seiner Ausführung auf Fehler getestet wird.

            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[2]);
                Console.WriteLine(numbers[6]);
            }

            //Mit der catch Anweisung können Sie einen Codeblock definieren,
            //der ausgeführt werden soll, wenn im try-Block ein Fehler auftritt.

            catch
            {
                Console.WriteLine("Es liegt ein Fehler vor.");
            }

            //Mit der finally-Anweisung können Sie einen Code ausführen,
            //nach den try...catch Code ausführungen, unabhängig vom Ergebnis.

            finally
            {
                Console.WriteLine("Abschluss der Try-Catch Funktion.");
            }
        }
    }
}
