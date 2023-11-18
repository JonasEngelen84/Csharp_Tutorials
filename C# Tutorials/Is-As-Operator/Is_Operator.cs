using System;

namespace Is_As_Operator
{
    class Is_Operator
    {
        //Der "is" Operator prüft ob ein objekt kompatibel ist mit einem gegeben Datentyp.

        class Person
        {
            public int Alter { get; set; }

            public String Name { get; set; }
        }

        class Informatiker : Person
        {
            public void programmieren()
            {
                Console.WriteLine(Name + " (" + Alter + ") programmiert eine App\n");
            }
        }

        public static void Ausgabe()
        {
            Person person1 = new Person();
            person1.Name = "Anna";
            person1.Alter = 34;

            Informatiker person2 = new Informatiker();
            person2.Name = "Jonas";
            person2.Alter = 36;

            person2.programmieren();

            Console.WriteLine(person1 is Person);   //Ausgabe: true
            Console.WriteLine(person1 is Informatiker); //Ausgabe: false



            Console.WriteLine("\n\nWeiterer is-Test\n");



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
