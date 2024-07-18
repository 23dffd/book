using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Authors
{
    // 表示作者数据的传输对象
    public class AuthorDto : EntityDto<Guid>
    {
        // 作者的姓名
        public string Name { get; set; }

        // 作者的出生日期
        public DateTime BirthDate { get; set; }

        // 作者的简短传记
        public string ShortBio { get; set; }
    }
}
