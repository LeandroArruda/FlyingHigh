using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.AggregateModel.AirPlaneAggregate
{
    public class AirPlane : AggregateRoot
    {
        public AirPlane(string name, int maxPassengers)
        {
            Name = !string.IsNullOrWhiteSpace(name) 
                                    ? name 
                                    : throw new ArgumentNullException(nameof(name));
            MaxPassengers = maxPassengers;
        }
        public string Name { get; private set; }
        public int MaxPassengers { get; private set; }
        
    }
}
