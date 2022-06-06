using SchoolLibraly.Interfaces;

namespace SchoolLibraly.DAL.Entityes.Base
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
