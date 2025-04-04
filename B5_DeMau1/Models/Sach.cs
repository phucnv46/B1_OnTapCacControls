using System;
using System.Collections.Generic;

namespace B5_DeMau1.Models;

public partial class Sach
{
    public string MaSach { get; set; } = null!;

    public string? TenSach { get; set; }

    public float? DonGia { get; set; }

    public int? SoTrang { get; set; }
}
