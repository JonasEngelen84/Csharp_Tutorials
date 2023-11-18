string satz = "Das ist ein test-Satz1";
string zeichen = "♥";
int nummer = 3;
char char1 = '3';


// Einzelnen Charachter aus String ansprechen
Console.WriteLine("satz[2] => Einzelnen Charachter aus String ansprechen\n" + satz + "\n" + satz[2] + "\n\n");

// Felder:
Console.WriteLine("Felder:\n" +
                 $"MaxValue => Gibt den größtmöglichen Wert von Char zurück: {char.MaxValue}\n");

Console.WriteLine($"MinValue => Gibt den kleinstmöglichen Wert von Char zurück: {char.MaxValue}\n\n");


// Methoden:
Console.WriteLine("Methoden:\n" +
                  "CompareTo() => Vergleicht 2 Zeichen und gibt an,ob sich das Objekt\n" +
    $"an einer früheren oder späteren Position der Sortierreihenfolge befindet: {satz[6].CompareTo(char1)}\n");

Console.WriteLine($"ConvertFromUtf32() => Konvertiert von Unicode (0 - 382) in UTF-16: {char.ConvertFromUtf32(nummer)}\n");

Console.WriteLine($"ConvertToUtf32() => Konvertiert von UTF-16-String, an angegebenen Index, in Unicode: {char.ConvertToUtf32(satz, 20)}\n");

Console.WriteLine($"Equals() => vergleicht eine Instanz mit einem Char-Objekt: {nummer.Equals(char1)}\n");

Console.WriteLine($"GetNumericValue() => Konvertiert das angegebene numerische Unicode-Zeichen in Gleikommazahl: {char.GetNumericValue(char1)}\n");

Console.WriteLine($"GetTypeCode() => Gibt den Datentyp zurück: {satz.GetTypeCode()}\n");

Console.WriteLine($"IsAscii() => Gibt an, ob sich ein char in der ASCII-Tabelle befindet: {char.IsAscii('-')}\n");

Console.WriteLine($"IsControl() => Gibt an, ob ein char ein Steuerzeichen ist: {char.IsControl('S')}\n");

Console.WriteLine($"IsDigit() => Gibt an, ob ein char (oder char in string) ein Dezimalzahl ist: {char.IsDigit(char1)}\n");

Console.WriteLine($"IsLetter() => Gibt an, ob ein char (oder char in string) ein Unicode-Buchstabe ist: {char.IsLetter(satz, 6)}\n");

Console.WriteLine($"IsLetterOrDigit() => Gibt an, ob ein char (oder char in string) als " +
    $"Unicode-Buchstabe/-Dezimahlzahl (true) kategorisiert wird: {char.IsLetterOrDigit('-')}\n");

Console.WriteLine($"IsLower() => Gibt an, ob ein char (oder char in string) LowerCase ist: {char.IsLower(satz, 6)}\n");

Console.WriteLine($"IsNumber() => Gibt an, ob ein char (oder char in string) als Zahl kategorisiert ist: {char.IsNumber(char1)}\n");

Console.WriteLine($"IsPunctuation() => Gibt an, ob ein char (oder char in string) ein Satzzeichen ist: {char.IsPunctuation('!')}\n");

Console.WriteLine($"IsSeparator() => Gibt an, ob ein char (oder char in string) ein Trennzeichen ist: {char.IsSeparator(' ')}\n");

Console.WriteLine($"IsSurrogate() => Gibt an, ob ein char (oder char in string) ein Ersatzzeichen ist (auch in High und Low): {char.IsSurrogate('*')}\n");

Console.WriteLine($"IsSurrogatePair() => Gibt an, ob 2 chars ein Ersatzzeichenpaar bilden: {char.IsSurrogatePair('*', '-')}\n");

Console.WriteLine($"IsSurrogatePair(String, Int32) => Gibt an, ob 2 aufeinanderfolgende chars " +
    $"in einem string ein Ersatzzeichenpaar bilden: {char.IsSurrogatePair(satz, 7)}\n");

Console.WriteLine($"IsSymbol() => Gibt an, ob ein char ein Symbolzeichen ist: {char.IsSymbol('♥')}\n");

Console.WriteLine($"IsSymbol() => Gibt an, ob ein char (oder char in string) ein Symbolzeichen ist: {char.IsSymbol('♥')}\n");

Console.WriteLine($"IsUpper() => Gibt an, ob ein char (oder char in string) UpperCase ist: {char.IsUpper(satz, 6)}\n");

Console.WriteLine($"IsWhiteSpace() => Gibt an, ob ein char (oder char in string) ein Leerzeichen ist: {char.IsWhiteSpace(satz[7])}\n");

Console.WriteLine($"Parse() => Konvertiert den Wert eines strings (aus einem Zeichen) in das entsprechende Unicode-Zeichen: {char.Parse(zeichen)}\n");

Console.WriteLine($"ToLower() => Konvertiert einen Buchstaben in kleinschreibung: {char.ToLower(satz[6])}\n");

Console.WriteLine($"ToLowerCultureInfo() => Konvertiert einen Buchstaben in Kleinbuchstaben: {char.ToLower(satz[0])}\n");

Console.WriteLine($"ToLower() => Konvertiert einen Buchstaben in Großbuchstaben: {char.ToUpper(satz[6])}\n");

Console.WriteLine($"TryParse() => Konvertiert ein char in einem string in Unicode, und gibt erfolgsbestätigung zurück: {char.TryParse(satz, out char1)}\n");
