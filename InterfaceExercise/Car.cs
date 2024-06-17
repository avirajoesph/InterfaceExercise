using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car:IVehicle ,ICompany
    {
        public bool HasTrunk { get; set; }  

        public int  NumberOfSeats { get; set; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public int NumberofCupHolders { get ; set ; }
        public int NumberOfWindows { get ; set ; }
        public string CompanyLogo { get ; set ; }
        public string CompanyName { get ; set ; }


        public void VehicleDetails()
        {
            Console.WriteLine($"Suv details does car have trunk? {HasTrunk} ");
            Console.WriteLine($"does car have number of seats if so how much? {NumberOfSeats}");
            Console.WriteLine($"how many wheels does the car have?{NumberOfWheels}");
            Console.WriteLine($"how many doors does car have? {NumberOfDoors}");
            Console.WriteLine($"how many number of cupholders does car have? {NumberofCupHolders}");
            Console.WriteLine($"how many windows does car have? {NumberOfWindows}");
            Console.WriteLine($"what is car company logo? {CompanyLogo}");
            Console.WriteLine($"company name is what? {CompanyName}");






        }
    }







    
}
