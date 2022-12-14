using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL.Interfaces
{
    public interface IBaseRepository<T>
    {
        Task Create(T entity);
        Task<T> Get(int id);

        IQueryable<T> GetAll();

        Task Delete(T entity);
        Task Delete(int id);
    }
}
