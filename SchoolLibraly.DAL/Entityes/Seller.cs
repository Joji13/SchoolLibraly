using SchoolLibraly.DAL.Entityes.Base;

namespace SchoolLibraly.DAL.Entityes
{
    public class Seller : Person
    {
        public override string ToString() => $"Продавец {Surname} {Name} {Patronymic}";
    }
}