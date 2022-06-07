using System;
using System.Collections.Generic;
using SchoolLibraly.DAL.Entityes.Base;

namespace SchoolLibraly.DAL.Entityes
{
    public class BookUrl : NamedEntity
    {
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();

        public override string ToString() => $"Ссылка {Name}";

        public static implicit operator BookUrl(Random v)
        {
            throw new NotImplementedException();
        }
    }
}