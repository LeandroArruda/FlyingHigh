using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.AggregateModel.LocationAggregate
{
    public class Location : AggregateRoot
    {
        public string Name { get; private set; }
        public string Initials { get; private set; }
    }
}