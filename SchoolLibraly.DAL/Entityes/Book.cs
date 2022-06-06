using SchoolLibraly.DAL.Entityes.Base;

namespace SchoolLibraly.DAL.Entityes
{
    public class Book : NamedEntity
    {
        public Category Category { get; set; }

        public string Description { get; set; }

        public override string ToString() => $"Книга {Name}";
    }
}
