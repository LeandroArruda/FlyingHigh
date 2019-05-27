using System;
using FlyingHigh.Domain.Interfaces;

namespace FlyingHigh.Domain.Common
{
    public static class ExtensionMethods
    {
        public static ISpecification<T> And<T>(this ISpecification<T> spec1, ISpecification<T> spec2)
        {
            return new AndSpecification<T>(spec1, spec2);
        }

        public static ISpecification<T> Or<T>(this ISpecification<T> spec1, ISpecification<T> spec2)
        {
            return new OrSpecification<T>(spec1, spec2);
        }

        public static ISpecification<T> Not<T>(this ISpecification<T> spec)
        {
            return new NotSpecification<T>(spec);
        }
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _spec1;
        private readonly ISpecification<T> _spec2;

        public AndSpecification(ISpecification<T> spec1, ISpecification<T> spec2)
        {
            if (spec1 == null)
                throw new ArgumentNullException("spec1");

            if (spec2 == null)
                throw new ArgumentNullException("spec2");

            _spec1 = spec1;
            _spec2 = spec2;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return _spec1.IsSatisfiedBy(candidate) && _spec2.IsSatisfiedBy(candidate);
        }
    }

    public class OrSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _spec1;
        private readonly ISpecification<T> _spec2;

        public OrSpecification(ISpecification<T> spec1, ISpecification<T> spec2)
        {
            if (spec1 == null)
                throw new ArgumentNullException("spec1");

            if (spec2 == null)
                throw new ArgumentNullException("spec2");

            _spec1 = spec1;
            _spec2 = spec2;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return _spec1.IsSatisfiedBy(candidate) || _spec2.IsSatisfiedBy(candidate);
        }
    }

    public class NotSpecification<T> : ISpecification<T>
    {
        private readonly ISpecification<T> _spec;

        public NotSpecification(ISpecification<T> spec)
        {
            if (spec == null)
                throw new ArgumentNullException("spec");

            _spec = spec;
        }

        public bool IsSatisfiedBy(T candidate)
        {
            return !_spec.IsSatisfiedBy(candidate);
        }
    }
}