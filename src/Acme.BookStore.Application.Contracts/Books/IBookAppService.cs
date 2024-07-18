using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public interface IBookAppService :
        ICrudAppService< //定义CRUD方法
            BookDto, //用于显示书籍
            Guid, //书籍实体的主键
            PagedAndSortedResultRequestDto, //用于分页和排序
            CreateUpdateBookDto> //用于创建或更新书籍
    {
      
    }
}
