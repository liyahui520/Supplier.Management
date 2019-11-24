using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Dependency;
using Supplier.Management.Test.Dto;

namespace Supplier.Management.Test
{
    /// <summary>
    /// 测试接口
    /// </summary>
    public interface ITempAppService
    {
        /// <summary>
        /// 新增接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Create(CreateTestDto input);

        /// <summary>
        /// 删除接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(int id);

        /// <summary>
        /// 修改接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<test> Update(CreateTestDto input);

        /// <summary>
        /// 查询接口
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<List<test>> GetAll();
    }
}
