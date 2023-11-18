using System;

namespace Get_Set
{
    class Get_Set
    {
        private int length;
        private int height;
        private int width;
        private double volume;

        public int getLength()
        {
            return this.length;
        }

        public void setLength(int length)
        {
            this.length = length;
        }

        public int getheigth()
        {
            return this.height;
        }

        public void setheight(int height)
        {
            this.height = height;
        }

        public int getwidth()
        {
            return this.width;
        }

        public void setwidth(int width)
        {
            this.width = width;
        }

        public void Display()
        {
            Console.WriteLine($"Länge:   {length}\nHöhe:    {height}\nBreite:  {width}\nVolumen: {volume = length * height * width}");
        }
    }
}
