using B6_ChuaDeMau2.DataContext;
using B6_ChuaDeMau2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6_ChuaDeMau2.Repository
{
    public class SachRepository // Làm việc để lấy dữ liệu từ database
    {
        //Khởi tạo các phụ thuộc (dependencies)
        PhucNv46Context _dBContext; //Đại diện cho database
        DbSet<Sach> _saches; // Đại diện cho bảng của database

        public SachRepository()
        {
            _dBContext = new PhucNv46Context();
            _saches = _dBContext.Saches;
        }


        public List<Sach> LayDSSach()
        {
            // Code vào đây :)
            return _saches.ToList();
        }

        public void ThemSach(Sach sach)
        {
            _saches.Add(sach); // Thay đổi cấu trúc database
            _dBContext.SaveChanges(); // lưu thay đổi của database
        }


    }
}
