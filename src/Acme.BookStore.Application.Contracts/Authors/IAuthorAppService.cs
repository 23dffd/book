using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Authors
{
    /// <summary>
    /// 定义作者应用服务的接口
    /// </summary>
    public interface IAuthorAppService : IApplicationService
    {
        /// <summary>
        /// 根据ID获取作者信息
        /// </summary>
        Task<AuthorDto> GetAsync(Guid id);

        /// <summary>
        /// 获取作者列表
        /// </summary>
        Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input);

        /// <summary>
        /// 创建新作者
        /// </summary>
        Task<AuthorDto> CreateAsync(CreateAuthorDto input);

        /// <summary>
        /// 更新作者信息
        /// </summary>
        Task UpdateAsync(Guid id, UpdateAuthorDto input);

        /// <summary>
        /// 删除作者
        /// </summary>
        Task DeleteAsync(Guid id);
    }
}
