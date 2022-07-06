using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ImageLabApi.Models
{
    public partial class ImageLabDBContext : DbContext
    {
        public ImageLabDBContext()
        {
        }

        public ImageLabDBContext(DbContextOptions<ImageLabDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblImage> TblImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8T2OLIG;Initial Catalog=ImageLabDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblImage>(entity =>
            {
                entity.ToTable("TblImage");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Image).HasMaxLength(100);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(100)
                    .HasColumnName("imageName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
