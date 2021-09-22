namespace DevIncubatorCore.ClassesStructures.Component
{
    internal struct Belavia
    {
        public Belavia(string destinationName, int aircraftNumber, string flightType)
        {
            DestinationName = destinationName;
            AircraftNumber = aircraftNumber;
            FlightType = flightType;
        }

        public string DestinationName { get; set; }
        public int AircraftNumber { get; }
        public string FlightType { get; }

        public override string ToString()
        {
            return $"Destination name - {DestinationName}, aircraft number - {AircraftNumber}";
        }
    }
}