using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Suv :IVehicle , ICompany
    {
        public bool HasSpace { get; set; }

        public bool IsAllWheelDrive { get; set;}
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberofCupHolders { get; set; }
        public int NumberOfWindows { get; set;}
        public string CompanyLogo { get; set; }
        public string CompanyName { get; set;}

        public void VehicleDetails()
        {

            Console.WriteLine($"Suv details does suv have space {HasSpace} ");
            Console.WriteLine($"does suv have All Wheel Drive? {IsAllWheelDrive}");
            Console.WriteLine($"how many wheels does the suv have?{NumberOfWheels}");
            Console.WriteLine($"how many doors does suv have? {NumberOfDoors}");
            Console.WriteLine($"how many number of cupholders does suv have? {NumberofCupHolders}");
            Console.WriteLine($"how many windows does suv have? {NumberOfWindows}");
            Console.WriteLine($"what is suv company logo? {CompanyLogo}");
            Console.WriteLine($"company name is what? {CompanyName}");

        }

        






        
    }

}
