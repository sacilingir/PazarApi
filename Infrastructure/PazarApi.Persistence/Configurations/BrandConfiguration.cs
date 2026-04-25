using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PazarApi.Domain.Entities;
using System;

namespace PazarApi.Persistence.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(256);

            Faker faker = new("tr");

            // Bogus'u sabitliyoruz
            Randomizer.Seed = new Random(123);

            Brand brand1 = new()
            {
                Id = 1,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Parse("2024-01-01"), // Sabit Tarih
                IsDeleted = false,
            };

            Brand brand2 = new()
            {
                Id = 2,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Parse("2024-01-01"), // Sabit Tarih
                IsDeleted = false,
            };

            Brand brand3 = new()
            {
                Id = 3,
                Name = faker.Commerce.Department(),
                CreatedDate = DateTime.Parse("2024-01-01"), // Sabit Tarih
                IsDeleted = true,
            };
            builder.HasData(brand1, brand2, brand3);
        }
    }
}