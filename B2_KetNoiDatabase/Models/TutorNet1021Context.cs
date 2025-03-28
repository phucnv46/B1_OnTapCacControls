using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace B2_KetNoiDatabase.Models;

public partial class TutorNet1021Context : DbContext
{
    public TutorNet1021Context()
    {
    }

    public TutorNet1021Context(DbContextOptions<TutorNet1021Context> options)
        : base(options)
    {
    }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<PhongBan> PhongBans { get; set; }

    public virtual DbSet<VaiTro> VaiTros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ADMIN-PC;Database=Tutor_NET1021;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NhanVien__77B2CA4726460624");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNhanVien).HasMaxLength(10);
            entity.Property(e => e.Cccd)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CCCD");
            entity.Property(e => e.HoTen).HasMaxLength(255);
            entity.Property(e => e.MaPhongBan)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MaVaiTro)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NgaySinh).HasColumnType("datetime");
            entity.Property(e => e.NgayVaoLamViec).HasColumnType("datetime");

            entity.HasOne(d => d.MaPhongBanNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaPhongBan)
                .HasConstraintName("FK_NhanVien_PhongBan");

            entity.HasOne(d => d.MaVaiTroNavigation).WithMany(p => p.NhanViens)
                .HasForeignKey(d => d.MaVaiTro)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__NhanVien__MaVaiT__5CD6CB2B");
        });

        modelBuilder.Entity<PhongBan>(entity =>
        {
            entity.HasKey(e => e.MaPhongBan).HasName("PK__PhongBan__D0910CC8B13E7734");

            entity.ToTable("PhongBan");

            entity.Property(e => e.MaPhongBan)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TenPhongBan).HasMaxLength(255);
            entity.Property(e => e.TruongPhong).HasMaxLength(10);
        });

        modelBuilder.Entity<VaiTro>(entity =>
        {
            entity.HasKey(e => e.MaVaiTro).HasName("PK__VaiTro__C24C41CF0D4DEA87");

            entity.ToTable("VaiTro");

            entity.Property(e => e.MaVaiTro)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.TenVaiTro).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
