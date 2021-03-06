using System.ComponentModel.DataAnnotations.Schema;
using SchoolLibraly.DAL.Entityes.Base;

namespace SchoolLibraly.DAL.Entityes
{
    public class Deal : Entity
    {
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public Book Book { get; set; }

        public Seller Seller { get; set; }

        public User User { get; set; }

        public override string ToString() => $"Сделка по продаже {Book}: {Seller}, {User}, {Price:C}";
    }
}