using RepositoryAndUnitOfWork.Custom;
using System;
using System.Collections.Generic;

namespace RepositoryAndUnitOfWork.Entities
{
    public class Employee : IEntity
    {
        public virtual int Id { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
        public ICollection<TimeCard> TimeCards { get; set; }
    }
}
