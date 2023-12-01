using Lists;
using System;

//ListT.ListInList();
//ListT.ListTAusgabe();

List<int> arr = new List<int>() { 1, 2, 3, 4, 5 };



diagonalDifference("12:59:59PM");

static void diagonalDifference(string s)
{
    string output = s[..2];
    
    if (s.Substring(8, 1).Equals("P"))
    {
        output = output.Equals("12") ? s[..8] : int.Parse(output)+ 12 + s.Substring(2, 6);
    }
    else
    {
        output = output.Equals("12") ? "00" + s.Substring(2, 6) : s[..8];
    }

    Console.WriteLine(output);
}
