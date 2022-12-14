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
    public class PlaceRepository : IBaseRepository<Place>
    {
        private readonly ApplicationDbContext _db;

        public PlaceRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task Create(Place entity)
        
        {
            await _db.Places.AddAsync(entity);
            await _db.SaveChangesAsync();
           
        }

        public async Task Delete(Place entity)
        {
            _db.Remove(entity);
            await _db.SaveChangesAsync();
           
        }

        public async Task Delete(int id)
        {
            var place = _db.Places.FirstOrDefault(x => x.id == id);
            _db.Remove(place);
            await _db.SaveChangesAsync();
      
        }

        public async Task<Place> Get(int id)
        {
            return await _db.Places.FirstOrDefaultAsync(x => x.id == id);
        }

        public IQueryable<Place> GetAll()
        {
            return  _db.Places;
        }

        public async Task<Place> GetByPlace(int carNum)
        {
            return await _db.Places.FirstOrDefaultAsync(x => x.price == carNum);
        }
        public async Task<Place> Update(Place entity)
        {
            _db.Places.Update(entity);
            await _db.SaveChangesAsync();

            return entity;
        }

    }
}
