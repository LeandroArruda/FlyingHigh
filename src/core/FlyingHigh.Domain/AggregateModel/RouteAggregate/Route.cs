using System;
using System.Collections.Generic;
using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.RouteAggregate
{
    public class Route : AggregateRoot
    {
        public Route()
        {
            _StopsLocations = new List<Guid>();
        }
        public string Name { get; private set; }
        public Guid DestinationLocationId { get; private set; }
        public Guid OriginLocationId { get; private set; }
        private readonly List<Guid> _StopsLocations;
        public IReadOnlyCollection<Guid> StopsLocations => _StopsLocations;          

        //When creating a route, check if the locations don't repeat
    }
}