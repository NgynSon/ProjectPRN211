using RepositoryLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.DAOs
{
    public class BillDAO
    {
        private CafeShopDbContext _context;

        public BillDAO()
        {
            _context = new CafeShopDbContext();
        }

        public decimal GetTotalRevenue()
        {
            return _context.Bills.Sum(bill => bill.TotalMoney).Value;
        }

    }
}
