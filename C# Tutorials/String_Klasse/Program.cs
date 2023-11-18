using System;

string string1 = "Hallo ";
string string2 = "Eine Zeile Text!";
string string3 = "Dieser String wird Empty, weshalb er in der nächsten Zeile nicht ausgegeben werden kann!!!";
string[] stringArray = { "Ich", "teste", "das", "jetzt", "mal" };


// Felder:
Console.WriteLine($"Felder:\n{string3}\n"
               + $"Empty => Stellt die leere Zeichenfolge dar (Dieses Feld ist schreibgeschützt): {string3 = string.Empty}");


// Eigenschaften:
Console.WriteLine("\n\nEigenschaften:\n"
                + "Length => Gibt die Anzahl der Chars eines strings (hier \"Hallo \") zurück: " + string1.Length + "\n");

Console.WriteLine("[] => Gibt den Char an einen bestimmten Index (hier Index \"1\" von \"Hallo\") aus string1 zurück: " + string1[1]);


// Methoden:
Console.WriteLine("\n\nMethoden:\n"
                + "Clone() => Gibt einen Verweis auf diese Instanz von string zurück: " + string1.Clone() + "\n");

Console.WriteLine("Compare() => Vergleicht zwei angegebene String-Objekte und gibt eine ganze Zahl zurück,"
               + $"die ihre relative Position in der Sortierreihenfolge angibt: {string.Compare(string2, string3)}\n");

Console.WriteLine("Concat() => Strings zusammenfügen:" + String.Concat(string1, " und noch ein Gestörter\n"));

Console.WriteLine("Contains() => Gibt an, ob ein angegebener Char in einem angegeben String enthalten ist: " + string1.Contains('a') + "\n");

Console.WriteLine("EndsWith() => Gibt an, ob das Ende eines strings mit dem angegebenen char/string übereinstimmt: " + string1.EndsWith(' ') + "\n");

Console.WriteLine("Equals() => Vergleicht den Wert von zwei strings: " + string.Equals(string3, string2) + "\n");

Console.WriteLine("Format() => Ersetzt mindestens ein Formatelement in einem string"
               + " durch die Zeichenfolgendarstellung eines angegebenen Objekts: " + string.Format("{0} Welt\n", string1));

Console.WriteLine("GetEnumerator() => Gibt den NULL-basierten Index des ersten eines angegebenen Chars zurück: " + string3.GetEnumerator() + "\n");

Console.WriteLine("IndexOf() => Gibt den NULL-basierten Index des ersten eines angegebenen Chars zurück: " + string1.IndexOf('l') + "\n");

Console.WriteLine("Insert() => Fügt ab index X einen string in den aufrufenden string ein: " + string1.Insert(3, " du da") + "\n");

Console.WriteLine("Intern() => Ruft den Verweis des Systems auf den angegebenen String ab: " + string.Intern(string2) + "\n");

Console.WriteLine("IsNormalized() => Gibt an, ob diese Zeichenfolge in der Unicode-Normalisierungsform C vorliegt: " + string2.IsNormalized() + "\n");

Console.WriteLine("IsNullOrEmpty() => Gibt an, ob die angegebene Zeichenfolge null oder eine leere Zeichenfolge (\"\") ist: " + string.IsNullOrEmpty(string3) + "\n");

Console.WriteLine("IsNullOrWhiteSpace() => Gibt an, ob eine angegebene Zeichenfolge null ist, leer ist oder nur aus Leerzeichen besteht: " + string.IsNullOrWhiteSpace(string3) + "\n");

Console.WriteLine("Join() => Verkettet ein Zeichenfolgenarray mithilfe der angegebenen Trennlinie zwischen den einzelnen Elementen: " + string.Join('*', stringArray) + "\n");

Console.WriteLine("LastIndexOf() => Gibt die NULL-basierte Indexposition des letzten Vorkommens eines angegebenen chars an: " + string1.LastIndexOf('l') + "\n");

Console.WriteLine("Normalize() => Konvertiert einen string in Unicode-Normalisierungsform C: " + string2.Normalize() + "\n");

Console.WriteLine("PadLeft() => Gibt den String rechtsbündig zurück, bis zu angegebene Größe (mit oder ohne Zeichen): " + string1.PadLeft(10, '-') + "\n");

Console.WriteLine("Remove() => Löscht instanzen aus \"Eine Zeile Text\" (von bis): " + string2.Remove(3, 7) + "\n");

Console.WriteLine("Replace() => Ersetzt alle eines angegebenen Zeichens für ein anderes angegebenes aus: " + string1.Replace('l', 'y') + "\n");

Console.Write("Split() => String an bestimmtem char trennen (getrennte Strings werden in ein Array gespeichert): " + string.Join(' ', stringArray = string2.Split(' ')) + "\n\n");

Console.WriteLine("StartsWith()" + " => Gibt an, ob ein string mit dem angegebenen Zeichen (oder string) beginnt: " + string1.StartsWith('H') + "\n");

Console.WriteLine("Substring()" + " => Gibt eine Teilzeichenfolge eines strings zurück (von bis): " + string2.Substring(3, 9) + "\n");

Console.WriteLine("ToCharArray()" + " => Kopiert die Zeichen einer angegebenen Teilzeichenfolge eines strings in ein Array von Unicode-Zeichen: " + string.Join("", string2.ToCharArray(3, 9)) + "\n");

Console.WriteLine("ToLower()" + " => Alles KLeIN ScHREIbEN".ToLower() + "\n");

Console.WriteLine("ToUpper()" + " => Alles grOß sChreIben".ToUpper() + "\n");

Console.WriteLine("Trim() => Entfernt alle führenden UND nachstellenden Leerstellen (oder angegebenes Zeichen oder char[]): " + string2.Trim('E') + "\n\n");

Console.WriteLine("TrimEnd() => Entfernt NUR alle nachgestellten Leerstellen (oder angegebenes Zeichen oder char[]) aus der aktuellen Zeichenfolge: " + string2.TrimEnd('!') + "\n");

Console.WriteLine("TrimStart() => Entfernt NUR alle führenden Leerstellen (oder angegebenes Zeichen oder char[]) aus der aktuellen Zeichenfolge: " + string2.TrimStart('E') + "\n");
