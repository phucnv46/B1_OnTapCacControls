using System;
using System.Collections.Generic;
using B6_ChuaDeMau2.Models;
using Microsoft.EntityFrameworkCore;

namespace B6_ChuaDeMau2.DataContext;

public partial class PhucNv46Context : DbContext
{
    public PhucNv46Context()
    {
    }

    public PhucNv46Context(DbContextOptions<PhucNv46Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Sach> Saches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ADMIN-PC;Database=PhucNV46;Trusted_Connection=True;TrustServerCertificate=True\n");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742D1A062311");

            entity.ToTable("Sach");

            entity.Property(e => e.MaSach)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TenSach)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
