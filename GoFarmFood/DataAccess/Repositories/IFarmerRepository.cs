using GoFarmFood.Web.DataAccess.Entities.FarmerAggregate;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GoFarmFood.Core.Interfaces
{
    public interface IFarmerRepository
    {
        Task<Farmer> GetByIdAsync(int id);
        Task<List<Farmer>> GetByNameAsync(string name);
        Task<List<Farmer>> ListAllAsync();
        Task<Farmer> AddAsync(Farmer entity);
        Task UpdateAsync(Farmer entity);
        Task DeleteAsync(Farmer entity);
    }
}
