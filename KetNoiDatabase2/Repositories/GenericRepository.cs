using KetNoiDatabase2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetNoiDatabase2.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        private readonly QuanLyThuVienContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository()
        {
            _context = new QuanLyThuVienContext();
            _dbSet = _context.Set<T>();
        }


        public List<T> GetAll()
        {
            // Code vào đây :)
            return _dbSet.ToList();
        }


        public void Add(T model)
        {
            // Code vào đây :)
            _dbSet.Add(model);
            _context.SaveChanges();
        }

        public void Update(T model)
        {
            // Code vào đây :)
            _dbSet.Update(model);
            _context.SaveChanges();
        }

        public void Delete(T model)
        {
            // Code vào đây :)
            _dbSet.Remove(model);
            _context.SaveChanges();
        }

        public List<T> GetAllWithRelationship(params string[] relationships)
        {
            IQueryable<T> query = _dbSet.AsQueryable();
            foreach (var relationship in relationships)
            {
                query= query.Include(relationship);
            }
            return query.ToList();
        }

    }
}
