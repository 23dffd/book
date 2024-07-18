using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Authors
{
    // 定义用于创建作者的DTO类
    public class CreateAuthorDto
    {
        // 作者名称，必填且长度限制在AuthorConsts.MaxNameLength内
        [Required]
        [StringLength(AuthorConsts.MaxNameLength)]
        public string Name { get; set; }

        // 作者出生日期，必填
        [Required]
        public DateTime BirthDate { get; set; }

        // 作者的简短传记，可选
        public string ShortBio { get; set; }
    }
}
