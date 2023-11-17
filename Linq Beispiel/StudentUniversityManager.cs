namespace Linq_Beispiel
{
    public class StudentUniversityManager
    {
        List<Student> students;
        List<University> universities;

        public StudentUniversityManager()
        {
            students = new List<Student>
            {
                new Student("Anna", 21, "weiblich", 1),
                new Student("Jonas", 24, "männlich", 2),
                new Student("Luca", 21, "männlich", 2),
                new Student("Max", 23, "männlich", 1),
                new Student("Laura", 20, "weiblich", 3),
                new Student("Anton", 19, "männlich", 1),
                new Student("Julia", 22, "weiblich", 3)
            };

            universities = new List<University>
            {
                new University(1, "Harvard"),
                new University(2, "Tennessee"),
                new University(3, "Lincoln")
            };
        }

        public void FindMaleStudents()
        {
            // Linq: Sortiert nur die männlichen Studenten dem Alter absteigend (descending)
            IEnumerable<Student> maleStudents = from student in students
                                                where student.Gender == "männlich"
                                                orderby student.Age descending
                                                select student;

            // Linq: vertauscht die Reihenfolge einer collection
            IEnumerable<Student> reverseMaleStudents = maleStudents.Reverse();

            Console.WriteLine("Männliche Studenten:");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }
        }

        public void SelectUniversity()
        {
            Console.WriteLine("\nGib die Universität ein. (Harvard, Tennessee, Lincoln):");
            string userEingabe = Console.ReadLine();

            // Linq: Verknüpft zwei collections per foreign key (join in on equals)
            IEnumerable<Student> choosenUniversity = from university in universities
                                                     join student in students on university.Id equals student.UniversityId
                                                     where university.Name == userEingabe
                                                     select student;

            Console.WriteLine($"\nAn der {userEingabe} Universität befinden sich folgende Studenten:");
            foreach (Student student in choosenUniversity)
            {
                student.Print();
            }
        }

        public void StudentAndUniversityName()
        {
            // Linq: bestimmte Werte aus zwei collections in eine separate collection speichern
            var studentAndUniversityCollection = from student in students
                                                 join university in universities on student.UniversityId equals university.Id
                                                 orderby university.Name
                                                 select new { StudentName = student.Name, UniversityName = university.Name };

            Console.WriteLine("\nSeparate Liste erstellen:");
            foreach (var x in studentAndUniversityCollection)
            {
                Console.WriteLine($"Student {x.StudentName} studiert an der {x.UniversityName} Universität");
            }
        }
    }
}
