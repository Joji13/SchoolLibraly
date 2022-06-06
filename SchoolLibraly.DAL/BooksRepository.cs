using System.Linq;
using SchoolLibraly.DAL.Context;
using SchoolLibraly.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace SchoolLibraly.DAL
{
    class BooksRepository : DbRepository<Book>
    {
        public override IQueryable<Book> Items => base.Items.Include(item => item.Category);

        public BooksRepository(SchoolLibralyBD db) : base(db) { }
    }
}