using System.IO;

namespace Interface.WEINI
{
    class Datei : IDrucker
    {
        public void Print()
        {
            File.WriteAllText("D:\\TestDatei.txt", "Ein fester Text in eine Datei.");
        }
    }
}
