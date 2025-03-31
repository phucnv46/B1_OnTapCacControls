using System;
using System.Collections.Generic;

namespace B4_LinQ.Models;

public partial class TraiCay
{
    public string TenTraiCay { get; set; } = null!;

    public string MaTraiCay { get; set; } = null!;

    public string? MaNhaCungCap { get; set; }

    public decimal? SoLuongNhap { get; set; }

    public decimal GiaNhap { get; set; }

    public decimal SoLuongBan { get; set; }

    public decimal GiaBan { get; set; }

    public DateOnly NgayNhap { get; set; }

    public decimal? SoLuongHuHong { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual NhaCungCap? MaNhaCungCapNavigation { get; set; }
}
