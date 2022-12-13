using CarShop.DAL.Interfaces;
using CarShop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL.Repositories
{
   /* public class CarRepository : ICarRepository

    {
        private readonly ApplicationDbContext _db;
        public bool Create(Car entity)
        {
            throw new NotImplementedException();
        }

        public bool Create(Place entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Place entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Car> GetAll()
        {
            return _db.Cars;
           *//* throw new NotImplementedException();*//*
        }

        public Place GetByCarNum(string carNum)
        {
            throw new NotImplementedException();
        }

        public Task<Place> GetByCarNum(int carNum)
        {
            throw new NotImplementedException();
        }

        Task<bool> IBaseRepository<Place>.Create(Place entity)
        {
            throw new NotImplementedException();
        }

        Task<Place> IBaseRepository<Place>.Get(int id)
        {
            throw new NotImplementedException();
        }

        List<Place> IBaseRepository<Place>.GetAll()
        {
            throw new NotImplementedException();
        }
    }*/
}
