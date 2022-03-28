namespace DependencyInjectionPractice
{
    public class Jet : IAircraft
    {
        public string Destination { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Departing { get; set; }
        public DateTime DepartureTime { get; set; }
        public Guid AircraftID { get; set; }
        public string AircraftType { get; set; }

        public Jet(string destination, DateTime arrivalTime, string departing,
                         DateTime departureTime, Guid aircraftID, string aircraftType)
        {
            Destination = destination;
            ArrivalTime = arrivalTime;
            Departing = departing;
            DepartureTime = departureTime;
            AircraftID = aircraftID;
            AircraftType = aircraftType;
        }
    }
}