using DevSp.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using DevSp.Domain.Model;
using DevSp.Data.Configuration;
using System.Linq;

namespace DevSp.Data.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataContext _data;
        public AuthorRepository(DataContext data)
        {
            _data = data;
        }
        public void Add(Author obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Author obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAll()
        {
            return _data.Author.ToList();
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Author obj)
        {
            throw new NotImplementedException();
        }
    }
}
