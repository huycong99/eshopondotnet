using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace User.EF.Infrastructure.EntityConfigurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<Models.User>
    {
        public void Configure(EntityTypeBuilder<Models.User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Username)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(u => u.PasswordHash)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(u => u.Email)
                .HasMaxLength(100);

            builder.Property(u => u.FullName)
                .HasMaxLength(100);

            builder.Property(u => u.CreatedAt);
                //.HasDefaultValueSql("GETUTCDATE()"); // đã có datetime now ở model
        }
    }
}
