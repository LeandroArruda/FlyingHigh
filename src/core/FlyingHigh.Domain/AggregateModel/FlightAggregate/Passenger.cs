using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.AggregateModel.FlightAggregate
{
    public class Passenger : Entity
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Gender Gender { get; private set; }
    }
}