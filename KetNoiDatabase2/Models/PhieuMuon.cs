using System;
using System.Collections.Generic;

namespace KetNoiDatabase2.Models;

public partial class PhieuMuon
{
    public int MaPhieu { get; set; }

    public int? MaNhanVien { get; set; }

    public int? MaDocGia { get; set; }

    public DateOnly? NgayMuon { get; set; }

    public DateOnly? NgayHetHan { get; set; }

    public string? TrangThaiTra { get; set; }

    public DateOnly? NgayTra { get; set; }

    public string? GhiChu { get; set; }

    public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = new List<ChiTietPhieuMuon>();

    public virtual DocGium? MaDocGiaNavigation { get; set; }

    public virtual TaiKhoan? MaNhanVienNavigation { get; set; }
}
