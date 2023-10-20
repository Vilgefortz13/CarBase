using System;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;
using CarBase.TruckStates;

namespace CarBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string jsonAutobase = File.ReadAllText("../../../autobase.json");
                string jsonDrivers = File.ReadAllText("../../../drivers.json");

                List<Autobase> autobase = JsonConvert.DeserializeObject<List<Autobase>>(jsonAutobase);
                List<Drivers> drivers = JsonConvert.DeserializeObject<List<Drivers>>(jsonDrivers);
                PrintAutobaseInfo(autobase);
                Console.WriteLine();
                PrintDirversInfo(drivers);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found!");
            }

            Truck truck = new Truck(new Base());
            truck.StartDriving();
            truck.StartDriving();
        }

        static void PrintAutobaseInfo(List<Autobase> autobase)
        {
            Console.WriteLine("  # | Bus               | Driver    | State");
            Console.WriteLine("----+-------------------+-----------+-----------");
            foreach (var item in autobase)
            {
                Console.WriteLine($"  {item.Id} | {item.Name,-17} | {item.Driver,-9} | {item.State}");
            }
        }

        static void PrintDirversInfo(List<Drivers> drivers)
        {
            Console.WriteLine("  # | Driver    | Bus");
            Console.WriteLine("----+-----------+---------");
            for (int i = 0; i < drivers.Count; i++)
            {
                Console.WriteLine($"  {i + 1} | {drivers[i].Name,-10}|");
            }
        }
    }
}