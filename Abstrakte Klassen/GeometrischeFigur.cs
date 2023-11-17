using System;

namespace Abstrakte_Klassen.WEINI
{
    abstract class GeometrischeFigur
    {
        private String farbe;

        public void SetFarbe(String farbe)
        {
            this.farbe = farbe;
        }

        public String GetFarbe()
        {
            return this.farbe;
        }

        public abstract double BerechneFlächeninhalt();
    }
}
