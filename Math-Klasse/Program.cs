int zahl1 = 0;
int zahl2 = -666;
int zahl3 = 88;
double zahl4 = 18.6;

// Felder:
Console.WriteLine($"Felder:\n"
               + $"Math.E => Stellt die Basis des natürlichen Logarithmus durch die Konstante e dar: {Math.E}\n");

Console.WriteLine($"Math.PI => Stellt das Verhältnis eines Kreisumfangs zum Kreisdurchmesser durch die Konstante π dar: {Math.PI}\n");

Console.WriteLine($"Math.Tau => Stellt die Anzahl der Bogenmaßwerte in einer Umdrehung dar, angegeben durch die Konstante τ: {Math.Tau}\n");


// Methoden:
Console.WriteLine("\nEigenschaften:\n"
                + $"Abs => Gibt den Absolutbetrag einer Decimal-Zahl zurück: {Math.Abs(zahl3)}\n");

Console.WriteLine($"Acos => Gibt einen Winkel zurück, dessen Kosinus die angegebene Zahl ist: {Math.Acos(zahl4)}\n");

Console.WriteLine($"Acosh => Gibt den Winkel zurück, dessen hyperbolischer Kosinus die angegebene Zahl ist: {Math.Acosh(zahl4)}\n");

Console.WriteLine($"Asin => Gibt einen Winkel zurück, dessen Sinus die angegebene Zahl ist: {Math.Asin(zahl4)}\n");

Console.WriteLine($"Asinh => Gibt den Winkel zurück, dessen hyperbolischer Sinus die angegebene Zahl ist: {Math.Asinh(zahl4)}\n");

Console.WriteLine($"Atan => Gibt den Winkel zurück, dessen hyperbolischer Tangens  die angegebene Zahl ist: {Math.Atan(zahl4)}\n");

Console.WriteLine($"Atanh => Gibt den Winkel zurück, dessen hyperbolischer Tangens  die angegebene Zahl ist: {Math.Atanh(zahl4)}\n");

Console.WriteLine($"Atan2 => Gibt einen Winkel zurück, dessen Tangens der Quotient zweier angegebener Zahlen ist: {Math.Atan2(zahl4, 6.2)}\n");

Console.WriteLine($"BigMul => Berechnet das vollständige Produkt aus zwei 32-Bit-Zahlen: {Math.BigMul(2, zahl2)}\n");

Console.WriteLine($"BitDecrement => Gibt den nächsten kleinsten Wert zurück, der weniger als x vergleicht: {Math.BitDecrement(zahl4)}\n");

Console.WriteLine($"BitIncrement => Gibt den nächsten größten Wert zurück, der weniger als x vergleicht: {Math.BitIncrement(zahl4)}\n");

Console.WriteLine($"Cbrt => Gibt die Kubikwurzel einer angegebenen Zahl zurück: {Math.Cbrt(zahl4)}\n");

Console.WriteLine($"Ceiling => Gibt den kleinsten ganzzahligen Wert zurück, der größer oder gleich der angegebenen Dezimalzahl ist: {Math.Ceiling(zahl4)}\n");

Console.WriteLine($"Clamp => Gibt value gebunden an den Inklusivbereich von min und max zurück: {Math.Clamp(6, zahl1, zahl3)}\n");

Console.WriteLine($"Cos => Gibt den Kosinus des angegebenen Winkels zurück: {Math.Cos(2.3)}\n");

Console.WriteLine($"Cosh => Gibt den Hyperbelkosinus des angegebenen Winkels zurück: {Math.Cosh(4.6)}\n");

Console.WriteLine($"DivRem => Erzeugt den Quotienten und den Rest von zwei 32-Bit-Zahlen mit Vorzeichen: {Math.DivRem(54, 6)}\n");

Console.WriteLine($"Exp => Gibt die angegebene Potenz von e zurück: {Math.Exp(2.5)}\n");

Console.WriteLine($"Floor => Gibt die größte Ganzzahl zurück, die kleiner oder gleich der angegebenen Dezimalzahl ist: {Math.Floor(2.3)}\n");

Console.WriteLine($"IEEERemainder => Gibt den Rest der Division zweier angegebener Zahlen zurück: {Math.IEEERemainder(2.3, 3.6)}\n");

Console.WriteLine($"ILogB => Gibt den Logarithmus einer angegebenen ganzen Zahl zur Basis 2 zurück: {Math.ILogB(74.425)}\n");

Console.WriteLine($"Log => Gibt den natürlichen Logarithmus (zur Basis e) der angegebenen Zahl zurück: {Math.Log(2)}\n");

Console.WriteLine($"Log => Gibt den Logarithmus einer angegebenen Zahl bezüglich einer angegebenen Basis zurück: {Math.Log(2.3, 2.8)}\n");

Console.WriteLine($"Log10 => Gibt den Logarithmus einer angegebenen Zahl zur Basis 10 zurück: {Math.Log10(3)}\n");

Console.WriteLine($"Log2 => Gibt den Logarithmus einer angegebenen Zahl zur Basis 2 zurück: {Math.Log2(3)}\n");

Console.WriteLine($"Max => Gibt die größere von zwei Ganz- oder Gleitkommazahlen zurück (auch mit Min()): {Math.Max(2.55, 2.554)}\n");

Console.WriteLine($"MaxMagnitude => Gibt den größeren Betrag von zwei Gleitkommazahlen mit doppelter Genauigkeit zurück (auch mit Min()): {Math.MaxMagnitude(2.55, 2.554)}\n");

Console.WriteLine($"Pow => Potenziert eine angegebene Zahl mit dem angegebenen Exponenten: {Math.Pow(2, 3)}\n");

Console.WriteLine($"ReciprocalEstimate => Gibt eine Schätzung des Kehrwerts einer angegebenen Zahl zurück: {Math.ReciprocalEstimate(2)}\n");

Console.WriteLine($"ReciprocalSqrtEstimate => Gibt eine Schätzung der reziproken Quadratwurzel einer angegebenen Zahl zurück: {Math.ReciprocalSqrtEstimate(6)}\n");

Console.WriteLine($"Round => Rundet einen Dezimalwert auf den nächstgelegenen ganzzahligen Wert und Mittelpunktwerte auf die nächstgelegene gerade Zahl: {Math.Round(2.3)}\n");

Console.WriteLine($"ScaleB => Gibt x * 2^n effizient berechnet zurück: {Math.ScaleB(2.3, 3)}\n");

Console.WriteLine($"Sin => Gibt den Sinus des angegebenen Winkels zurück: {Math.Sin(2.3)}\n");

Console.WriteLine($"SinCos => Gibt den Sinus und kosinus des angegebenen Winkels zurück: {Math.SinCos(2.3)}\n");

Console.WriteLine($"Sinh => Gibt den Hyperbelsinus des angegebenen Winkels zurück: {Math.Sinh(2.3)}\n");

Console.WriteLine($"Sqrt => Gibt die Quadratwurzel einer angegebenen Zahl zurück: {Math.Sqrt(2.3)}\n");

Console.WriteLine($"Tan => Gibt den Tangens des angegebenen Winkels zurück: {Math.Tan(2.3)}\n");

Console.WriteLine($"Tanh => Gibt den Hyperbeltangens des angegebenen Winkels zurück: {Math.Tanh(2.3)}\n");

Console.WriteLine($"Truncate => Berechnet den den ganzzahligen Teil einer angegebenen Decimal- oder Gleitkomma-Zahl: {Math.Truncate(2.3)}\n");

