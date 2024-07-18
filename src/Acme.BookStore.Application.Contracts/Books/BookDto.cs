using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    // 表示书籍的数据传输对象（DTO），继承自AuditedEntityDto<Guid>
    public class BookDto : AuditedEntityDto<Guid>
    {
        // 书籍的名称
        public string? Name { get; set; }

        // 书籍的类型
        public BookType Type { get; set; }

        // 书籍的出版日期
        public DateTime PublishDate { get; set; }

        // 书籍的价格
        public float Price { get; set; }
    }
}
