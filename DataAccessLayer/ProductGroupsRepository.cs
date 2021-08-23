using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Models;
using System.Linq;
using SharedConfig.Config;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DataAccessLayer
{
    public class ProductGroupsRepository : GenericRepository<ProductGroup>, IProductGroupsRepository
    {
        private readonly DBContext _context;
        public ProductGroupsRepository(DBContext context, AppConfig config) : base(context, config)
        {
            _context = context;
        }
        
        public Task<ProductGroup> UpdateRangeSort(List<ProductGroup> productGroups)
        {
            throw new NotImplementedException();
        }
    }
}
