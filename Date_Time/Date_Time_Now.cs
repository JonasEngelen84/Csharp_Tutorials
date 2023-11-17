using System;
using System.Globalization;

namespace Date_Time
{
    class Date_Time_Now
    {
        public static void Ausgabe()
        {
            /*
             * Im folgenden Beispiel werden die Now -Eigenschaft und die-Eigenschaft verwendet UtcNow,
             * um das aktuelle lokale Datum und die aktuelle Uhrzeit sowie das aktuelle universelle
             * koordinierte Datum und die Uhrzeit abzurufen.
             * Anschließend werden die Zeichen folgen mithilfe der Formatierungs Konventionen einer
             * Reihe von Kulturen zusammen mit den Werten der zugehörigen Kind Eigenschaften angezeigt. 
             */

            Console.WriteLine(DateTime.Now);                                    //Ausgabe: 12.02.2022  16:49:34
            Console.WriteLine(DateTime.Now.ToString("dddd MMMM"));              //Ausgabe: Samstag Februar
            Console.WriteLine(DateTime.Now.ToString("dddd"));                   //Ausgabe: Samstag
            Console.WriteLine(DateTime.Now.ToString("MMMM"));                   //Ausgabe: Februar
            Console.WriteLine(DateTime.Now.ToString("dd MM\n"));                //Ausgabe: 12  02


        }
    }
}
