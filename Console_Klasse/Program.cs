using System;

namespace Klasse_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Dieser Titel funktioniert";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WindowTop = 5;          // Setzt die Höhe (Scrollbar).
            Console.BufferHeight = 100;     // Setzt Größe des zu Scrollenden Bereichs (vertikal).
            Console.CursorTop = 30;         // Setzt Postion der Ausgabe (vertikal).
            Console.WindowWidth = 100;       // Setzt Breite der Konsole.
            Console.Beep();                 // Gibt Signalton bei Öffnen der Konsole.
            Console.SetWindowSize(50, 20); // Setzt Breite und Höhe der Konsole.
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
