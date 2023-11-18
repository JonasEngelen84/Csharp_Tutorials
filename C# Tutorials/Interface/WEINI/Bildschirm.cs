using System;

namespace Interface.WEINI
{
    class Bildschirm : IDrucker
    {
        public void Print()
        {
            Console.WriteLine("Ein fester Text auf dem Bildschirm.");
        }
    }
}
