using System.Collections.Generic;
using System.Linq;
using FlyingHigh.Domain.Common;
using FlyingHigh.Domain.Interfaces;

namespace FlyingHigh.Domain.AggregateModel.FlightAggregate.Specifications
{
    public class IsPassengerAboveOrEquals13years : ISpecification<FlyingHigh.Domain.AggregateModel.FlightAggregate.Passenger>
    {
        public bool IsSatisfiedBy(FlyingHigh.Domain.AggregateModel.FlightAggregate.Passenger passenger)
        {
            if (passenger.Age < 13)
                return false;
   
            return true;
        }
    }
}