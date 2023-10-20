using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBase.TruckStates
{
    internal interface ITruckState
    {
        void ChangeDriver(Truck truck);
        void StartDriving(Truck truck);
        void StartRepair(Truck truck);
    }
}
