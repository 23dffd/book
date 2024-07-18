using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Acme.BookStore.Authors;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Acme.BookStore.Web.Pages.Authors
{
    public class CreateModalModel : BookStorePageModel
    {
        // 绑定属性，用于接收表单数据
        [BindProperty]
        public CreateAuthorViewModel Author { get; set; }
    
        // 作者应用服务接口实例
        private readonly IAuthorAppService _authorAppService;
    
        // 构造函数，注入作者应用服务
        public CreateModalModel(IAuthorAppService authorAppService)
        {
            _authorAppService = authorAppService;
        }
    
        // 处理GET请求，初始化作者视图模型
        public void OnGet()
        {
            Author = new CreateAuthorViewModel();
        }
    
        // 处理POST请求，创建作者并返回结果
        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateAuthorViewModel, CreateAuthorDto>(Author);
            await _authorAppService.CreateAsync(dto);
            return NoContent();
        }
    
        // 作者视图模型类
        public class CreateAuthorViewModel
        {
            // 作者名称，必填且长度限制
            [Required]
            [StringLength(AuthorConsts.MaxNameLength)]
            public string Name { get; set; }
    
            // 出生日期，必填且日期类型
            [Required]
            [DataType(DataType.Date)]
            public DateTime BirthDate { get; set; }
    
            // 简短传记，文本区域
            [TextArea]
            public string ShortBio { get; set; }
        }
    }
}
