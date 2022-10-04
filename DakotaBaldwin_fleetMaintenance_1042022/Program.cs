using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DakotaBaldwin_fleetMaintenance_1042022
{
    class vehicleAttributes // Class holding different vehicle attributes
    {
        public string make;
        public string model;
        public int currentMileage;
    }
    class maintenanceRecords // Class holding different maintenance records
    {
        public string serviceType;
        public string serviceDate;
        public int serviceMileage;

        static void Main(string[] args)
        {
            vehicleAttributes lastService = new vehicleAttributes();
            lastService.make = "Ford";
            lastService.model = "F-150";
            lastService.currentMileage = 125000;

            Console.WriteLine("Vehicles Service Details:");
            Console.WriteLine("Vehicle Make: " + lastService.make);
            Console.WriteLine("Vehicle Model: " + lastService.model);
            Console.WriteLine("Current Mileage: " + lastService.currentMileage);

            maintenanceRecords vehicleRecords = new maintenanceRecords();
            vehicleRecords.serviceType = "Oil Change";
            vehicleRecords.serviceDate = "06-4-2022";
            vehicleRecords.serviceMileage = 104000;

            Console.WriteLine("\n" + "Last service performed: " + vehicleRecords.serviceType);
            Console.WriteLine("Last service date: " + vehicleRecords.serviceDate);
            Console.WriteLine("Mileage recorded on last service date (" + vehicleRecords.serviceDate + "): " + vehicleRecords.serviceMileage);
            Console.ReadKey();

        }
    }
}
