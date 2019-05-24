using System;
using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.AggregateModel.AirPlaneAggregate
{
    public class AirPlane : AggregateRoot
    {
        public string Name { get; private set; }
        public int MaxPassengers { get; private set; }
        
    }
}
