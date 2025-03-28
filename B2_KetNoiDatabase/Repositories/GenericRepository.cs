//using B2_KetNoiDatabase.Models;
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


        public void Them(T model) // Thêm model vào danh sách
        {
            // Code vào đây 

            try
            {
                _dbSet.Add(model);
                _context.SaveChanges(); // Luu thay doi doi voi database
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi");
            }

        }


        public void Update(T model) // Thêm model vào danh sách
        {
            // Code vào đây 

            try
            {
                _dbSet.Update(model);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Lỗi"); // Hiện lên lỗi
            }

        }

        public void Delete(params object[] key) // TH key hỗn hợp
        {
            //params cho phép truyền không xác đinh số lượng tham số cùng loại
            //Tìm ra bản ghi cần xoá
            // Find(key)
            T deletedObject = _dbSet.Find(key);
            if (deletedObject == null)
            {
                MessageBox.Show("Không tìm thấy đối tượng cần xoá");
                return;
            }

            _dbSet.Remove(deletedObject);
            _context.SaveChanges();

        }

        /* public List<T> TimKiem(string search)
        {
           
        }
*/
    }
}
