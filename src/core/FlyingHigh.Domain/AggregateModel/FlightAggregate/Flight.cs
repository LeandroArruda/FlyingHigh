using System;
using System.Collections.Generic;
using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.AggregateModel.FlightAggregate
{
    public class Flight : AggregateRoot
    {
        public Flight()
        {
            _passengers = new List<Passenger>();
        }
        public Flight(string name, Guid routeId, Guid airPlaneId)
        {
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
            RouteId = routeId;
            AirPlaneId = airPlaneId;
        }

        public string Name { get; private set; }
        public Guid RouteId { get; private set; }
        public Guid AirPlaneId { get; private set; }

        private readonly List<Passenger> _passengers;
        public IReadOnlyCollection<Passenger> Passengers => _passengers;

        public void AddPassenger(string name, int age, Gender gender)
        {
            var passenger = new Passenger(name, age, gender);
            _passengers.Add(passenger);
        }
    }
}