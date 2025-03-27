using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace B2_KetNoiDatabase.Models;

public partial class NhanVien
{
    [DisplayName("Mã nhân viên")]
    public string MaNhanVien { get; set; } = null!;

    public string? HoTen { get; set; }

    public bool? GioiTinh { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? Cccd { get; set; }

    public DateTime? NgayVaoLamViec { get; set; }

    public int? HeSoLuong { get; set; }

    public string? MaVaiTro { get; set; }

    public string? MaPhongBan { get; set; }

    [Browsable(false)]
    public virtual VaiTro? MaVaiTroNavigation { get; set; }
}
