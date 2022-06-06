using System.ComponentModel.DataAnnotations;

namespace SchoolLibraly.DAL.Entityes.Base
{
    public abstract class NamedEntity : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}