namespace Lists
{
    internal class ListT
    {
        // Liste deklarieren und initialisieren:
        static List<string> autos = new List<string>()
        {
            "Audi",
            "BMW",
            "Volkswagen"
        };

        // Initialisieren der Liste:
        static void AddCarsToAutos()
        {
            autos.Add("Audi");
            autos.Add("BMW");
            autos.Add("Volkswagen");
            autos.Add("Mercedes Benz");
            autos.Add("Opel");
            autos.Add("Seat");
            autos.Add("Hyundai");
            autos.Add("Nissan");
            autos.Add("Mercedes Benz");
            autos.Add("Nissan");
            autos.Add("Renault");
        }

        // List in List:
        public static void ListInList()
        {
            List<List<string>> myList = new List<List<string>>();
            myList.Add(new List<string> { "a", "b" });
            myList.Add(new List<string> { "c", "d", "e" });
            myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
            myList.Add(new List<string> { "y", "z" });

            Console.WriteLine("List in List:");
            foreach (List<string> subList in myList)
            {
                Console.WriteLine(string.Join(", ", subList));
            }

            Console.WriteLine("\n" + myList[1][1]);
        }

        // Hilfs-Array:
        static string[] test = new string[16];

        
        public static void ListTAusgabe()
        {
            // Liste/Instanz ausgeben:
            Console.WriteLine(string.Join('-', autos) + "\n");

            foreach (string auto in autos)
            {
                Console.Write(auto + "   ");
            }

            Console.WriteLine("\n\n" + autos[2]);


            //Eigenschaften:
            Console.WriteLine("\n\nEigenschaften:\n"
                            + "Capacity => Ruft die Gesamtzahl der Elemente ab, die die interne Datenstruktur"
                            + $"ohne Änderung der Größe aufnehmen kann,\noder legt diese Anzahl fest: {autos.Capacity}\n");

            Console.WriteLine($"Count => Gibt die Anzahl der Elemente ab, die in List<T> enthalten sind: {autos.Count}\n");


            //Methoden:
            Console.WriteLine("\n\nMethoden:\n"
                            + $"Add() => Fügt ein Element in die Liste: "); autos.Add("Mercedes Benz"); Console.WriteLine(string.Join('-', autos) + "\n");

            Console.WriteLine($"AsReadOnly() => Gibt einen schreibgeschützten ReadOnlyCollection<T>-Wrapper für die aktuelle Auflistung zurück:\n{autos.AsReadOnly()}\n");

            Console.WriteLine($"Clear() => Entfernt alle Elemente aus der Liste: \n"); autos.Clear(); AddCarsToAutos();

            Console.WriteLine($"Contains() => Gibt an, ob sich ein angegebenes Element in der Liste befindet: {autos.Contains("Hyundai")}\n");

            Console.WriteLine("CopyTo() => Kopiert eine Liste in ein kompatibles eindimensionales Array,\n"
                            + $"beginnend am angegebenen Index des Zielarrays "); autos.CopyTo(test, 4); Console.WriteLine(string.Join('-', test) + "\n");

            Console.WriteLine("EnsureCapacity() => Stellt sicher, dass die Kapazität dieser Liste mindestens der angegebene Kapazität ist.\n"
                            + "Wenn die aktuelle Kapazität kleiner als die Kapazität ist, wird sie nacheinander auf zweimal die aktuelle\n"
                            + $"Kapazität erhöht, bis sie mindestens die angegebene Kapazität hat: {autos.EnsureCapacity(15)}\n");

            Console.WriteLine($"GetRange() => Erstellt eine flache Kopie eines Bereichs von Elementen in der Quell-List: {string.Join('-', autos.GetRange(2, 3))}\n");

            Console.WriteLine($"IndexOf() => Gibt den Index des ersten Vorkommens des angegebenen Objekts aus der Liste zurück\n"
                            + $"(mit Startindex und Anzahl der vorkommenden Elemente): {autos.IndexOf("Mercedes Benz", 6, 3)}\n");

            Console.WriteLine($"Insert() => Fügt am angegebenen Index ein Element in die Liste ein: "); autos.Insert(2, "Fiat"); Console.WriteLine(string.Join('-', autos) + "\n");

            Console.WriteLine("LastIndexOf() => Gibt den Index des ersten Vorkommens des angegebenen Objekts aus der Liste zurück\n"
                            + $"(mit Startindex und Anzahl der vorkommenden Elemente): {autos.LastIndexOf("Mercedes Benz", 2, 3)}\n");

            Console.WriteLine($"Remove() => Entfernt das erste Vorkommen eines angegebenen Objekts aus der Liste:"); autos.Remove("Mercedes Benz"); Console.WriteLine(string.Join('-', autos) + "\n");

            Console.WriteLine($"RemoveAt() => Entfernt das Element am angegebenen Index aus der Liste:"); autos.RemoveAt(9); Console.WriteLine(string.Join('-', autos) + "\n");

            Console.WriteLine($"RemoveRange() => Entfernt einen Bereich von Elementen aus der Liste:"); autos.RemoveRange(1, 3); Console.WriteLine(string.Join('-', autos) + "\n");

            Console.WriteLine($"Reverse() => Kehrt die Reihenfolge der Elemente (im angegebenen Bereich) um:"); autos.Reverse(2, 4); Console.WriteLine(string.Join('-', autos) + "\n");

            Console.WriteLine($"Sort() => Entfernt einen Bereich von Elementen aus der Liste:"); autos.Sort(); Console.WriteLine(string.Join('-', autos) + "\n");

            Console.WriteLine($"ToArray() => Kopiert die Elemente der Liste in ein neues Array:\n{string.Join('-', autos.ToArray())}\n");

            Console.WriteLine("TrimExcess() => Legt die Kapazität auf die Anzahl der tatsächlich in der Liste befindlichen Elemente fest,\n"
                            + $"sofern diese Anzahl unter dem Schwellenwert liegt:"); autos.TrimExcess();

        }
    }
}
