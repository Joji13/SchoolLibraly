using System.ComponentModel.DataAnnotations.Schema;
using SchoolLibraly.DAL.Entityes.Base;

namespace SchoolLibraly.DAL.Entityes
{
    public class Cart : Entity
    {
        
        public Deal Deal { get; set; }
        
             
        public override string ToString() => $"Сделка по продаже {Deal} ";
    }
}