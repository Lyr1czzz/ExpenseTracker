using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models;

public partial class ExpenseTrakerDbContext : DbContext
{
    public ExpenseTrakerDbContext()
    {
    }

    public ExpenseTrakerDbContext(DbContextOptions<ExpenseTrakerDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ExpenseTrakerDB;Username=postgres;Password=rootroot");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("category_pkey");

            entity.ToTable("category");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Userid).HasColumnName("userid");

            entity.HasOne(d => d.User).WithMany(p => p.Categories)
                .HasForeignKey(d => d.Userid)
                .HasConstraintName("category_userid_fkey");
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("note_pkey");

            entity.ToTable("note");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Categoryid).HasColumnName("categoryid");
            entity.Property(e => e.Ruprice).HasColumnName("ruprice");
            entity.Property(e => e.Brprice).HasColumnName("brprice");
            entity.Property(e => e.Usdprice).HasColumnName("usdprice");
            entity.Property(e => e.Text)
                .HasMaxLength(50)
                .HasColumnName("text");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.HasOne(d => d.Category).WithMany(p => p.Notes)
                .HasForeignKey(d => d.Categoryid)
                .HasConstraintName("note_categoryid_fkey");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Brbalance)
                .HasPrecision(20, 2)
                .HasDefaultValueSql("0.0")
                .HasColumnName("brbalance");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .HasColumnName("login");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Rubalance)
                .HasPrecision(20, 2)
                .HasDefaultValueSql("0.0")
                .HasColumnName("rubalance");
            entity.Property(e => e.Usdbalance)
                .HasPrecision(20, 2)
                .HasDefaultValueSql("0.0")
                .HasColumnName("usdbalance");
            entity.Property(e => e.Pincode).HasColumnName("pincode");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
