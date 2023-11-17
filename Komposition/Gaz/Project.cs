namespace Komposition.Gaz
{
    class Project
    {
        private readonly Manager _manager;
        public string Managername
        {
            get { return _manager.Name; }
        }

        private readonly string _name;
        public string Name
        {
            get { return _name; }
        }
        public Project(Manager manager, string name)
        {
            _manager = manager;
            _name = name;
        }
    }
}
