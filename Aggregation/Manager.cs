using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation.Gaz
{
    class Manager
    {
        private readonly string _name;
        public List<Worker> workers = new();

        public Manager(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
