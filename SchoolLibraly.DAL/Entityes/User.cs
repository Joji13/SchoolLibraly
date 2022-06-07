using SchoolLibraly.DAL.Entityes.Base;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace SchoolLibraly.DAL.Entityes

{ 
    public class User : Entity
    {
        public ICollection<Buyer> Buyers { get; set; } = new HashSet<Buyer>();
        [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public override string ToString() => $"Покупатель {Login} {Password}";
    }
}

