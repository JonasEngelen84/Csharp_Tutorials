using System;

namespace Assoziation.Gaz
{
    class Card
    {
        private readonly string _registerCard;

        public Card(string registerCard)
        {
            _registerCard = registerCard;
        }

        public string RegisterCard
        {
            get { return _registerCard; }

        }

        public void Swipe(Manager manager)
        {
            Console.WriteLine($"Swipe the manager: {manager.Name} with card number {RegisterCard}");
        }

        public void Log()
        {
            Console.WriteLine("event logged");
        }
    }
}
