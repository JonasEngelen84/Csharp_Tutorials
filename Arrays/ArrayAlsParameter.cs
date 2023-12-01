using System;

namespace Arrays
{
    public class ArrayAlsParameter
    {
        public static int[] zufriedenheit = new int[] { 1, 2, 3, 4, 5 };

        public static void ErhöheUmZwei(int[] args)
        {
            foreach (int i in zufriedenheit)
            {
                Console.Write(i);
                zufriedenheit[i - 1] = i + 2;
            }
            Console.WriteLine();

            foreach (int i in zufriedenheit)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
