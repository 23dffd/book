using Volo.Abp;

namespace Acme.BookStore.Authors
{
    // 表示作者已存在的异常类
    public class AuthorAlreadyExistsException : BusinessException
    {
        // 构造函数，接收作者名称并调用基类构造函数
        public AuthorAlreadyExistsException(string name)
            : base(BookStoreDomainErrorCodes.AuthorAlreadyExists)
        {
            // 将作者名称添加到异常数据中
            WithData("name", name);
        }
    }
}
