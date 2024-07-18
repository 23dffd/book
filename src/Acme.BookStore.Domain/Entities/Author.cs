//using System;
//using Volo.Abp.Domain.Entities.Auditing;

//namespace Acme.BookStore.Domain.Entities
//{
//    // 表示一个作者实体，继承自FullAuditedEntity，具有审计功能
//    public class Author : FullAuditedEntity<Guid>
//    {
//        // 作者的姓名
//        public string Name { get; set; }
//        // 作者的出生日期
//        public DateTime BirthDate { get; set; }
//        // 作者的传记
//        public string Biography { get; set; }

//        // 默认构造函数
//        public Author()
//        {
//            // 默认构造函数
//        }

//        // 带参数的构造函数，用于初始化作者实体
//        public Author(Guid id, string name, DateTime birthDate, string biography)
//            : base(id)
//        {
//            Name = name;
//            BirthDate = birthDate;
//            Biography = biography;
//        }
//    }
//}
