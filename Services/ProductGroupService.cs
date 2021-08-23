using DataAccessLayer.Interfaces;
using Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using AutoMapper;
using SharedConfig.Records;
using GlobalHelpers.Interfaces;

namespace Services
{
    public class ProductGroupService : IProductGroupService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGlobalHelperService _globalHelperService;
        private readonly IMapper _mapper;
        public ProductGroupService(IUnitOfWork UnitOfWork, IGlobalHelperService globalHelperService, IMapper mapper)
        {
            _unitOfWork = UnitOfWork;
            _globalHelperService = globalHelperService;
            _mapper = mapper;
        }

        public async Task<ProductGroup> Create(VmProductGroupCreate vmProductGroupCreate)
        {
            LocalUser localUser = _globalHelperService.GetUserData();
            int newSortValue = await _unitOfWork.ProductGroupsRepository.CountAsync() + 1;
            ProductGroup productGroup = new()
            {
                Name = vmProductGroupCreate.Name,
                SortValue = newSortValue,
                MerchantId = localUser.MerchantId
            };

            ProductGroup createdProductGroup = await _unitOfWork.ProductGroupsRepository.AddAsync(productGroup);
            await _unitOfWork.SaveChangesAsync();

            return createdProductGroup;
        }

        public async Task<bool> Delete(Guid Id)
        {
            ProductGroup productGroupToDelete = await _unitOfWork.ProductGroupsRepository.Where(pg => pg.Id == Id).FirstOrDefaultAsync();
            productGroupToDelete.IsActive = false;
            _ = _unitOfWork.ProductGroupsRepository.Update(productGroupToDelete);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }
       
        public async Task<List<ProductGroup>> GetAll()
        {
            return await _unitOfWork.ProductGroupsRepository.GetAllAsync();
        }

        public async Task<ProductGroup> GetById(Guid Id)
        {
            return await _unitOfWork.ProductGroupsRepository.Where(pg => pg.Id == Id).FirstOrDefaultAsync();
        }

        public async Task Update(VmProductGroupUpdate vmProductGroupUpdate)
        {
            ProductGroup productGroup = await _unitOfWork.ProductGroupsRepository.Where(pg => pg.Id == vmProductGroupUpdate.Id).FirstOrDefaultAsync();
            productGroup.Name = vmProductGroupUpdate.Name;

            _unitOfWork.ProductGroupsRepository.Update(productGroup);
            await _unitOfWork.SaveChangesAsync();
        }

        public Task UpdateRangeSort(List<VmProductGroupUpdate> vmProductGroupsUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
