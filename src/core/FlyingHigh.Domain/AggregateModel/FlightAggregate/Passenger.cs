using FlyingHigh.Domain.AggregateModel.FlightAggregate.Specifications;
using FlyingHigh.Domain.Common;
using System;

namespace FlyingHigh.Domain.AggregateModel.FlightAggregate
{
    public class Passenger : Entity
    {
        public Passenger(string name, int age, Gender gender)
        {
            Name = !string.IsNullOrEmpty(name) ? name : throw new ArgumentNullException(nameof(name));
            Age = age;
            Gender = gender;

            if(new IsPassengerAboveOrEquals13years().IsSatisfiedBy(this))
                throw new DomainException("Passenger's age must be 13 or higher.");
        }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Gender Gender { get; private set; }
    }
}