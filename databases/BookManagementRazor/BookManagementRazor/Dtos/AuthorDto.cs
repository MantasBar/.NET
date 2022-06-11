using System.Collections.Generic;

namespace BookManagementRazor.Dtos
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<BookDto> Books { get; set; }
    }
}
