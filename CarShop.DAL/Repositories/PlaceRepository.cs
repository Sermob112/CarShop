using CarShop.DAL.Interfaces;
using CarShop.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.DAL.Repositories
{
    public class PlaceRepository : ICarRepository
    {
        private readonly ApplicationDbContext _db;

        public PlaceRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public Task<bool> Create(Place entity)
        
        {
           _db.Places.AddAsync(entity);
            _db.SaveChangesAsync();
            return Task.FromResult(true);
        }

        public bool Delete(Place entity)
        {
            _db.Remove(entity);
            _db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var place = _db.Places.FirstOrDefault(x => x.id == id);
            _db.Remove(place);
            _db.SaveChanges();
            return true;
        }

        public async Task<Place> Get(int id)
        {
            return await _db.Places.FirstOrDefaultAsync(x => x.id == id);
        }

        public List<Place> GetAll()
        {
            return  _db.Places.ToList();
        }

        public async Task<Place> GetByCarNum(int carNum)
        {
            return await _db.Places.FirstOrDefaultAsync(x => x.price == carNum);
        }

     
    }
}
