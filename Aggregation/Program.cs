using Aggregation.Gaz;
using System;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new("Jonas Engelen");
            Worker worker1 = new("Reham Khamis");
            Worker worker2 = new("Max Engelen");
            manager.workers.Add(worker1);
            manager.workers.Add(worker2);

            foreach(Worker x in manager.workers)
            {
                Console.WriteLine(x.Name);
            }

            Console.ReadKey();
        }
    }
}
