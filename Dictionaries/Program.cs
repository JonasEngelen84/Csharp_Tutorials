// Deklarieren und initialisieren eines Dictionary<TKey,TValue> Objekts:
using System.Collections.Generic;

Dictionary<int, string> kontinente = new Dictionary<int, string>()
{
    {1, "Asien" },
    {2, "Afrika" },
    {3, "Amerika" },
    {4, "Europa" },
    {5, "Australien" },
    {6, "Antarktis" }
};


// Dictionary ausgeben:
Console.WriteLine(string.Join('-',kontinente) + "\n");

foreach (var k in kontinente)
{
    Console.WriteLine($"Kontinent: {k.Value}\tKey: {k.Key}");
}

Console.WriteLine($"\n{kontinente[4]}\n\n");


// Felder:
Console.WriteLine("Felder:\n"
               + $"Comparer => Ruft den IEqualityComparer<T> ab, mit dem die Gleichheit der Schlüssel für das Wörterbuch bestimmt wird:\n{kontinente.Comparer}\n");

Console.WriteLine($"Count => Ruft die Anzahl der Schlüssel-Wert-Paare im Dictionary ab: {kontinente.Count}\n");

Console.WriteLine($"[] => Ruft den Wert ab, der dem angegebenen Schlüssel zugeordnet ist, oder legt diesen fest: {kontinente[2] = "Eurasien"}\n");

Console.WriteLine($"Keys => Ruft eine Auflistung ab, die die Schlüssel im Dictionary enthält:\n{kontinente.Keys}\n");

Console.WriteLine($"Values => Ruft eine Auflistung ab, die die Werte im Dictionary enthält:\n{kontinente.Values}\n\n");


// Methoden:
Console.WriteLine("Methoden:\n"
               + $"Add() => Fügt dem Wörterbuch den angegebenen Schlüssel und Wert hinzu:"); kontinente.Add(7, "Afrika");  Console.WriteLine(string.Join('-',kontinente) + "\n");

Console.WriteLine($"Clear() => Entfernt sämtliche Schlüssel und Werte aus dem Dictionary:\n");  // kontinente.Clear();

Console.WriteLine($"ContainsKey() => Gibt an, ob das Dictionary den angegebenen Schlüssel enthält: {kontinente.ContainsKey(6)}\n");

Console.WriteLine($"EnsureCapacity() => Stellt sicher, dass das Wörterbuch ohne weitere Erweiterung seines Sicherungsspeichers\n"
                + $"Einträge bis zu einer bestimmten Anzahl aufnehmen kann: {kontinente.EnsureCapacity(9)}\n");

Console.WriteLine($"Equals() => Gibt an, ob das angegebene Objekt gleich dem aktuellen Objekt ist: {kontinente[1].Equals("Afrika")}\n");

Console.WriteLine($"GetEnumerator() => Gibt einen Enumerator zurück, der die Dictionary durchläuft:\n{kontinente.GetEnumerator()}\n");

Console.WriteLine($"Remove() => Entfernt den Wert mit dem angegebenen Schlüssel aus dem Dictionary: {kontinente.Remove(2)}\n{string.Join('-', kontinente)}\n");

Console.WriteLine($"TryAdd() => Entfernt den Wert mit dem angegebenen Schlüssel aus dem Dictionary: {kontinente.TryAdd(2, "Süd-Amerika")}\n{string.Join('-',kontinente)}\n");
string test = "pech";
Console.WriteLine($"TryGetValue() => Ruft den dem angegebenen Schlüssel zugeordneten Wert ab: {kontinente.TryGetValue(7, out test)}\n{string.Join('-', kontinente)}\n");
