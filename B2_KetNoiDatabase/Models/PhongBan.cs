using System;
using System.Collections.Generic;

namespace B2_KetNoiDatabase.Models;

public partial class PhongBan
{
    public string MaPhongBan { get; set; } = null!;

    public string? TenPhongBan { get; set; }

    public string? TruongPhong { get; set; }
}
