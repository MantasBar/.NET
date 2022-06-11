using System.Collections.Generic;

namespace BookManagementRazor.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<AuthorDto> Authors { get; set; }
        public int AuthorId { get; set; }
    }
}