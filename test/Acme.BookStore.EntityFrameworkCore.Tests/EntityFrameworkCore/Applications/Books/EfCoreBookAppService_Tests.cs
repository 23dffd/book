using Acme.BookStore.Books;
using Xunit;

namespace Acme.BookStore.EntityFrameworkCore.Applications.Books;

// 定义一个测试类，用于测试基于Entity Framework Core的BookAppService
[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<BookStoreEntityFrameworkCoreTestModule>
{

}