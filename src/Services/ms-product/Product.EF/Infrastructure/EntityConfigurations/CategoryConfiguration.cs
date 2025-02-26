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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("t_category");
            builder.HasKey(c => c.Id).HasName("PRIMARY");

            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .HasColumnType("int");
            builder.Property(x => x.Name)
                .HasMaxLength(20)
                .HasColumnName("Name");
        }
    }
}
