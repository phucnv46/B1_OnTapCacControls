using System;
using System.Collections.Generic;

namespace B4_LinQ.Models;

public partial class HoaDon
{
    public string MaHoaDon { get; set; } = null!;

    public string MaNhanVien { get; set; } = null!;

    public string MaKhachHang { get; set; } = null!;

    public string TenTraiCay { get; set; } = null!;

    public string MaTraiCay { get; set; } = null!;

    public decimal SoLuong { get; set; }

    public decimal GiaBanLe { get; set; }

    public decimal? ChietKhau { get; set; }

    public virtual KhachHang MaKhachHangNavigation { get; set; } = null!;

    public virtual NhanVien MaNhanVienNavigation { get; set; } = null!;

    public virtual TraiCay MaTraiCayNavigation { get; set; } = null!;
}
