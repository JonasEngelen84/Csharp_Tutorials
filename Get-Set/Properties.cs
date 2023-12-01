using System;

namespace Get_Set
{
    class Properties
    {
        // auto-implemented property
        public int Length { get; set; }


        // Sobald die get sich selbst returnt entsteht ein stackoverflow.
        // Daher MUSS über eine Variable gearbeitet werden.
        private int width;
        public int Width
        {
            get
            {
                return width;
            }

            set
            {   // Prüft ob Eingabe größer 0 ist, wenn nicht => wirfe manuell erstellte System-Exception.
                if (value == 0) throw new Exception("Breite wurde der Wert 0 zugefügt!");

                // Bei negativer Eingabe, negiere die Eingabe.
                if (value < 0)
                {
                    value = -value;
                }

                width = value;
            }
        }


        // Kurzform, wenn über Variable gearbeitet wird,
        // aber KEINE weitere Anweisung in get oder set implementiert wird.
        private int height;
        public int Height
        {
            get => height;
            set => height = value;
        }


        public int Volume
        {
            get
            {
                return Length * Width * Height;
            }
        }


        public void Display()
        {
            Console.WriteLine($"\nLänge:   {Length}\nHöhe:    {Height}\nBreite:  {Width}\nVolumen: {Volume}");
        }
    }
}
