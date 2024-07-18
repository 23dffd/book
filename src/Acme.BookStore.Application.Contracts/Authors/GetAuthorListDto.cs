using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Authors
{
    // 定义一个用于获取作者列表的DTO类
    public class GetAuthorListDto : PagedAndSortedResultRequestDto
    {
        // 过滤条件，可选
        public string? Filter { get; set; }
    }
}
