using Polymorphie.Hat_ein_Beziehung;
using System;

namespace Polymorphie.CsharpMasterclass
{
    class Auto
    {
        public int Ps { get; set; }
        public string Farbe { get; set; }

        public Auto(int ps, string farbe)
        {
            Ps = ps;
            Farbe = farbe;
        }

        public virtual void ZeigeDetails()
        {
            Console.WriteLine($"Das Auto hat {Ps} Ps und ist {Farbe}.");
        }

        public virtual void Reparieren()
        {
            Console.WriteLine("Das Auto wurde repariert");
        }


        // "Hat-eine" Beziehung:
        // Über das Objekt wird auf die AutoInfo-Klasse Zugegriffen.
        // NICHT! durch vererbung.
        AutoInfo Info = new();

        public void SetInfo(int id, string besitzer)
        {
            Info.Id = id;
            Info.Besitzer = besitzer;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Das Auto hat die Id: {Info.Id}, Besitzer: {Info.Besitzer}");
        }
    }
}
