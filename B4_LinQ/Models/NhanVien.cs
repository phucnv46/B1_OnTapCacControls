using System;
using System.Collections.Generic;

namespace B4_LinQ.Models;

public partial class NhanVien
{
    public string MaNhanVien { get; set; } = null!;

    public string TenNhanVien { get; set; } = null!;

    public bool GioiTinh { get; set; }

    public string DiaChi { get; set; } = null!;

    public string? SoDienThoai { get; set; }

    public DateOnly NgaySinh { get; set; }

    public string Email { get; set; } = null!;

    public decimal? Luong { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
