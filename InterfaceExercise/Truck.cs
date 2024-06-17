using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle , ICompany
    {
        public bool HasWheels { get; set; }

        public int HasTruckBed { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberofCupHolders { get; set; }
        public int NumberOfWindows { get; set; }
        public string CompanyLogo { get; set; }
        public string CompanyName { get; set; }

        public void VehicleDetails() 
        {
            Console.WriteLine($"Suv details does suv have wheels {HasWheels} ");
            Console.WriteLine($"does truck have a truckbed? {HasTruckBed}");
            Console.WriteLine($"how many wheels does the truck have?{NumberOfWheels}");
            Console.WriteLine($"how many doors does truck have? {NumberOfDoors}");
            Console.WriteLine($"how many number of cupholders does truck have? {NumberofCupHolders}");
            Console.WriteLine($"how many windows does truck have? {NumberOfWindows}");
            Console.WriteLine($"what is truck company logo? {CompanyLogo}");
            Console.WriteLine($"company name is what? {CompanyName}");




        }

    }
}
     