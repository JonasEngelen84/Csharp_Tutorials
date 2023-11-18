using System;

namespace Arrays
{
    class EinfachesArray
    {
        static void ArrayAusgabe(int[] intAr)
        {
            foreach (int number in intAr)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");
        }

        public static void Ausgabe()
        {
            Console.WriteLine("EINFACHES ARRAY:");

            //Deklarierung und Initialisierung eines Arrays:
            int[] intArray = new int[10];
            intArray[0] = 1; intArray[1] = 2; intArray[2] = 3; intArray[3] = 4; intArray[4] = 5;
            intArray[5] = 6; intArray[6] = 7; intArray[7] = 8; intArray[8] = 9; intArray[9] = 10;

            // Kurzform:
            string[] stringArray = { "Mein", "Hund", "leckt", "mir", "jeden", "Morgen", "die", "Füße", "und", "die", "Eier." };


            // Gesamtes Array ausgeben:
            Console.WriteLine(string.Join(' ', stringArray));

            foreach(string str in stringArray)
            {
                Console.Write(str + " ");
            }

            // Index eines Arrays ausgeben:
            Console.WriteLine("\n\nBei Index 1 von stringArray ist der Wert: " + stringArray[1]);
            

            // Eigenschaften:
            Console.WriteLine("\nEigenschaften:\n"
                             +"IsFixedSize => Gibt an, ob ein Array eine fixiete Größe hat: " + stringArray.IsFixedSize + "\n");

            Console.WriteLine("IsReadOnly => Gibt an, ob ein Array schreibgeschüzt ist: " + stringArray.IsReadOnly + "\n");

            Console.WriteLine("IsSynchronized => Gibt an, ob der Zugriff auf ein Array threadsicher ist: " + stringArray.IsSynchronized + "\n");

            Console.WriteLine("Length => Gibt die Gesamtanzahl der Elemente in allen Dimensionen im Array an: " + stringArray.Length + "\n");

            Console.WriteLine("Rank => Gibt die Anzahl von Spalten (Dimensionen) an: " + stringArray.Rank + "\n");

            Console.WriteLine("SyncRoot => Ruft ein Objekt ab, mit dem der Zugriff auf Array synchronisiert werden kann: " + stringArray.SyncRoot + "\n");


            // Methoden:
            Console.WriteLine("\nMethoden:\n"
                              +$"Clone() => Erstellt eine einfache Kopie eines Arrays in ein anderes Array.");
            int[] cloneIntArray = (int[])intArray.Clone();
            ArrayAusgabe(cloneIntArray);

            Console.WriteLine($"Clear() => Legt einen Bereich von Elementen in einem Array mit dem Standardwert der einzelnen Elementtypen fest.");
            Array.Clear(cloneIntArray, 2, 6);
            ArrayAusgabe(cloneIntArray);
            cloneIntArray = intArray;
                        
            Console.WriteLine($"ConstrainedCopy() => Kopiert einen beim angegebenen Quellindex beginnenden Elementbereich aus einem Array\n"
                              +"und fügt ihn ab dem angegebenen Zielindex in ein anderes Array ein.");
            Array.ConstrainedCopy(intArray, 0, cloneIntArray, 3, 5);
            ArrayAusgabe(cloneIntArray);
            cloneIntArray = intArray;

            Console.WriteLine("Equals() => Führt einen Typ-Vergleich zweier Arrays durch:\n"
                            +cloneIntArray.Equals(intArray) + "\n" + cloneIntArray.Equals(stringArray) + "\n");

            Console.WriteLine("GetHashCode() => Gibt den Hashcode zurück: " + stringArray.GetHashCode() + "\n");

            Console.WriteLine("GetType() => Gibt den Type der des Arrays zurück: " + stringArray.GetType() + "\n");

            Console.WriteLine("GetValue() => Gibt den Wert eines Index (hier \"4\") zurück: " + stringArray.GetValue(4) + "\n");

            Console.WriteLine("IndexOf() => Gibt den Index eines Wertes (hier \"Morgen\") zurück: " + Array.IndexOf(stringArray, "Morgen") + "\n");

            Console.WriteLine("LastIndexOf() => Sucht nach einem Wert (hier \"die\") und gibt den Index des "
                             + "letzten Vorkommens,\ndas sich vom ersten Element bis zum angegebenen Index erstreckt, zurück: " + Array.LastIndexOf(stringArray, "die", 8) + "\n");

            Console.WriteLine("Reverse() => Kehrt die Reihenfolge einer Teilmenge der Elemente im gesamten eindimensionalen Array um:");
            Array.Reverse(cloneIntArray, 2, 7);
            ArrayAusgabe(cloneIntArray);

            Console.WriteLine("Sort() => Sortiert die Elemente in einem Array mithilfe der IComparable-Implementierung jedes Elements des Array:");
            Array.Sort(intArray);
            ArrayAusgabe(intArray);
        }
    }
}
