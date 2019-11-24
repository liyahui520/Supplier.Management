using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using AutoMapper;
using Supplier.Management.Authorization.Roles;
using Supplier.Management.Test.Dto;

namespace Supplier.Management.Test
{
    /// <summary>
    /// 接口实现层
    /// </summary>
   public class TempAppService: ManagementAppServiceBase, ITempAppService
    {
        private readonly IRepository<test,long> _testRepository;
        public TempAppService(IRepository<test,long> testRepository) 
        {
            _testRepository = testRepository; 
        }

        /// <summary>
        /// 异步新增处理
        /// </summary>
        /// <param name="input">实体类</param>
        /// <returns></returns>
        public async Task Create(CreateTestDto input)
        {
            test entity=new test();
            entity.note = input.note;
            await _testRepository.InsertAsync(entity);
        }

        public async Task Delete(int id)
        {
             await _testRepository.DeleteAsync(id);
        }

        public async Task<List<test>> GetAll()
        {
            return await _testRepository.GetAllListAsync();
        }

        public async Task<test> Update(CreateTestDto input)
        {
            test entity=new test();
            entity.note = input.note;
            return await _testRepository.UpdateAsync(entity);
        }
    }
}
