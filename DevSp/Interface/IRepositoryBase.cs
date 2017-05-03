using System;
using System.Collections.Generic;

namespace DevSp.Domain.Interface
{
    public interface IRepositoryBase<T> : IDisposable
    {
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        T GetById(int id);
        List<T> GetAll();        
    }
}
