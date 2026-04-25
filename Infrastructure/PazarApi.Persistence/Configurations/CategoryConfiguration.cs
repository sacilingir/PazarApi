using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PazarApi.Domain.Entities;
using System;

namespace PazarApi.Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                Name = "Elektrik",
                Priority = 1,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Parse("2024-01-01"), // Sabit Tarih
            };

            Category category2 = new()
            {
                Id = 2,
                Name = "Moda",
                Priority = 2,
                ParentId = 0,
                IsDeleted = false,
                CreatedDate = DateTime.Parse("2024-01-01"), // Sabit Tarih
            };

            Category parent1 = new()
            {
                Id = 3,
                Name = "Bilgisayar",
                Priority = 1,
                ParentId = 1,
                IsDeleted = false,
                CreatedDate = DateTime.Parse("2024-01-01"), // Sabit Tarih
            };

            Category parent2 = new()
            {
                Id = 4,
                Name = "Kadın",
                Priority = 1,
                ParentId = 2,
                IsDeleted = false,
                CreatedDate = DateTime.Parse("2024-01-01"), // Sabit Tarih
            };

            builder.HasData(category1, category2, parent1, parent2);
        }
    }
}