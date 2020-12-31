using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SarkilarSozler.NetCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SarkilarSozler.Data.Configurations
{
    public class SarkilarConfiguration : IEntityTypeConfiguration<Sarkilar>
    {
        public void Configure(EntityTypeBuilder<Sarkilar> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Ad)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasOne(m => m.Sanatcilar)
                .WithMany(n => n.Sarkilar)
                .HasForeignKey(m => m.SanatciId);

            builder
                .ToTable("Sarkilar");
        }
    }
}