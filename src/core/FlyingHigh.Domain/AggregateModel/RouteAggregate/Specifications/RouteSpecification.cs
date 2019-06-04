using System.Collections.Generic;
using System.Linq;
using FlyingHigh.Domain.Common;
using FlyingHigh.Domain.Interfaces;

namespace FlyingHigh.Domain.AggregateModel.RouteAggregate.Specifications
{
    public class IsRouteWithoutRepeatLocationSpecification : ISpecification<FlyingHigh.Domain.RouteAggregate.Route>
    {
        public bool IsSatisfiedBy(FlyingHigh.Domain.RouteAggregate.Route route)
        {
            if (route.DestinationLocationId == route.OriginLocationId)
                return false;
            if (route.StopsLocations.ToList().Exists(l => l == route.OriginLocationId))
                return false;
            if (route.StopsLocations.ToList().Exists(l => l == route.DestinationLocationId))
                return false;

            return true;
        }
    }

    public class IsNameUnique : ISpecification<FlyingHigh.Domain.RouteAggregate.Route>
    {
        private readonly IEnumerable<FlyingHigh.Domain.RouteAggregate.Route> _routes;
        public IsNameUnique(IEnumerable<FlyingHigh.Domain.RouteAggregate.Route> routes)
        {
            _routes = routes;
        }
        public bool IsSatisfiedBy(FlyingHigh.Domain.RouteAggregate.Route route)
        {
            return !_routes.ToList().Exists(r => r.Name == route.Name);
        }
    }
}