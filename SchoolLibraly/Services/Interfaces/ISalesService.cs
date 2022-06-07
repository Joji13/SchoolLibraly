using System.Collections.Generic;
using System.Threading.Tasks;
using SchoolLibraly.DAL.Entityes;

namespace SchoolLibraly.Services.Interfaces
{
    interface ISalesService
    {
        IEnumerable<Deal> Deals { get; }

        Task<Deal> MakeADeal(string BookName, Seller Seller, User User, decimal Price);
    }
}
