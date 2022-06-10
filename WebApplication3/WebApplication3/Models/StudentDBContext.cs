using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication3.Models
{
    public partial class StudentDBContext : DbContext
    {
        public StudentDBContext()
        {
        }

        public StudentDBContext(DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coursedetail> Coursedetails { get; set; }
        public virtual DbSet<Studentdetail> Studentdetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8T2OLIG;Initial Catalog=StudentDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Coursedetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Course)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("course");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Studentdetail>(entity =>
            {
                entity.HasKey(e => e.Rollno)
                    .HasName("PK__Studentd__FABA8B5B5E5C5E34");

                entity.Property(e => e.Rollno).HasColumnName("rollno");

                entity.Property(e => e.Cid).HasColumnName("cid");

                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fname");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
