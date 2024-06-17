using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumberOfWheels { get; set; } 

        public int NumberOfDoors { get; set; }

        public int NumberofCupHolders { get; set; }

        public int NumberOfWindows { get; set; }
        void VehicleDetails();
    }
   
   
}