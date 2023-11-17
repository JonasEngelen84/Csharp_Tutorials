namespace Abstrakte_Klassen.WEINI
{
    class Triangle : GeometrischeFigur
    {
        private readonly double länge = 5.5;
        private readonly double breite = 6.3;

        public override double BerechneFlächeninhalt()
        {
            return länge * breite;
        }
    }
}
