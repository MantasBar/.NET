using BookManagementRazor.Data;
using BookManagementRazor.Dtos;
using BookManagementRazor.Models;
using System.Collections.Generic;
using System.Linq;

namespace BookManagementRazor.Services
{
    public class BookService
    {
        private DataContext _dataContext;

        public BookService(DataContext dataContext)
        {
            _dataContext = dataContext; 
        }

        // load entity and remap to dto
        public List<BookDto> GetAll()
        {
            var entities = _dataContext.Books.ToList();
            return entities.Select(x => new BookDto
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
        }


        public void Add(BookDto bookDto)
        {
            Book entity = new Book
            {
                Name = bookDto.Name,
                AuthorId = bookDto.AuthorId,
            };
            _dataContext.Books.Add(entity);
            _dataContext.SaveChanges();
        }

        public void Remove(int id)
        {
            Book book = _dataContext.Books.FirstOrDefault(x => x.Id == id);
            _dataContext.Books.Remove(book);
            _dataContext.SaveChanges();
        }
    }
}
