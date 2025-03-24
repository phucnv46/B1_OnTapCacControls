using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1_OnTapCacControls.Models
{
    internal class SinhVien
    {
        public string MaSinhVien { get; set; } // Dạng Pascal

        public string TenSinhVien { get; set; }

        [DisplayName("Ngày sinh")] // Sử dụng Atribute DisplayName để thay đổi hiển thị tên cột
        public DateTime NgaySinh { get; set; }

        [DisplayName("Môn học")]
        public string MonHoc { get; set; }

        [DisplayName("Giới tính")]
        public string GioiTinh { get; set; } // True là Nam, False là nữ

        //Intelisense
        [DisplayName("Điểm")]
        public double Diem { get; set; }
    }
}
