using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace RepositoryLayer.Models;

public partial class CafeShopDbContext : DbContext
{
    public CafeShopDbContext()
    {
    }

    public CafeShopDbContext(DbContextOptions<CafeShopDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bill> Bills { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Member> Members { get; set; }

    public virtual DbSet<Cafe> Cafes { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(ConnectionString.GetConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bill>(entity =>
        {
            entity.Property(e => e.BillId).HasColumnName("BillID");
            entity.Property(e => e.CaId).HasColumnName("CaID");

            entity.HasOne(d => d.Cafe).WithMany(p => p.Bills)
                .HasForeignKey(d => d.CaId)
                .HasConstraintName("FK_Bills_Cafe");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Bills)
                .HasForeignKey(d => d.Status)
                .HasConstraintName("FK_Bills_Status");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CateId);

            entity.ToTable("Category");

            entity.Property(e => e.CateId).HasColumnName("CateID");
            entity.Property(e => e.CateName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Member>(entity =>
        {
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MemberName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cafe>(entity =>
        {
            entity.ToTable("Cafe");

            entity.Property(e => e.CaId).HasColumnName("CaID");
            entity.Property(e => e.CateId).HasColumnName("CateID");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ImportDate).HasColumnType("date");
            entity.Property(e => e.CafeName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Cate).WithMany(p => p.Cafes)
                .HasForeignKey(d => d.CateId)
                .HasConstraintName("FK_Cafe_Category");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.StarusId);

            entity.ToTable("Status");

            entity.Property(e => e.StarusId).HasColumnName("StarusID");
            entity.Property(e => e.StatusName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
