using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBase.TruckStates
{
    internal class Route : ITruckState
    {
        public void ChangeDriver(Truck truck)
        {
            Console.WriteLine("It's impossible to change the driver in the route.");
        }

        public void StartDriving(Truck truck)
        {
            Console.WriteLine("The truck is alredy in the route.");
        }

        public void StartRepair(Truck truck)
        {
            Console.WriteLine("The truck was sent in for repairs.");
            truck.State = new Repair();
        }
    }
}
