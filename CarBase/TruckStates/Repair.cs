using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBase.TruckStates
{
    internal class Repair : ITruckState
    {
        public void ChangeDriver(Truck truck)
        {
            Console.WriteLine("It's impossible to change the driver.");
        }

        public void StartDriving(Truck truck)
        {
            Random random = new();
            int randomState = random.Next(2);
            if (randomState == 0)
            {
                Console.WriteLine("The truck was sent back to base.");
                truck.State = new Base();
            }
            else
            {
                Console.WriteLine("The truck was sent on a route.");
                truck.State = new Route();
            }
        }

        public void StartRepair(Truck truck)
        {
            Console.WriteLine("The truck is already being repaired.");
        }
    }
}
