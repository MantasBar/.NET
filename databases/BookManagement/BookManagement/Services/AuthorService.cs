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
    public class AuthorService
    {
        private DataContext _dataContext;

        public AuthorService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<AuthorDto> GetAll()
        {
            var entities = _dataContext.Authors.ToList();
            return entities.Select(x => new AuthorDto
            {
                Id = x.Id,
                FullName = $"{x.FirstName} {x.LastName}",
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
