using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using console.Models;
namespace console.Contexts
{
    public partial class mydbContext : DbContext
    {
        public mydbContext()
        {
        }

        public mydbContext(DbContextOptions<mydbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Earthquake> Earthquakes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
        optionsBuilder.UseSqlite("Data Source=C:\\Users\\Administrator\\Desktop\\DEV\\myapp\\dbsample\\mydb.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Earthquake>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("earthquake");

                entity.Property(e => e.CalculationMethod).HasColumnName("calculation_method");

                entity.Property(e => e.Cause).HasColumnName("cause");

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.EarthquakeId).HasColumnName("earthquake_id");

                entity.Property(e => e.Latitude).HasColumnName("latitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Magnitude).HasColumnName("magnitude");

                entity.Property(e => e.NetworkId).HasColumnName("network_id");

                entity.Property(e => e.OccurredOn).HasColumnName("occurred_on");

                entity.Property(e => e.Place).HasColumnName("place");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
