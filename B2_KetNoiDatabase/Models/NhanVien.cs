using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace B2_KetNoiDatabase.Models;

public partial class NhanVien
{
    public string MaNhanVien { get; set; } = null!;

    public string? HoTen { get; set; }

    [Browsable(false)] // ẩn cột
    public bool? GioiTinh { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? Cccd { get; set; }

    public DateTime? NgayVaoLamViec { get; set; }

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
}
