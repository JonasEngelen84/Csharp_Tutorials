using System;
using System.Collections.Generic;

namespace Lambda
{
    class DelegatesUndLambda
    {
        /*
        Ein Delegat ist ein Typ, der Verweise auf Methoden mit einer bestimmten
        Parameterliste und dem Rückgabetyp darstellt.Nach Instanziierung eines
        Delegaten können Sie die Instanz mit einer beliebigen Methode verknüpfen,
        die eine kompatible Signatur und einen kompatiblen Rückgabetyp aufweist.
        Sie können die Methode über die Delegatinstanz aufrufen.

        Delegaten werden verwendet, um Methoden als Argumente an anderen Methoden
        zu übergeben.Ereignishandler sind nichts weiter als Methoden, die durch
        Delegaten aufgerufen werden.Wenn Sie eine benutzerdefinierte Methode erstellen,
        kann eine Klasse wie das Windows-Steuerelement diese Methode aufrufen,
        sobald ein bestimmtes Ereignis eintritt.
        **/

        public delegate int SomeMath(int i);
        public delegate bool Compare(int i, Number n);

        public static void DoSomething()
        {
            SomeMath math = new SomeMath(Square);
            Console.WriteLine(math(8));

            Console.WriteLine();

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6};

            // Hier wird ein Delegat bei seiner Übergabe erstellt.
            List<int> geradeZahlen = list.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
            });

            foreach(int i in geradeZahlen)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            // Hier das gleiche als Lambda Ausdruck (mit ungeraden Zahlen).
            List<int> ungeradeZahlen = list.FindAll(i => i % 2 == 1);
            ungeradeZahlen.ForEach(i => Console.WriteLine(i));

            Console.WriteLine();

            // oder bei mehreren angaben im Lambda-Ausdruck:
            ungeradeZahlen.ForEach(i =>
            {
                Console.Write("Zahl: ");
                Console.WriteLine(i);
            });

            Console.WriteLine();

            // Mehr Lambda spielerei:
            math = new SomeMath(i => i * i * i);
            Console.WriteLine(math(6));

            Console.WriteLine();

            // Noch mehr Lambda
            // Hier werden 2 Parameter erwartet (i, number)
            Compare comp = (i, number) => i == number.n;
            Console.WriteLine(comp(5, new Number { n = 5}));
        }

        public static int Square(int i)
        {
            return i * i;
        }
    }

    public class Number
    {
        public int n { get; set; }
    }
}
