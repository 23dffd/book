using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using AutoMapper;

namespace Acme.BookStore.Web;

public class BookStoreWebAutoMapperProfile : Profile
{
    public BookStoreWebAutoMapperProfile()
    {
        // 创建从 BookDto 到 CreateUpdateBookDto 的映射
        CreateMap<BookDto, CreateUpdateBookDto>();

        // 创建从 Pages.Authors.CreateModalModel.CreateAuthorViewModel 到 CreateAuthorDto 的映射
        CreateMap<Pages.Authors.CreateModalModel.CreateAuthorViewModel,CreateAuthorDto>();

        // 创建从 AuthorDto 到 Pages.Authors.EditModalModel.EditAuthorViewModel 的映射
        CreateMap<AuthorDto, Pages.Authors.EditModalModel.EditAuthorViewModel>();

        // 创建从 Pages.Authors.EditModalModel.EditAuthorViewModel 到 UpdateAuthorDto 的映射
        CreateMap<Pages.Authors.EditModalModel.EditAuthorViewModel,
                  UpdateAuthorDto>();
        //Define your AutoMapper configuration here for the Web project.
    }
}
