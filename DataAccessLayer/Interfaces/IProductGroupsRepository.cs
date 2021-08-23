using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IProductGroupsRepository : IGenericRepository<ProductGroup>
    {
        Task<ProductGroup> UpdateRangeSort(List<ProductGroup> productGroups);
    }
}
