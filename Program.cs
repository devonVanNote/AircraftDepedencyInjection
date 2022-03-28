using System;

namespace DependencyInjectionPractice
{
    public class TestingDependencyInjection
    {
        static void Main(string[] arguments)
        {
            IAircraft F16 = new Jet(Airports.StLouis, DateTime.Now.AddHours(3), Airports.Chicago, DateTime.Now.AddHours(2), Guid.NewGuid(), Aircraft.Jet);
            FlightOperations jetFlightOps = new FlightOperations(F16);
            jetFlightOps.PerformFlightOperations();

            IAircraft BlackHawk = new Helicopter(Airports.StLouis, DateTime.Now.AddHours(4), Airports.Chicago, DateTime.Now.AddHours(2), Guid.NewGuid(), Aircraft.Helicopter);
            FlightOperations heliFlightOps = new FlightOperations(BlackHawk);
            heliFlightOps.PerformFlightOperations();
        }
    }
}