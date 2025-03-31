using System;
using System.Collections.Generic;

namespace B4_LinQ.Models;

public partial class NhaCungCap
{
    public string MaNhaCungCap { get; set; } = null!;

    public string TenNhaCungCap { get; set; } = null!;

    public string DiaChi { get; set; } = null!;

    public string? SoDienThoai { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<TraiCay> TraiCays { get; set; } = new List<TraiCay>();
}
