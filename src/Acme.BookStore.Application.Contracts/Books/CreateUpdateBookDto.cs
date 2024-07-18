using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Books
{
    // 定义用于创建或更新书籍的DTO类
    public class CreateUpdateBookDto
    {
        // 书籍名称，必填且长度不超过128个字符
        [Required]
        [StringLength(128)]
        public string? Name { get; set; }

        // 书籍类型，必填且默认为未定义类型
        [Required]
        public BookType Type { get; set; } = BookType.Undefined;

        // 出版日期，必填且数据类型为日期
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } = DateTime.Now;

        // 书籍价格，必填
        [Required]
        public float Price { get; set; }
    }
}
