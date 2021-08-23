using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Interfaces;
namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        public DBContext DBContext { get; }
        public IProductGroupsRepository ProductGroupsRepository { get; }
        public IUsersRepository UsersRepository { get; }
        public UnitOfWork(DBContext POSDBContext, IProductGroupsRepository ProductGroupsRepository, IUsersRepository UsersRepository)
        {
            DBContext = POSDBContext;
            this.ProductGroupsRepository = ProductGroupsRepository;
            this.UsersRepository = UsersRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
            return await DBContext.SaveChangesAsync();
        }
    }
}
