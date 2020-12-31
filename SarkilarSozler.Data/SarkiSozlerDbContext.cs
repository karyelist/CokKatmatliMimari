using Microsoft.EntityFrameworkCore;
using SarkilarSozler.NetCore.Models;
using SarkilarSozler.Data.Configurations;
using System;
using System.Collections.Generic;
using System.Text;


namespace SarkilarSozler.Data
{
    public class SarkiSozlerDbContext:DbContext
    {
        public DbSet<Sarkilar> Sarkilar { get; set; }
        public DbSet<Sanatci> Sanatcilar { get; set; }

        public SarkiSozlerDbContext(DbContextOptions<SarkiSozlerDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new SarkilarConfiguration());

            builder
                .ApplyConfiguration(new SanatciConfiguration());
        }
    }
}
 