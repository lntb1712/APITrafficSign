using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APITrafficSign.Models
{
    public partial class TrafficSignRecorgnitionContext : DbContext
    {
        public TrafficSignRecorgnitionContext()
        {
        }

        public TrafficSignRecorgnitionContext(DbContextOptions<TrafficSignRecorgnitionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TrafficSign> TrafficSigns { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=TrafficSignRecorgnition;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrafficSign>(entity =>
            {
                entity.HasKey(e => e.TrafficSignReco)
                    .HasName("PK__TrafficS__A06321A914D19674");

                entity.ToTable("TrafficSign");

                entity.Property(e => e.TrafficSignReco).HasMaxLength(50);

                entity.Property(e => e.TrafficSignCode).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
