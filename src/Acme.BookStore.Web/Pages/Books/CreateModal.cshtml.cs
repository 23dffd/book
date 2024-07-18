using System.Threading.Tasks;
using Acme.BookStore.Books;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Web.Pages.Books
{
    public class CreateModalModel(IBookAppService bookAppService) : BookStorePageModel
    {
        // 绑定属性，用于接收用户输入的书籍信息
        [BindProperty]
        public CreateUpdateBookDto Book { get; set; }
    
        // 依赖注入的书籍应用服务
        private readonly IBookAppService _bookAppService = bookAppService;
    
        // 处理GET请求，初始化书籍信息
        public void OnGet()
        {
            Book = new CreateUpdateBookDto();
        }
    
        // 处理POST请求，异步创建书籍
        public async Task<IActionResult> OnPostAsync()
        {
            await _bookAppService.CreateAsync(Book);
            return NoContent();
        }
    }
}
