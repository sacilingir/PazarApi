using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PazarApi.Domain.Entities;
using System;

namespace PazarApi.Persistence.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            Faker faker = new("tr");

            // Bogus'u sabitliyoruz
            Randomizer.Seed = new Random(123);

            Detail detail1 = new()
            {
                Id = 1,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 1,
                CreatedDate = DateTime.Parse("2024-01-01"), // Sabit Tarih
                IsDeleted = false
            };

            Detail detail2 = new()
            {
                Id = 2,
                Title = faker.Lorem.Sentence(2),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 3,
                CreatedDate = DateTime.Parse("2024-01-01"), // Sabit Tarih
                IsDeleted = true
            };

            Detail detail3 = new()
            {
                Id = 3,
                Title = faker.Lorem.Sentence(1),
                Description = faker.Lorem.Sentence(5),
                CategoryId = 4,
                CreatedDate = DateTime.Parse("2024-01-01"), // Sabit Tarih
                IsDeleted = false
            };

            builder.HasData(detail1, detail2, detail3);
        }
    }
}