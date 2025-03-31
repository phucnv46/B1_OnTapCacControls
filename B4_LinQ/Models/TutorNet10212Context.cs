using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace B4_LinQ.Models;

public partial class TutorNet10212Context : DbContext
{
    public TutorNet10212Context()
    {
    }

    public TutorNet10212Context(DbContextOptions<TutorNet10212Context> options)
        : base(options)
    {
    }

    public virtual DbSet<HoaDon> HoaDons { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<TraiCay> TraiCays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ADMIN-PC;Database=Tutor_NET1021_2;Trusted_Connection=True;TrustServerCertificate=True")
        .LogTo(Console.WriteLine,LogLevel.Information);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHoaDon).HasName("PK__HoaDon__835ED13B6CC5B7B6");

            entity.ToTable("HoaDon");

            entity.Property(e => e.MaHoaDon).HasMaxLength(30);
            entity.Property(e => e.ChietKhau).HasColumnType("money");
            entity.Property(e => e.GiaBanLe).HasColumnType("money");
            entity.Property(e => e.MaKhachHang)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaTraiCay)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.SoLuong).HasColumnType("money");
            entity.Property(e => e.TenTraiCay).HasMaxLength(50);

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaKhachHang)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__MaKhachH__412EB0B6");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaNhanVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__MaNhanVi__403A8C7D");

            entity.HasOne(d => d.MaTraiCayNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaTraiCay)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__HoaDon__MaTraiCa__4222D4EF");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhachHang).HasName("PK__KhachHan__88D2F0E5F62A5A16");

            entity.ToTable("KhachHang");

            entity.Property(e => e.MaKhachHang)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi).HasMaxLength(40);
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenKhachHang).HasMaxLength(50);
        });

        modelBuilder.Entity<NhaCungCap>(entity =>
        {
            entity.HasKey(e => e.MaNhaCungCap).HasName("PK__NhaCungC__53DA9205276A1550");

            entity.ToTable("NhaCungCap");

            entity.Property(e => e.MaNhaCungCap).HasMaxLength(50);
            entity.Property(e => e.DiaChi).HasMaxLength(40);
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenNhaCungCap).HasMaxLength(50);
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__NhanVien__77B2CA473B1F1151");

            entity.ToTable("NhanVien");

            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DiaChi).HasMaxLength(40);
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Luong).HasColumnType("money");
            entity.Property(e => e.SoDienThoai).HasMaxLength(50);
            entity.Property(e => e.TenNhanVien).HasMaxLength(70);
        });

        modelBuilder.Entity<TraiCay>(entity =>
        {
            entity.HasKey(e => e.MaTraiCay).HasName("PK__TraiCay__EF21C347E2E5BD45");

            entity.ToTable("TraiCay");

            entity.Property(e => e.MaTraiCay)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.GiaBan).HasColumnType("money");
            entity.Property(e => e.GiaNhap).HasColumnType("money");
            entity.Property(e => e.MaNhaCungCap).HasMaxLength(50);
            entity.Property(e => e.SoLuongBan).HasColumnType("money");
            entity.Property(e => e.SoLuongHuHong).HasColumnType("money");
            entity.Property(e => e.SoLuongNhap).HasColumnType("money");
            entity.Property(e => e.TenTraiCay).HasMaxLength(50);

            entity.HasOne(d => d.MaNhaCungCapNavigation).WithMany(p => p.TraiCays)
                .HasForeignKey(d => d.MaNhaCungCap)
                .HasConstraintName("FK__TraiCay__MaNhaCu__398D8EEE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
