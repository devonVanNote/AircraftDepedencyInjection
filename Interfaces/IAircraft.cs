using System;

namespace DependencyInjectionPractice 
{
    public interface IAircraft
    {
        public string Destination { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Departing { get; set; }
        public DateTime DepartureTime { get; set; }
        public Guid AircraftID { get; set; }
        public string AircraftType { get; }
    }
}