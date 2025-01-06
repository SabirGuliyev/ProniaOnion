
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProniaOnion.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ProniaOnion.Persistence.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(x => x.Name)
                .IsRequired()
            .HasMaxLength(100);

            builder
                .Property(x => x.Price)
                .IsRequired()
                .HasColumnType("decimal(6,2)");

            builder
                .Property(x => x.SKU)
                .HasColumnType("char(10)");

        }
    }
}
