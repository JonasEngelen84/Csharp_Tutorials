namespace Linq_Beispiel
{
    public class University
    {
        public string Name { get; set; }

        // Foreign Key
        public int Id { get; set; }

        public University(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
