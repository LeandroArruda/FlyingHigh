using System;
using System.Collections.Generic;
using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.RouteAggregate
{
    public class Route : AggregateRoot
    {
        public string Name { get; private set; }
        public Guid DestinationLocationId { get; private set; }
        public List<Guid> StopsLocationsId { get; set; }
        public Guid OriginLocationId { get; private set; }

        //When creating a route, check if the Destination and Origin is different
    }
}