using SchoolLibraly.DAL.Entityes.Base;

namespace SchoolLibraly.DAL.Entityes
{
    public class Buyer : Person
       
    {
        public override string ToString() => $"Покупатель {Surname} {Name} {Patronymic}";
    }
}