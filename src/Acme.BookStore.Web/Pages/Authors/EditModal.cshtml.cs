using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Acme.BookStore.Authors;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Acme.BookStore.Web.Pages.Authors
{
    public class EditModalModel : BookStorePageModel
    {
        // 绑定属性，用于存储编辑的作者信息
        [BindProperty]
        public EditAuthorViewModel Author { get; set; }
    
        // 依赖注入的作者应用服务
        private readonly IAuthorAppService _authorAppService;
    
        // 构造函数，注入作者应用服务
        public EditModalModel(IAuthorAppService authorAppService)
        {
            _authorAppService = authorAppService;
        }
    
        // 处理GET请求，获取指定ID的作者信息并映射到视图模型
        public async Task OnGetAsync(Guid id)
        {
            var authorDto = await _authorAppService.GetAsync(id);
            Author = ObjectMapper.Map<AuthorDto, EditAuthorViewModel>(authorDto);
        }
    
        // 处理POST请求，更新作者信息并返回无内容响应
        public async Task<IActionResult> OnPostAsync()
        {
            await _authorAppService.UpdateAsync(
                Author.Id,
                ObjectMapper.Map<EditAuthorViewModel, UpdateAuthorDto>(Author)
            );
    
            return NoContent();
        }
    
        // 编辑作者视图模型
        public class EditAuthorViewModel
        {
            // 隐藏输入，用于存储作者ID
            [HiddenInput]
            public Guid Id { get; set; }
    
            // 必填项，作者名称，最大长度由AuthorConsts.MaxNameLength定义
            [Required]
            [StringLength(AuthorConsts.MaxNameLength)]
            public string Name { get; set; }
    
            // 必填项，作者出生日期，日期类型
            [Required]
            [DataType(DataType.Date)]
            public DateTime BirthDate { get; set; }
    
            // 文本区域，用于存储作者的简短传记
            [TextArea]
            public string ShortBio { get; set; }
        }
    }
}
