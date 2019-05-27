using System;
using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.AggregateModel.LocationAggregate
{
    public class Location : AggregateRoot
    {
        public Location(string name, string initials)
        {
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
            Initials = !string.IsNullOrWhiteSpace(initials) ? initials : throw new ArgumentNullException(nameof(initials));
        }
        public string Name { get; private set; }
        public string Initials { get; private set; }
    }
}