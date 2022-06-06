using System;
using System.Collections.Generic;
using SchoolLibraly.DAL.Entityes.Base;

namespace SchoolLibraly.DAL.Entityes
{
    public class Category : NamedEntity
    {
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();

        public override string ToString() => $"Категория {Name}";

        public static implicit operator Category(Random v)
        {
            throw new NotImplementedException();
        }
    }
}