using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task<bool> Create(T entity);
        Task<T> Get(int id);

        List<T> GetAll();

        bool Delete(T entity);
        bool Delete(int id);
    }
}
