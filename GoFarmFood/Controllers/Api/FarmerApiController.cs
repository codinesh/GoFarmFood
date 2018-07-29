using GoFarmFood.Core.Interfaces;
using GoFarmFood.Web.DataAccess.Entities.FarmerAggregate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace GoFarmFood.Web.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FarmerApiController : ControllerBase
    {
        private readonly IFarmerRepository farmerRepository;
        private readonly IAsyncRepository<Farmer> farmerAsyncRepository;

        public FarmerApiController(IFarmerRepository farmerRepository, IAsyncRepository<Farmer> farmerAsyncRepository)
        {
            this.farmerRepository = farmerRepository;
            this.farmerAsyncRepository = farmerAsyncRepository;
        }

        [HttpGet]
        public async Task<IActionResult> List(string name)
        {
            var catalogModel = await farmerRepository.GetByNameAsync(name);
            return Ok(catalogModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var catalogModel = await farmerRepository.GetByIdAsync(id);
            return Ok(catalogModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(string fitsName, string lastName, int zipCode)
        {
            var catalogModel = await farmerRepository.AddAsync(new Farmer
            {
                Id = Guid.NewGuid(),
                FirstName = fitsName,
                LastName = lastName,
                Address = new DataAccess.Entities.Common.Address { Id = Guid.NewGuid(), ZipCode = zipCode },
                LastModifiedOn = DateTime.UtcNow,
                LastModifiedBy = Guid.NewGuid(),            
            });

            return Ok();
        }
    }
}
