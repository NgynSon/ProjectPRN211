using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.DAOs
{
    public class CafeDAO
    {
        private CafeShopDbContext _context;
        public CafeDAO()
        {
            _context = new CafeShopDbContext();
        }
        public List<Cafe> GetAllCafes()
        {
            return _context.Cafes.ToList();
        }

        public List<Cafe> GetCafesBySearch(string Value)
        {
            return _context.Cafes.Where((search) => search.CafeName.Contains(Value)).ToList();
        }
        public bool IsCafeNameUnique(string CafeName)
        {
            // Assuming _context is your database context and you have a Cafes DbSet
            return !_context.Cafes.Any(p => p.CafeName == CafeName);
        }
        public bool Add(Cafe cafe)
        {
            try
            {
                _context.Cafes.Add(cafe);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update(Cafe cafe)
        {
            try
            {
                // cập nhập
                _context.Cafes.Update(cafe);
                //lưu db 
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(Cafe cafe)
        {
            try
            {
                // Đánh dấu member để xóa
                _context.Cafes.Remove(cafe);
                // Lưu thay đổi vào database
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int GetTotalNumberOfCafes()
        {
            return _context.Cafes.Sum(q => q.Quantity).Value;
        }

    }
}
