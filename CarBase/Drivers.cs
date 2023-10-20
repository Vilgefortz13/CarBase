using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBase
{
    internal class Drivers
    {
        public string Id { get; private set; }
        public string Name { get; private set; }

        public Drivers(string id, string name)
        {
            Id = id;
            Name = name;
        }
    
    }
}
