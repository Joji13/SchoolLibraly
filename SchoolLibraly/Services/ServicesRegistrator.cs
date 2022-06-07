using SchoolLibraly.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolLibraly.Services
{
    static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
           .AddTransient<ISalesService, SalesService>()
           .AddTransient<IUserDialog, UserDialogService>()
        ;
    }
}