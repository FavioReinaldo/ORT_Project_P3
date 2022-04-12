using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IRepositorio<T>
    {
        IEnumerable Get();
        T GetById(int id);
        void Insert(T obj);
        void Delete(int id);
        void Update(T obj);
        void Save();
    }
}
