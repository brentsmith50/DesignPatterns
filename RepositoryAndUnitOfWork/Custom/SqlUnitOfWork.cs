using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryAndUnitOfWork.Entities;
using System.Data.Objects;
using System.Configuration;

namespace RepositoryAndUnitOfWork.Custom
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        private readonly ObjectContext context;
        private SqlRepository<Employee> employees = null;
        private SqlRepository<TimeCard> timeCards = null;
        private const string ConnectionStringName = "EmployeeDataModelContainer";

        public SqlUnitOfWork()
        {
            var connectionString = ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
            this.context = new ObjectContext(connectionString);
            this.context.ContextOptions.LazyLoadingEnabled = true;
        }

        public IRepository<Employee> Employees
        {
            get
            {
                if (this.employees == null)
                {
                    this.employees = new SqlRepository<Employee>(this.context);
                }
                return this.employees;
            }
        }

        public IRepository<TimeCard> TimeCards
        {
            get
            {
                if (this.timeCards == null)
                {
                    this.timeCards = new SqlRepository<TimeCard>(this.context);
                }
                return this.timeCards;
            }
        }

        public void Commit()
        {
            this.context.SaveChanges(); 
        }
    }
}
