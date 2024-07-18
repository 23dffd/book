using System;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Web.Pages.Books
{
    // 编辑模态框的视图模型类
    public class EditModalModel : BookStorePageModel
    {
        // 隐藏输入属性，用于绑定GET请求中的ID
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        // 绑定属性，用于创建或更新书籍的数据传输对象
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }

        // 书籍应用服务的私有字段
        private readonly IBookAppService _bookAppService;

        // 构造函数，注入书籍应用服务
        public EditModalModel(IBookAppService bookAppService)
        {
            _bookAppService = bookAppService;
        }

        // 处理GET请求的异步方法
        public async Task OnGetAsync()
        {
            var bookDto = await _bookAppService.GetAsync(Id);
            Book = ObjectMapper.Map<BookDto, CreateUpdateBookDto>(bookDto);
        }

        // 处理POST请求的异步方法，返回操作结果
        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.UpdateAsync(Id, Book);
            return NoContent();
        }
    }
}
