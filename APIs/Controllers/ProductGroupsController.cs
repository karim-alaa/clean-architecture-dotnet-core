using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Models.ViewModels;
using GlobalHelpers.Helpers;
using SharedConfig.Messages;
using APIs.Utilities;

namespace APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductGroupsController : AppController
    {
        private readonly IMapper _mapper;
        private readonly IProductGroupService _productService;

        public ProductGroupsController(IMapper Mapper,IProductGroupService ProductService)
        {
            _mapper = Mapper;
            _productService = ProductService;
        }

        // sample response
        [HttpGet]
        [Route("GetAll")]
        [Authorize]
        public async Task<GResponse<List<VmProductGroup>>> GetAll()
        {
            return await ExceptionHandler(async () =>
            {
                List<ProductGroup> productGroups = await _productService.GetAll();
                List<VmProductGroup> vmProductGroups = _mapper.Map<List<VmProductGroup>>(productGroups);
                return Ok(vmProductGroups);
            });
        }

        [HttpGet]
        [Route("GetById/{Id}")]
        [Authorize]
        public async Task<GResponse<VmProductGroup>> GetById(Guid Id)
        {
            return await ExceptionHandler(async () =>
            {
                ProductGroup productGroup = await _productService.GetById(Id);
                VmProductGroup vmProductGroup = _mapper.Map<VmProductGroup>(productGroup);
                return Ok(vmProductGroup);
            });
        }

        [HttpPost]
        [Route("Create")]
        [Authorize]
        public async Task<GResponse<VmProductGroup>> Create([FromBody] VmProductGroupCreate vmProductGroupCreate)
        {
            return await ExceptionHandler(async () =>
            {
                ProductGroup createdProductGroup = await _productService.Create(vmProductGroupCreate);
                VmProductGroup vmProductGroup = _mapper.Map<VmProductGroup>(createdProductGroup);
                return Ok(vmProductGroup);
            });
        }


        [HttpPut]
        [Route("Update")]
        [Authorize]
        public async Task<GResponse<VmProductGroup>> Update([FromBody] VmProductGroupUpdate vmProductGroupUpdate)
        {
            return await ExceptionHandler(async () =>
            {
                await _productService.Update(vmProductGroupUpdate);
                return Ok(new VmProductGroup());
            });
        }

        [HttpPut]
        [Route("UpdateRangeSort")]
        [Authorize]
        public async Task<GResponse<VmProductGroup>> UpdateRangeSort([FromBody] List<VmProductGroupUpdate> vmProductGroupsUpdate)
        {
            return await ExceptionHandler(async () =>
            {
                await _productService.UpdateRangeSort(vmProductGroupsUpdate);
                return Ok(new VmProductGroup());
            });
        }

    }
}
