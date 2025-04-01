using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KetNoiDatabase2.Models;

public partial class QuanLyThuVienContext : DbContext
{
    public QuanLyThuVienContext()
    {
    }

    public QuanLyThuVienContext(DbContextOptions<QuanLyThuVienContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; }

    public virtual DbSet<DocGium> DocGia { get; set; }

    public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

    public virtual DbSet<TheLoai> TheLoais { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ADMIN-PC;Database=QuanLyThuVien;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietPhieuMuon>(entity =>
        {
            entity.HasKey(e => new { e.MaPhieu, e.MaSach }).HasName("PK__ChiTietP__ED43E8A2B24D455E");

            entity.ToTable("ChiTietPhieuMuon");

            entity.HasOne(d => d.MaPhieuNavigation).WithMany(p => p.ChiTietPhieuMuons)
                .HasForeignKey(d => d.MaPhieu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietPh__MaPhi__4316F928");

            entity.HasOne(d => d.MaSachNavigation).WithMany(p => p.ChiTietPhieuMuons)
                .HasForeignKey(d => d.MaSach)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietPh__MaSac__440B1D61");
        });

        modelBuilder.Entity<DocGium>(entity =>
        {
            entity.HasKey(e => e.MaDocGia).HasName("PK__DocGia__F165F9453FBE8796");

            entity.Property(e => e.MaDocGia).ValueGeneratedNever();
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
            entity.Property(e => e.TenDocGia).HasMaxLength(255);
        });

        modelBuilder.Entity<PhieuMuon>(entity =>
        {
            entity.HasKey(e => e.MaPhieu).HasName("PK__PhieuMuo__2660BFE0FD495811");

            entity.ToTable("PhieuMuon");

            entity.Property(e => e.MaPhieu).ValueGeneratedNever();
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.TrangThaiTra).HasMaxLength(50);

            entity.HasOne(d => d.MaDocGiaNavigation).WithMany(p => p.PhieuMuons)
                .HasForeignKey(d => d.MaDocGia)
                .HasConstraintName("FK__PhieuMuon__MaDoc__403A8C7D");

            entity.HasOne(d => d.MaNhanVienNavigation).WithMany(p => p.PhieuMuons)
                .HasForeignKey(d => d.MaNhanVien)
                .HasConstraintName("FK__PhieuMuon__MaNha__3F466844");
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.MaSach).HasName("PK__Sach__B235742D440360E0");

            entity.ToTable("Sach");

            entity.Property(e => e.MaSach).ValueGeneratedNever();
            entity.Property(e => e.Nxb)
                .HasMaxLength(255)
                .HasColumnName("NXB");
            entity.Property(e => e.TacGia).HasMaxLength(255);
            entity.Property(e => e.TenSach).HasMaxLength(255);

            entity.HasOne(d => d.MaTheLoaiNavigation).WithMany(p => p.Saches)
                .HasForeignKey(d => d.MaTheLoai)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Sach_TheLoai");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__TaiKhoan__77B2CA47578F3D66");

            entity.ToTable("TaiKhoan");

            entity.Property(e => e.MaNhanVien).ValueGeneratedNever();
            entity.Property(e => e.HoTen).HasMaxLength(255);
            entity.Property(e => e.MatKhau).HasMaxLength(50);
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
            entity.Property(e => e.TaiKhoan1)
                .HasMaxLength(50)
                .HasColumnName("TaiKhoan");
            entity.Property(e => e.VaiTro).HasMaxLength(50);
        });

        modelBuilder.Entity<TheLoai>(entity =>
        {
            entity.HasKey(e => e.MaTheLoai).HasName("PK__TheLoai__D73FF34A0B3B8858");

            entity.ToTable("TheLoai");

            entity.Property(e => e.MaTheLoai).ValueGeneratedNever();
            entity.Property(e => e.TenTheLoai).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
