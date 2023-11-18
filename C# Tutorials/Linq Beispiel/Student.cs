namespace Linq_Beispiel
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        // Foreign Key
        public int UniversityId { get; set; }

        public Student(string name, int age, string male, int universityId)
        {
            Name = name;
            Age = age;
            Gender = male;
            UniversityId = universityId;
        }

        public void Print()
        {
            Console.WriteLine($"Student {Name} ist {Age} Jahre alt und {Gender}");
        }
    }

}
