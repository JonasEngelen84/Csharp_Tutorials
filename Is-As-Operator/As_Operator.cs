using System;

namespace Is_As_Operator
{
    class As_Operator
    {
        //Der As-Operator konvertiert ein Objekt in einen anderen Datentyp um.

        public static void Ausgabe()
        {
            object[] objekte = new object[5];
            objekte[0] = 66;
            objekte[1] = "zweiter Test";
            objekte[2] = "dritter Test";
            objekte[3] = true;
            objekte[4] = 6.666;

            foreach (object test in objekte)
            {
                if (test is String text)
                {
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("Fehler: Objekt ist kein String");
                }
            }
            Console.WriteLine();
        }
    }
}
