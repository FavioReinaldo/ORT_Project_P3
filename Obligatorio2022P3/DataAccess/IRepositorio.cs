using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IRepositorio<T>
    {
        IEnumerable Get();
<<<<<<< Updated upstream
        T GetById(int id);
        void Insert(T obj);
        void Delete(int id);
        void Update(T obj);
        void Save();
=======
        void Insert(T obj);
>>>>>>> Stashed changes
    }
}
