using System.Collections.Generic;
using FlyingHigh.Application.Interfaces;
using FlyingHigh.Domain.RouteAggregate;
using FlyingHigh.Domain.Specifications.Route;

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