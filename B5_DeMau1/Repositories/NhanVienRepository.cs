using B5_DeMau1.Context;
using B5_DeMau1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5_DeMau1.Repositories
{
    public class NhanVienRepository
    {
        private readonly TutorNet1021DeMau1Context _context ; // Đại diên database
        private  DbSet<NhanVien> _nhanViens  ; // Đại diện cho bảng

        public NhanVienRepository()
        {
            _context = new();
            _nhanViens = _context.NhanViens;
        }

        public List<NhanVien> GetListNhanViens()
        {
            return _nhanViens.ToList();
        }


        public void Them(NhanVien nhanVien)
        {
            // Code vào đây :)
            _nhanViens.Add(nhanVien); // Làm thay đổi Database
            _context.SaveChanges();

        }

    }
}
