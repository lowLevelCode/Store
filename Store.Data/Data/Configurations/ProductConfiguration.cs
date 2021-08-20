using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infraestructura.Data.Configurations
{
    public class ProductConfiguration: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Name).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(100);
            builder.Property(e => e.AgeRestriction).HasMaxLength(100).IsFixedLength();
            builder.Property(e => e.Company).HasMaxLength(50).IsRequired();
            builder.Property(e => e.Price).HasMaxLength(1000).IsFixedLength().IsRequired();

            builder.HasData(
                new Product
                {
                    Id= 1,
                    Name= "Bicycle Tom Hanks",
                    AgeRestriction = 12,
                    Company = "TomHanksor",
                    Price=123,
                    Description="Awesome Bicycle"
                },
                new Product
                {
                    Id = 2,
                    Name = "Train Handsome",
                    AgeRestriction = 99,
                    Company = "HandsOver",
                    Price = 123,
                    Description = "Awesome Train"
                },
                new Product
                {
                    Id = 3,
                    Name = "Teddy bear",
                    AgeRestriction = 80,
                    Company = "BearLand",
                    Price = 1000,
                    Description = "Cute BearLand"
                },
                new Product
                {
                    Id = 4,
                    Name = "Rubber ducky",
                    AgeRestriction = 80,
                    Company = "DuckHunter",
                    Price = 200,
                    Description = "Ducker"
                },
                new Product
                {
                    Id = 5,
                    Name = "Good guy doll",
                    AgeRestriction = 80,
                    Company = "GoodGuyCompany",
                    Price = 800,
                    Description = "GoodGuyCompany Description"
                }
            );
        }
    }
}
