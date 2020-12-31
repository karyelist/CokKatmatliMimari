using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SarkilarSozler.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SarkilarSozler.Data.Configurations
{
    public class SanatciConfiguration : IEntityTypeConfiguration<Sanatci>
    {
        public void Configure(EntityTypeBuilder<Sanatci> builder)
        {
            builder
                .HasKey(a => a.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Ad)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .ToTable("Sanatci");
        }
    }
}