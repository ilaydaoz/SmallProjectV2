using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SmallProject.Entity
{
    public partial class EcommerceContext : DbContext
    {
        public EcommerceContext()
        {
        }

        public EcommerceContext(DbContextOptions<EcommerceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseNpgsql("host=127.0.0.1;port=5432;database=ecommerce;user id=postgres;password=12345");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("category");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Uniqueld).HasColumnName("uniqueld");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.HasIndex(e => e.CategoryId, "fki_fk_product_category_categoryId");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Buying).HasColumnName("buying");

                entity.Property(e => e.CategoryId).HasColumnName("categoryId");

                entity.Property(e => e.NumberOfProducts).HasColumnName("number of products");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("product name");

                entity.Property(e => e.Sales).HasColumnName("sales");

                entity.Property(e => e.UniqeuId).HasColumnName("uniqeuId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_product_category_categoryId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
