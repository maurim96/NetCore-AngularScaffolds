using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project.Persistance.SQL.EFCore.SQLServer.Entities
{
    public partial class InitialDBContext : DbContext
    {
        public InitialDBContext()
        {
        }

        public InitialDBContext(DbContextOptions<InitialDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Summaries> Summaries { get; set; }
        public virtual DbSet<WheaterForecast> WheaterForecast { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=InitialDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Summaries>(entity =>
            {
                entity.Property(e => e.Summary)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WheaterForecast>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.TemperatureC).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Summary)
                    .WithMany(p => p.WheaterForecast)
                    .HasForeignKey(d => d.SummaryId)
                    .HasConstraintName("FK_WheaterForecast_Summaries");
            });
        }
    }
}
