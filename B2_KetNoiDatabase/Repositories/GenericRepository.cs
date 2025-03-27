using B2_KetNoiDatabase.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2_KetNoiDatabase.Repositories
{
    public class GenericRepository<T> where T : class
    {
        private readonly TutorNet1021Context _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository()
        {
            _context = new TutorNet1021Context();
            _dbSet = _context.Set<T>();
        }

        public List<T> LayList()
        {
            return _dbSet.ToList();
        }
    }
}
