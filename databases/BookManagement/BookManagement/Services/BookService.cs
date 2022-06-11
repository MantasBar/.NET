using BookManagement.Data;
using BookManagement.Dtos;
using BookManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Services
{
    public class BookService
    {
        private DataContext _dataContext;

        public BookService(DataContext dataContext)
        {
            _dataContext = dataContext; 
        }

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

        public void Remove(string name)
        {
            Book book = _dataContext.Books.FirstOrDefault(x => x.Name == name);
            _dataContext.Books.Remove(book);
            _dataContext.SaveChanges();
        }
    }
}
