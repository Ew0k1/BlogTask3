using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Abstract
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> FindAll();
        T Find(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
