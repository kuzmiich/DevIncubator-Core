using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.ClassesStructures.Component
{
    struct Belavia
    {
        public Belavia(string destinationName, int aircraftNumber, string flightType)
        {
            DestinationName = destinationName;
            AircraftNumber = aircraftNumber;
            FlightType = flightType;
        }

        public string DestinationName { get; set; }
        public int AircraftNumber { get; }
        public string FlightType { get; private set; }

        public override string ToString()
        {
            return $"Destination name - {DestinationName}, aircraft number - {AircraftNumber}";
        }
    }
}
