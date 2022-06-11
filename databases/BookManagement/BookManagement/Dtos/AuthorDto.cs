using System.Collections.Generic;

namespace BookManagement.Dtos
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<BookDto> Books { get; set; }
    }
}
