using System;

namespace DependencyInjectionPractice
{
    public class FlightOperations 
    {
        private IAircraft Aircraft;
        public FlightOperations(IAircraft aircraft)
        {
            Aircraft = aircraft;
        }

        public void PerformFlightOperations()
        {
            Console.WriteLine($"----------Performing Flight Operations---------");
            Console.WriteLine($"Aircraft ID: {Aircraft.AircraftID}");
            Console.WriteLine($"Aircraft Type: {Aircraft.AircraftType}");
            Console.WriteLine($"Departing {Aircraft.Departing} at {Aircraft.DepartureTime}");
            Console.WriteLine($"Arriving at {Aircraft.Destination} at {Aircraft.ArrivalTime}");
            Console.WriteLine("------------------------------------------------");
        }
    }
}