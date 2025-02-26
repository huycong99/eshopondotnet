using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Product.EF.Models;

namespace Product.EF.Infrastructure.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Models.Product>
    {
        public void Configure(EntityTypeBuilder<Models.Product> builder)
        {
            builder.ToTable("t_product");
            builder.HasKey(x => x.Id)
                .HasName("PIMARY");

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int");

            builder.Property(x => x.Name)
                .HasColumnName("Name")
                .HasMaxLength(20);

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasMaxLength (20);

            builder.Property(x => x.Price)
                .HasColumnName("Price")
                .HasMaxLength(20);

            builder.Property(x => x.StockQuantity)
                .HasColumnType("int")
                .HasColumnName("StockQuantity");

            builder.Property(x => x.CategoryId)
                .HasColumnType("int")
                .HasColumnName("CategoryId");

        }
    }
}
