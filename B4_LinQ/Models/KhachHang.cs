using System;
using System.Collections.Generic;

namespace B4_LinQ.Models;

public partial class KhachHang
{
    public string MaKhachHang { get; set; } = null!;

    public string? TenKhachHang { get; set; }

    public string DiaChi { get; set; } = null!;

    public string? SoDienThoai { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
