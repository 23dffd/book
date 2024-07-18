using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Authors
{
    // 定义作者仓库接口，继承自IRepository接口，泛型参数为Author和Guid
    public interface IAuthorRepository : IRepository<Author, Guid>
    {
        // 根据名称异步查找作者
        Task<Author> FindByNameAsync(string name);

        // 异步获取作者列表，支持分页和排序，可选过滤条件
        Task<List<Author>> GetListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
        );
    }
}
