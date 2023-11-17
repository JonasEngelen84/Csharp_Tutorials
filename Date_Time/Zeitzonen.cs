using System;
using System.Globalization;

namespace Date_Time
{
    class Zeitzonen
    {
        public static void Ausgabe()
        {
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "en-US", "en-GB", "ch-CH", "de-DE", "ru-RU", "us-US"};

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine(culture.NativeName);
                Console.WriteLine("   Local date and time: {0}, {1:G}", localDate.ToString(culture), localDate.Kind);
                Console.WriteLine("   UTC date and time: {0}, {1:G}\n", utcDate.ToString(culture), utcDate.Kind);
            }


            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}: {1}", cultureName, localDate.ToString(culture));
            }
        }
    }
}
