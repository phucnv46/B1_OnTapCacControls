using System;
using System.Collections.Generic;

namespace KetNoiDatabase2.Models;

public partial class TaiKhoan
{
    public int MaNhanVien { get; set; }

    public string? HoTen { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? SoDienThoai { get; set; }

    public string? VaiTro { get; set; }

    public string? TaiKhoan1 { get; set; }

    public string? MatKhau { get; set; }

    public virtual ICollection<PhieuMuon> PhieuMuons { get; set; } = new List<PhieuMuon>();
}
