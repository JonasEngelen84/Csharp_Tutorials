using System.Xml.Linq;

namespace Linq_Beispiel
{
    internal class XMLBeispiel
    {
        public void UseXMLString()
        {
            string xmlString =
            @"<Students>
                <Student>
                    <Name>Max</Name>
                    <Age>23</Age>
                    <University>Harvard</University>
                </Student>
                <Student>
                    <Name>Jonas</Name>
                    <Age>37</Age>
                    <University>Harvard</University>
                </Student>
                <Student>
                    <Name>Luca</Name>
                    <Age>11</Age>
                    <University>Tennessee</University>
                </Student>
                <Student>
                    <Name>Dillon</Name>
                    <Age>16</Age>
                    <University>Lincoln</University>
                </Student>
                <Student>
                    <Name>Reham</Name>
                    <Age>35</Age>
                    <University>Harvard</University>
                </Student>
                <Student>
                    <Name>Laura</Name>
                    <Age>39</Age>
                    <University>Lincoln</University>
                </Student>
                <Student>
                    <Name>Nora</Name>
                    <Age>37</Age>
                    <University>Tennessee</University>
                </Student>
            </Students>";
            XDocument xmlDocument = new();
            xmlDocument = XDocument.Parse(xmlString);

            // Linq: Lesen aus XML-String durch verwendung der Descendants()
            var studentInfo = from student in xmlDocument.Descendants("Student")
                              select new
                              {
                                  Name = student.Element("Name").Value,
                                  Age = student.Element("Age").Value,
                                  University = student.Element("University").Value,
                              };

            Console.WriteLine("\nLesen aus XML-String:");
            foreach (var student in studentInfo)
            {
                Console.WriteLine($"Der/die Student/in {student.Name} ist {student.Age} Jahre alt und besucht die {student.University} Universität.");
            }
        }
    }
}
