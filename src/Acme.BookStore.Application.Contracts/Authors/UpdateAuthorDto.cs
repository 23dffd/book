using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Authors
{
    // 定义用于更新作者信息的DTO类
    public class UpdateAuthorDto
    {
        // 定义作者名称属性，必填且长度限制在AuthorConsts.MaxNameLength内
        [Required]
        [StringLength(AuthorConsts.MaxNameLength)]
        public string Name { get; set; }

        // 定义作者出生日期属性，必填
        [Required]
        public DateTime BirthDate { get; set; }

        // 定义作者简短传记属性，可选
        public string ShortBio { get; set; }
    }
}
