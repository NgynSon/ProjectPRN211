using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.DAOs
{
    public class CategoryDAO
    {
        private CafeShopDbContext _context;

        public CategoryDAO()
        {
            _context = new CafeShopDbContext();
        }

        public List<int> GetCategoryId()
        {
            List<int> categoryIds = _context.Categories
                .Select(category => category.CateId)
                .ToList();

            return categoryIds;
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }
        public bool IsCateNameUnique(string CategoryName)
        {
            // Assuming _context is your database context and you have a Pets DbSet
            return !_context.Categories.Any(p => p.CateName == CategoryName);
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

        public bool Update(Category cate)
        {
            try
            {
                // cập nhập
                _context.Categories.Update(cate);
                //lưu db 
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(Category cate)
        {
            try
            {
                // Đánh dấu member để xóa
                _context.Categories.Remove(cate);
                // Lưu thay đổi vào database
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
