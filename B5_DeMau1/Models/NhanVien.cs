using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace B5_DeMau1.Models;

public partial class NhanVien
{
    public string MaNhanVien { get; set; } = null!;

    [DisplayName("Tên nhân viên")]
    public string? YenNhanVien { get; set; }

    [DisplayName("Giới tính")]
    public string? GioiTinh { get; set; }
    [DisplayName("Chức vụ")]

    public string? ChucVu { get; set; }
}
