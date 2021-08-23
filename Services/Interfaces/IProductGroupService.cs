using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IProductGroupService
    {
        Task<ProductGroup> Create(VmProductGroupCreate vmProductGroupCreate);
        Task<ProductGroup> GetById(Guid Id);
        Task<List<ProductGroup>> GetAll();
        Task Update(VmProductGroupUpdate vmProductGroupUpdate);
        Task UpdateRangeSort(List<VmProductGroupUpdate> vmProductGroupsUpate);
        Task<bool> Delete(Guid Id);
    }
}
