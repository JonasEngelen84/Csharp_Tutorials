namespace Assoziation.Gaz
{
    class Manager
    {
        private readonly string _name;

        public Manager(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public void Login(Card card)
        {
            card.Swipe(this);
            card.Log();
        }
    }
}
