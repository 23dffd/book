using System;
using System.Collections.Generic;
using System.Text;
using Acme.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace Acme.BookStore;

/* Inherit your application services from this class.
 */
// 定义一个抽象类 BookStoreAppService，继承自 ApplicationService
public abstract class BookStoreAppService : ApplicationService
{
    // 构造函数，设置本地化资源为 BookStoreResource
    protected BookStoreAppService()
    {
        LocalizationResource = typeof(BookStoreResource);
    }
}
