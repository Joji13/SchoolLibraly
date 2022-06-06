using SchoolLibraly.DAL.Entityes.Base;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace SchoolLibraly.DAL.Entityes

{ 
    public class User : Entity
    {
        [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Buyer Buyer { get; set; } 

        public override string ToString() => $"Покупатель {Buyer} {Login} {Password}";
    }
}

