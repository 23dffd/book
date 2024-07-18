using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{
  
    // 表示一本书的实体类，继承自AuditedAggregateRoot，使用Guid作为主键
    public class Book : AuditedAggregateRoot<Guid>
    {
        // 书的名称
        public string? Name { get; set; }

        // 书的类型
        public BookType Type { get; set; }

        // 书的出版日期
        public DateTime PublishDate { get; set; }

        // 书的价格
        public float Price { get; set; }
    }
}
