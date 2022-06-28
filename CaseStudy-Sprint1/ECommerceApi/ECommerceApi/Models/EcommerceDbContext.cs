using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ECommerceApi.Models
{
    public partial class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext()
        {
        }

        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Addcart> Addcarts { get; set; }
        public virtual DbSet<OrderList> OrderLists { get; set; }
        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblLogin> TblLogins { get; set; }
        public virtual DbSet<TblProduct> TblProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8T2OLIG;Initial Catalog=EcommerceDb;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Addcart>(entity =>
            {
                entity.ToTable("addcart");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductDescription).HasMaxLength(100);

                entity.Property(e => e.ProductFinal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductImage).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(1);
            });

            modelBuilder.Entity<OrderList>(entity =>
            {
                entity.ToTable("OrderList");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductMrp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("TblCategory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CatName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblLogin>(entity =>
            {
                entity.ToTable("TblLogin");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasMaxLength(150);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.PhoneNo).HasColumnName("Phone No.");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.ToTable("TblProduct");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductDescription).HasMaxLength(100);

                entity.Property(e => e.ProductDiscount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductFinal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductImage).HasMaxLength(100);

                entity.Property(e => e.ProductMrp).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProductName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
