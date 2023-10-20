using CarBase.TruckStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBase
{
    internal class Truck
    {
        public ITruckState State { get; set; }

        public Truck(ITruckState ts)
        {
            State = ts;
        }
        
        public void ChangeDriver()
        {
            State.ChangeDriver(this);
        }

        public void StartDriving()
        {
            State.StartDriving(this);
        }

        public void StartRepair()
        {
            State.ChangeDriver(this);
        }
    }
}