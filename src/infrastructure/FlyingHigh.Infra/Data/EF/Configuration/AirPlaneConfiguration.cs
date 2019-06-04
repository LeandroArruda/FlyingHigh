using System;
using FlyingHigh.Domain.AggregateModel.AirPlaneAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlyingHigh.Infra.Data.EF.Configuration
{
    public class AirPlaneConfiguration : IEntityTypeConfiguration<AirPlane>
    {
        public void Configure(EntityTypeBuilder<AirPlane> builder)
        {            
            builder.HasKey(e => e.Id);            
            builder.Ignore(b => b.DomainEvents);
            builder.Property<Guid>("Id").ValueGeneratedOnAdd();
            builder.Property<string>("Name").IsRequired().HasMaxLength(200);
            builder.Property<int>("MaxPassengers").IsRequired();
        }
    }
}