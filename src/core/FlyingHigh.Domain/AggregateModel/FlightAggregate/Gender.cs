using System;
using System.Collections.Generic;
using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.AggregateModel.FlightAggregate
{
    public class Gender : ValueObject
    {
        public Gender(string name, string @short)
        {
            Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentNullException(nameof(name));
            Short = !string.IsNullOrWhiteSpace(@short) ? @short : throw new ArgumentNullException(nameof(@short));
        }
        public string Name { get; private set; }
        public string Short { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
            yield return Short;
        }
    }
}