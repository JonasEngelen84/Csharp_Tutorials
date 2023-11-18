namespace Enum
{
    // enum = Sammlung von Konstanten
    // Werden außerhalb der Klasse deklariert damit sie im gesamten Namespace verwendet werden können.
    enum Day { Mo, Tu, We, Th, Fr, Sa, Su }

    // Der Index ist sofort setzbar und gilt ab setzen fortgehend.
    enum Month { Jan=1, Feb, Mar, Apr, May, Jun, Jul=9, Aug, Sep, Oct, Nov, Dec }


     class EnumBeispiel
     {
        Day fr = Day.Fr;
        Day su = Day.Su;
        Day a = Day.Fr;

        Month feb = Month.Feb;

        public void Ausgabe()
        {
            // Werte Vergleich
            Console.WriteLine(fr == a);

            // Gibt den Wert aus.
            Console.WriteLine(Day.Tu);
            Console.WriteLine(feb);

            // Gibt den Index aus.
            Console.WriteLine((int)su);
            Console.WriteLine((int)Month.Dec);
        }
     }
}
