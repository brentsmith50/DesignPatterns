using RepositoryAndUnitOfWork.Entities;

namespace RepositoryAndUnitOfWork.Custom
{
    public interface IUnitOfWork
    {
        IRepository<Employee> Employees { get; }
        IRepository<TimeCard> TimeCards { get; }
        void Commit();
    }
}
