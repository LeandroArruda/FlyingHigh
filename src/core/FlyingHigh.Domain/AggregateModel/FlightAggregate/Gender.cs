using System.Collections.Generic;
using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.AggregateModel.FlightAggregate
{
    public class Gender : ValueObject
    {
        public string Name { get; set; }
        public string Short { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
            yield return Short;
        }
    }
}