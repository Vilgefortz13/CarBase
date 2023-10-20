using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBase.TruckStates
{
    internal class Base : ITruckState
    {
        public void ChangeDriver(Truck truck)
        {
            
        }

        public void StartDriving(Truck truck)
        {
            Console.WriteLine("The truck was successfully on the route.");
            truck.State = new Route();
        }

        public void StartRepair(Truck truck)
        {
            Console.WriteLine("The truck was sent in for repairs.");
            truck.State = new Repair();
        }
    }
}
