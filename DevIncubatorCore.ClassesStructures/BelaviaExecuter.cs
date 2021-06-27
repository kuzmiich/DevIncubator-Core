using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevIncubatorCore.ClassesStructures.Component;

namespace DevIncubatorCore.ClassesStructures
{
    class BelaviaExecuter : ITask
    {
        private const int MaxAircraftNumber = 10000;

        private static string[] _destinationNames =
        {
            "Minsk", "London", "Vashington", "Talin", "Copenhagen", "Piter"
        };
        private static string[] _aircraftTypes =
        {
            "Passenger", "Cargo", "Combat"
        };
        private static Random _random = new();

        public void RunTask()
        {
            Console.Write("Input count of flight: ");
            var count = Extractor.GetInt32(Console.ReadLine());

            var flights = new Belavia[count];
            for (int i = 0; i < count; i++)
            {
                var name = _destinationNames[_random.Next(_destinationNames.Length)];
                var aircraftNumber = _random.Next(MaxAircraftNumber);
                var type = _aircraftTypes[_random.Next(_aircraftTypes.Length)];
                flights[i] = new Belavia(name, aircraftNumber, type);
            }

            Console.Write("Input flight type: ");
            var searchType = Console.ReadLine();

            foreach (var flight in flights)
            {
                if (searchType.Equals(flight.FlightType))
                {
                    Console.WriteLine(flight);
                }
            }
        }
    }
}
