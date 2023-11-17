using System;

namespace Vererbung.CsharpMasterclass
{
    class Trainee : Employee
    {
        public double WorkingHours { get; set; }
        public double SchoolHours { get; set; }

        public Trainee(double workingHours, double schoolHours, string name, string firstName, double salary) : base(name, firstName, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine($"And his schoolhours are right about {SchoolHours}h");
            Console.ReadKey();
        }

        public new void Work()
        {
            Console.WriteLine($"{FirstName} {Name} the trainee worked this year {WorkingHours}h");
            Console.ReadKey();
            Learn();
        }
    }
}
