using System;

namespace Vererbung.CsharpMasterclass
{
    class Boss : Employee
    {
        public bool CompanyCar { get; set; }

        public Boss(bool companyCar, string name, string firstName, double salary) : base(name, firstName, salary)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine($"{FirstName} {Name}, the boss of the company, leads the employees to make their business.");
            Console.ReadKey();
        }
    }
}
