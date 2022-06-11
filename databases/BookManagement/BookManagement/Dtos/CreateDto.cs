using System.Collections.Generic;

namespace BookManagement.Dtos
{
    public class CreateDto
    {
        public BookDto Book { get; set; }
        public List<AuthorDto> Authors { get; set; }
    }
}
