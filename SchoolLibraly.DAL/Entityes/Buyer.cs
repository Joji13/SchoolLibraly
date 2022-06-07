using SchoolLibraly.DAL.Entityes.Base;

namespace SchoolLibraly.DAL.Entityes
{
    public class Buyer : Person
       
    {
        public User User { get; set; }
        public override string ToString() => $"Покупатель {Surname} {Name} {Patronymic}";
    }
}