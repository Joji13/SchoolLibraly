using SchoolLibraly.DAL.Entityes;
using SchoolLibraly.Interfaces;
using MathCore.WPF.ViewModels;

namespace SchoolLibraly.ViewModels
{
    class BuyersViewModel : ViewModel
    {
        private readonly IRepository<Buyer> _Buyers;

        public BuyersViewModel(IRepository<Buyer> Buyers)
        {
            _Buyers = Buyers;
        }
    }
}
