using System;
using System.Collections.Generic;
using FlyingHigh.Domain.AggregateModel.RouteAggregate.Specifications;
using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.RouteAggregate
{
    public class Route : AggregateRoot
    {
        public Route(string name, Guid destinationLocationId, Guid originLocationId, List<Guid> stopsLocations)
        {
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
            DestinationLocationId = destinationLocationId;
            OriginLocationId = originLocationId;
            _StopsLocations = stopsLocations;

            if(new IsRouteWithoutRepeatLocationSpecification().IsSatisfiedBy(this))
                throw new DomainException("Route can not have the same Location more than once.");
        }
        public string Name { get; private set; }
        public Guid DestinationLocationId { get; private set; }
        public Guid OriginLocationId { get; private set; }
        private readonly List<Guid> _StopsLocations;
        public IReadOnlyCollection<Guid> StopsLocations => _StopsLocations;          
    }
}