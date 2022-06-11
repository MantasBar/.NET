using BookManagementRazor.Data;
using BookManagementRazor.Dtos;
using BookManagementRazor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookManagementRazor.Services
{
    public class AuthorService
    {
        private DataContext _dataContext;

        public AuthorService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<AuthorDto> GetAll()
        {
            var entities = _dataContext.Authors.Include(s => s.Books).ToList();
            return entities.Select(x => new AuthorDto
            {
                Id = x.Id,
                FullName = x.FullName,
                Books = x.Books.Select(x => new BookDto
                {
                    Name = x.Name,
                }).ToList(),
            }).ToList();
        }

        public void Add(Author author)
        {
            _dataContext.Authors.Add(author);
            _dataContext.SaveChanges();
        }

        public void Remove (int id)
        {
            Author author = _dataContext.Authors.FirstOrDefault(x => x.Id == id);
            _dataContext.Authors.Remove(author);
            _dataContext.SaveChanges();
        }
    }
}
