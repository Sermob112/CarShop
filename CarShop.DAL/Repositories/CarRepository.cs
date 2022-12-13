using CarShop.DAL.Interfaces;
using CarShop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL.Repositories
{
    public class CarRepository : IBaseRepository<Car>

    {
        private readonly ApplicationDbContext _db;
        public bool Create(Car entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Car> GetAll()
        {
           /* return _db.Cars;*/
            throw new NotImplementedException();
        }
    }
}
