using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewFood.Models.Interface
{
    public interface IManager<T> where T:class
    {
        bool Add(T entity);

        bool Update(T entity);

        bool Remove(long id);

        T GetById(long id);

        ICollection<T> GetAll();
    }
}
