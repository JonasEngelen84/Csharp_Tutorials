using Abstrakte_Klassen.WEINI;
using System;

namespace Abstrakte_Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle kreis = new();
            Triangle dreieck = new();
            Console.WriteLine("Die Fläche des Kreises beträgt:    "+kreis.BerechneFlächeninhalt()+
                              "\nDie Fläche des Dreiecks beträgt:   "+dreieck.BerechneFlächeninhalt());

            Console.ReadLine();
        }
    }
}
