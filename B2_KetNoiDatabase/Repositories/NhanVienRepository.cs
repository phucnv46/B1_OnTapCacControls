using B2_KetNoiDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2_KetNoiDatabase.Repositories
{
    public class NhanVienRepository
    {
        private readonly TutorNet1021Context _context;
        private readonly DbSet<NhanVien> _dbSet;

        public NhanVienRepository()
        {
            _context = new TutorNet1021Context(); // đại diện cho database
            _dbSet = _context.NhanViens; // Lấy bản nhân viên ở database
        }

        public List<NhanVien> LayListNhanVien()
        {
            return _dbSet.ToList();
        }


    }
}
