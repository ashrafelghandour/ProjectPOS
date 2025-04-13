using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using POSDemo.Entites;

namespace POSDemo.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Custmer> Custmers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Productclassification> Productclassifications { get; set; }

    public virtual DbSet<SelesBill> SelesBills { get; set; }

    public virtual DbSet<SelesBillDetill> SelesBillDetills { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-I3NIFAB;database =POSTul;Encrypt=false;Integrated Security = true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Custmer>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Company).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasIndex(e => new { e.Name, e.Code }, "Product_Code_index").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasColumnType("image");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ClassesProductNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.ClassesProduct)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Products_Product classification");
        });

        modelBuilder.Entity<Productclassification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Product classification");

            entity.ToTable("Productclassification");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryname).HasMaxLength(50);
        });

        modelBuilder.Entity<SelesBill>(entity =>
        {
            entity.HasKey(e => e.BillId).HasName("PK_Bill");

            entity.ToTable("SelesBill");

            entity.Property(e => e.BillId).HasColumnName("BillID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Notes).HasMaxLength(100);
            entity.Property(e => e.TotalAfterDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Customer).WithMany(p => p.SelesBills)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelesBill_Custmers");

            entity.HasOne(d => d.User).WithMany(p => p.SelesBills)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelesBill_Users");
        });

        modelBuilder.Entity<SelesBillDetill>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PruductId).HasColumnName("PruductID");
            entity.Property(e => e.SelesBillId).HasColumnName("SelesBillID");
            entity.Property(e => e.TotalPrice).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Pruduct).WithMany(p => p.SelesBillDetills)
                .HasForeignKey(d => d.PruductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelesBillDetills_Products");

            entity.HasOne(d => d.SelesBill).WithMany(p => p.SelesBillDetills)
                .HasForeignKey(d => d.SelesBillId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelesBillDetills_SelesBill");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Company).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("image");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Image).HasColumnType("image");
            entity.Property(e => e.Password)
                .HasMaxLength(80)
                .IsFixedLength();
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
