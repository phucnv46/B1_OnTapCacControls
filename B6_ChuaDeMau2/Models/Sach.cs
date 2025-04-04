using System;
using System.Collections.Generic;

namespace B6_ChuaDeMau2.Models;

public partial class Sach
{
    public string MaSach { get; set; } = null!;

    public string? TenSach { get; set; }

    public float? DonGia { get; set; }

    public int? SoTrang { get; set; }
}
