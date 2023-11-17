using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation.Gaz
{
    class Worker
    {
        private readonly string _name;

        public Worker(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }

        }
    }
}
