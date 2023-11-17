using System;

namespace Polymorphie.CsharpMasterclass
{
    internal class BMW : Auto
    {
        public string Modell { get; set; }
        private string marke = "BMW";

        public BMW(string modell, int ps, string farbe) : base(ps, farbe)
        {
            Modell = modell;
        }

        public override void ZeigeDetails()
        {
            Console.WriteLine($"Der {marke} {Modell} hat {Ps} Ps und ist {Farbe}.");
        }

        public override void Reparieren()
        {
            Console.WriteLine($"Der {marke} wurde repariert");
        }
    }
}
