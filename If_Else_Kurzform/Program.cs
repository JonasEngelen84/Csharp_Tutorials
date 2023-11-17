using System;

namespace If_Else_Kurzform
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = -5;
            string stateOfMatter;


            // Lange Schreibweise
            if(temperature < 0)
            {
                stateOfMatter = "fest";
            }
            else
            {
                stateOfMatter = "flüssig";
            }

            Console.WriteLine(stateOfMatter);


            // Kurzform
            stateOfMatter = temperature < -10 ? "fest" : "flüssig";
            Console.WriteLine(stateOfMatter);

            stateOfMatter = temperature < -10 ? "fest" : (temperature < -6 ? "fest" : "gas");
            Console.WriteLine(stateOfMatter+"\n\n");


            Von12Auf24StundenFormat("04:59:59PM");
        }


        static void Von12Auf24StundenFormat(string s)
        {
            string output = s[..2]; // Kurzform für Substring ab Position 0

            if (s[8] == 'P')
                // Wenn output = 12 => Stunden nicht plus 12 ändern und s bedingt anhängen, sonst Stunden plus 12 ändern und s bedingt anhängen
                output = output.Equals("12") ? s[..8] : int.Parse(output) + 12 + s.Substring(2, 6);
            else
                // Wenn output = 12 => Stunden auf 00 ändern und s bedingt anhängen, sonst Stunden unverändert lassen und s bedingt anhängen
                output = output.Equals("12") ? "00" + s.Substring(2, 6) : s[..8];

            Console.WriteLine(output);
        }
    }
}
