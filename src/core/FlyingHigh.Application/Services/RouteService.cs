using System.Collections.Generic;
using FlyingHigh.Application.Interfaces;
using FlyingHigh.Domain.AggregateModel.RouteAggregate.Specifications;
using FlyingHigh.Domain.RouteAggregate;

namespace FlyingHigh.Application.Services
{
    public class RouteService : IRouteService
    {
        public int Insert(Route route)
        {
            //get a list from DB
            var routes = new List<Route>();

            if(new IsNameUnique(routes).IsSatisfiedBy(route))
            {

            }

            return 0;
        }
    }
}