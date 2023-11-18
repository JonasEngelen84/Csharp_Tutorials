using System.IO;

namespace Interface.WEINI
{
    class Datei : IDrucker
    {
        public void Print()
        {
            File.WriteAllText("F:\\Coding\\Workspaces\\Visual Studio\\Übungen-Tutorials\\Tutorials\\C# TutorialsTestDatei.txt", "Ein fester Text in eine Datei.");
        }
    }
}
