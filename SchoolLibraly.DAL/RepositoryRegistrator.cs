using SchoolLibraly.DAL.Entityes;
using SchoolLibraly.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolLibraly.DAL
{
    public static class RepositoryRegistrator
    {
        public static IServiceCollection AddRepositoriesInDB(this IServiceCollection services) => services
           .AddTransient<IRepository<Book>, BooksRepository>()
           .AddTransient<IRepository<Category>, DbRepository<Category>>()
           .AddTransient<IRepository<Seller>, DbRepository<Seller>>()
            .AddTransient<IRepository<Cart>, DbRepository<Cart>>()           
           .AddTransient<IRepository<Buyer>, DbRepository<Buyer>>()
           .AddTransient<IRepository<Deal>, DealsRepository>()
           .AddTransient<IRepository<User>, DbRepository<User>>()
        ;
    }
}
