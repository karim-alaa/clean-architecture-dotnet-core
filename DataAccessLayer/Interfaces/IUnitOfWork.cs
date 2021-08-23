using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IUnitOfWork
    {
        IProductGroupsRepository ProductGroupsRepository { get; }
        IUsersRepository UsersRepository { get; }

        Task<int> SaveChangesAsync();
    }
}
