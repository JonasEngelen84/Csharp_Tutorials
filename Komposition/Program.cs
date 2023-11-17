using Komposition.Gaz;
using System;

namespace Komposition
{

    // Siehe auch "Polymorphismus.Hat eine Beziehung".
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new ("Jonas Engelen");
            Project project = new (manager, "Zutrittskontrollen-Simulator");
            Console.WriteLine($"Projektname: {project.Name}\nProjektleiter: {project.Managername}");
            Console.ReadLine();
        }
    }
}
