using System.Linq;
using SchoolLibraly.DAL.Context;
using SchoolLibraly.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace SchoolLibraly.DAL
{
    class DealsRepository : DbRepository<Deal>
    {
        public override IQueryable<Deal> Items => base.Items
           .Include(item => item.Book)
           .Include(item => item.Seller)
           .Include(item => item.Buyer)
        ;

        public DealsRepository(SchoolLibralyBD db) : base(db) { }
    }
}