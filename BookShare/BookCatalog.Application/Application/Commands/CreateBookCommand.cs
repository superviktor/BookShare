using BookCatalog.Application.Application.Base;
using BookCatalog.Application.Application.Model;
using System.Collections.Generic;

namespace BookCatalog.Application.Application.Commands
{
    public class CreateBookCommand : ICommand
    {
        public string Name { get; set; }
        public string Annotation { get; set; }
        public List<AuthorDto> Authors { get; set; } = new List<AuthorDto>();
        public List<string> CategoryNames { get; set; } = new List<string>();
    }
}
