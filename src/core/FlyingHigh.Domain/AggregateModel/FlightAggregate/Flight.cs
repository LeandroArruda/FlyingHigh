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
        public Flight(string name, Guid routeId)
        {
            Name = name;
            RouteId = routeId;
        }

        public string Name { get; private set; }
        public Guid RouteId { get; private set; }
        public Guid AirPlaneId { get; private set; }

        private readonly List<Passenger> _passengers;
        public IReadOnlyCollection<Passenger> Passengers => _passengers;

        public void AddPassenger(Passenger passenger)
        {
            _passengers.Add(passenger);
        }
    }
}