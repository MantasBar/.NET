using System.Collections.Generic;

namespace BookManagement.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<AuthorDto> Author { get; set; }
        public int AuthorId { get; set; }
    }
}