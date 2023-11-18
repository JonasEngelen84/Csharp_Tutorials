using System;

namespace Abstrakte_Klassen.WEINI
{
    class Circle : GeometrischeFigur
    {
        private readonly double radius = 16;

        public override double BerechneFlächeninhalt()
        {
            return radius * radius * Math.PI;
        }
    }
}
