using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace B2_KetNoiDatabase.Models;

public partial class NhanVien
{
    [DisplayName("Mã nhân viên")]
    public string MaNhanVien { get; set; } = null!;

    [DisplayName("Họ tên")]

    public string? HoTen { get; set; }

    [Browsable(false)] // ẩn cột
    public bool? GioiTinh { get; set; }

    [DisplayName("Ngày sinh")]

    public DateTime? NgaySinh { get; set; }

    public string? Cccd { get; set; }

    public DateTime? NgayVaoLamViec { get; set; }

    [DisplayName("Hệ số lương")]

    public int? HeSoLuong { get; set; }

    public string? MaVaiTro { get; set; }

    public string? MaPhongBan { get; set; }
    [Browsable(false)] // ẩn cột
    public virtual PhongBan? MaPhongBanNavigation { get; set; }
    [Browsable(false)] // ẩn cột
    public virtual VaiTro? MaVaiTroNavigation { get; set; }

    [DisplayName("Giới tính")] // Hiển thị tiêu đề của cột 
    public string GioiTinhDisplay
    {
        get
        {
            return GioiTinh == true ? "Nam" : "Nữ";
        }
    }

    [DisplayName("Vai trò")]
    public string TenVaiTro {
        get 
        {
            return MaVaiTroNavigation?.TenVaiTro ?? "Không xác định";
        }
    }

    [DisplayName("Phòng ban")]
    public string TenPhongBan
    {
        get
        {
            return MaPhongBanNavigation?.TenPhongBan ?? "Không xác định";
        }
    }
}
