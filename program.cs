using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasClassDanObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi();

            taxi.DriverName = "awan";
            taxi.OnDuty = true;
            taxi.NumbOfPassenger = 17;

            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOfPassenger();

            Console.ReadKey();
        }
    }
}