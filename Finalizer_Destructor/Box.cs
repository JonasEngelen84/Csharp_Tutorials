namespace Finalizer_Destructor
{
    class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Box()
        {
            Length = 5;
            Width = 6;
            Height = 7;
        }

        // Destructor:
        //Zerstört das Objekt und gibt somit Speichrplatz frei
        ~Box()
        {
            // Aufräumarbeiten implementieren...
        }
    }
}
