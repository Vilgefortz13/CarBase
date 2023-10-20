using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CarBase
{
    internal class Autobase
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Driver { get; private set; }
        public string State { get; private set; }

        public Autobase(int id, string name, string driver, string state)
        {
            Id = id;
            Name = name;
            Driver = driver;
            State = state;
        }
    }
}
