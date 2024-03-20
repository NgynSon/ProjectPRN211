using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.DAOs
{
    public class MemberDAO
    {
        private CafeShopDbContext _context;
        public MemberDAO()
        {
            _context = new CafeShopDbContext();
        }
        public Member Login(string email, string password)
        {
            Member mem = _context.Members.FirstOrDefault(x => x.Email == email && x.Password == password);

            return mem;
        }
        public List<Member> GetAllMembers()
        {
            return _context.Members.ToList();
        }
        public List<Member> GetMembersBySearch(string Value)
        {
            return _context.Members.Where((search) => search.MemberName.Contains(Value)).ToList();
        }
        public bool IsMemberNameUnique(string member)
        {
            // Assuming _context is your database context and you have a Pets DbSet
            return !_context.Members.Any(p => p.MemberName == member);
        }

        public bool Add(Member member)
        {
            try
            {
                _context.Members.Add(member);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public bool Update(Member member)
        {
            try
            {
                // cập nhập
                _context.Members.Update(member);
                //lưu db 
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Remove(Member member)
        {
            try
            {
                // Đánh dấu member để xóa
                _context.Members.Remove(member);
                // Lưu thay đổi vào database
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public int GetTotalNumberOfMembers()
        {
            return _context.Members.Count();
        }
        public Member GetMemberById(int memberId)
        {
            using (var context = new CafeShopDbContext()) // Replace YourDbContext with your actual DbContext
            {
                return context.Members.FirstOrDefault(m => m.MemberId == memberId);
            }
        }
    }
    
}
