using FlyingHigh.Domain.RouteAggregate;

namespace FlyingHigh.Application.Interfaces
{
    public interface IRouteService
    {
         int Insert(Route route);
    }
}