using AutoMapper;
using BookCatalog.Infrastructure.Entity;
using BookCatalog_Domain.AggregateModel.BookAggregate;

namespace BookCatalog.Application.Application.MapperConfigurations
{
    public class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Status, string>().ConvertUsing(status => status.ToString());
            CreateMap<Book, BookEntity>();
        }
    }
}
