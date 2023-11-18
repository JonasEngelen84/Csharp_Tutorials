namespace Komposition.Gaz
{
    class Manager
    {
        private readonly string _name;
        public string Name
        {
            get { return _name; }
        }

        public Manager(string name)
        {
            _name = name;
        }
    }
}
