// Aus Datei lesen:
// entweder
string text = File.ReadAllText(@"D:\Programmierung\Visual Studio Projekte\Übungen-Tutorials\Eigene Tutorials\Text-Datei lesen und schreiben\Text-Datei.txt");
Console.WriteLine(text+"\n");


// oder
string[] zeilen = File.ReadAllLines(@"D:\Programmierung\Visual Studio Projekte\Übungen-Tutorials\Eigene Tutorials\Text-Datei lesen und schreiben\Text-Datei.txt");

foreach (string ze in zeilen)
{
    Console.WriteLine(ze);
}





// In Datei schreiben:
//entweder
string[] schreiben = { "Ja, dann lass mal buchen und los gehts.", "Ok, ich bin dabei.", "Die Jungs kommen alle mit." };
File.WriteAllLines(@"D:\Programmierung\Visual Studio Projekte\Übungen-Tutorials\Eigene Tutorials\Text-Datei lesen und schreiben\In Datei schreiben.txt", schreiben);


// oder
File.WriteAllText(@"D:\Programmierung\Visual Studio Projekte\Übungen-Tutorials\Eigene Tutorials\Text-Datei lesen und schreiben\In Datei schreiben2.txt", "Hier kann man auch was schreiben.");


// oder
using (StreamWriter datei = new StreamWriter(@"D:\Programmierung\Visual Studio Projekte\Übungen-Tutorials\Eigene Tutorials\Text-Datei lesen und schreiben\In Datei schreiben3.txt"))
{
    foreach (string ze in zeilen)
    {
        if (ze.Contains("Wo sollen wir hin?"))
            datei.WriteLine(ze);
    }
}


// In Datei schreiben OHNE überschreiben:                                                                                                                                         , true 
using (StreamWriter datei = new StreamWriter(@"D:\Programmierung\Visual Studio Projekte\Übungen-Tutorials\Eigene Tutorials\Text-Datei lesen und schreiben\In Datei schreiben3.txt", true))
{
    datei.WriteLine("Scheiß egal, hauptsache chillen");
}