using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KetNoiDatabase2.Models;

public partial class Sach
{
    [DisplayName("Mã sách")]
    public int MaSach { get; set; }

    public string? TenSach { get; set; }

    public string? TacGia { get; set; }

    public int? MaTheLoai { get; set; }

    public string? Nxb { get; set; }

    public int? NamXuatBan { get; set; }

    [Browsable(false)]
    public virtual ICollection<ChiTietPhieuMuon> ChiTietPhieuMuons { get; set; } = new List<ChiTietPhieuMuon>();

    [Browsable(false)]
    public virtual TheLoai? MaTheLoaiNavigation { get; set; }

    public string TenTheLoai { get 
        { return MaTheLoaiNavigation.TenTheLoai ?? "Không xác định"; }
    
    }
}
