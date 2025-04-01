using System;
using System.Collections.Generic;

namespace B4_LinQ.Models;

public partial class Sach
{
    public int MaSach { get; set; }

    public string? TenSach { get; set; }

    public string? TacGia { get; set; }

    public int? MaTheLoai { get; set; }

    public string? Nxb { get; set; }

    public int? NamXuatBan { get; set; }

    public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = new List<ChiTietPhieuMuon>();

    public virtual TheLoai? MaTheLoaiNavigation { get; set; }
}
