using System;

namespace Vererbung.CsharpMasterclass
{
    public class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }

        private double salary;
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if(value < 0)
                    salary = 0;
                else
                    salary = value;
            }
        }

        public Employee(string name, string firstName, double salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public void Work()
        {
            System.Console.WriteLine($"{FirstName} {Name} is working hard to get his salary of {Salary}$");
            Console.ReadKey();
            Pause();
        }

        public void Pause()
        {
            Console.WriteLine("Now he got a pause!");
            Console.ReadKey();
        }
    }
}
