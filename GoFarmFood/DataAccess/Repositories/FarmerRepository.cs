using GoFarmFood.Core.Interfaces;
using GoFarmFood.DataAccess.Context;
using GoFarmFood.Web.DataAccess.Entities;
using GoFarmFood.Web.DataAccess.Entities.FarmerAggregate;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace GoFarmFood.DataAccess.Repositories
{
    public class FarmerRepository :  IFarmerRepository
    {
        protected readonly AppDbContext _dbContext;

        public FarmerRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual async Task<Farmer> GetByIdAsync(int id)
        {
            return await _dbContext.Farmers.FindAsync(id);
        }

        public virtual async Task<List<Farmer>> GetByNameAsync(string name)
        {
            return await (_dbContext.Farmers.Where(f => f.FirstName.Equals(name)).ToListAsync());
        }

        public async Task<List<Farmer>> ListAllAsync()
        {
            return await _dbContext.Farmers.ToListAsync();
        }

        public async Task<Farmer> AddAsync(Farmer entity)
        {
            _dbContext.Farmers.Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(Farmer entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Farmer entity)
        {
            _dbContext.Set<Farmer>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}