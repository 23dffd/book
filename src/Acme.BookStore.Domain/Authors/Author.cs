using System;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Authors
{
    public class Author : FullAuditedAggregateRoot<Guid>
    {
        // 作者的姓名，私有设置器用于内部修改
        public string Name { get; private set; }
        // 作者的出生日期
        public DateTime BirthDate { get; set; }
        // 作者的简短传记
        public string ShortBio { get; set; }
    
        // 私有构造函数，用于反序列化或ORM目的
        private Author()
        {
            /* This constructor is for deserialization / ORM purpose */
        }
    
        // 内部构造函数，用于创建Author对象
        internal Author(
            Guid id,
            [NotNull] string name,
            DateTime birthDate,
            [CanBeNull] string shortBio = null)
            : base(id)
        {
            SetName(name);
            BirthDate = birthDate;
            ShortBio = shortBio;
        }
    
        // 内部方法，用于更改作者的姓名
        internal Author ChangeName([NotNull] string name)
        {
            SetName(name);
            return this;
        }
    
        // 私有方法，用于设置作者的姓名并进行验证
        private void SetName([NotNull] string name)
        {
            Name = Check.NotNullOrWhiteSpace(
                name,
                nameof(name),
                maxLength: AuthorConsts.MaxNameLength
            );
        }
    }
}
