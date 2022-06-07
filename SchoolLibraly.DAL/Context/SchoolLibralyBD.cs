using SchoolLibraly.DAL.Entityes;
using Microsoft.EntityFrameworkCore;

namespace SchoolLibraly.DAL.Context
{
    public class SchoolLibralyBD : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<BookUrl> BookUrls { get; set; }

        public DbSet<Category> Categorys { get; set; }

        public DbSet<Buyer> Buyers { get; set; }

        public DbSet<Seller> Sellers { get; set; }

        public DbSet<Deal> Deals { get; set; }

        

        public SchoolLibralyBD(DbContextOptions<SchoolLibralyBD> options) : base(options)
        {
            
        }
    }
}
