using Entities.Companies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Storage.Uow;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CimanAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;
        private readonly IUnitOfWork _uow;

        public CompanyController(ILogger<CompanyController> logger, IUnitOfWork uow)
        {
            _logger = logger;
            _uow = uow;
        }
        [HttpPost]
        public async Task<IActionResult> CreateCompany(Company company)
        {
            _uow.Companies.Add(company);
            await _uow.CompleteAsync();

            return Ok(company);
        }

        [HttpGet("items")]
        public async Task<IEnumerable<Company>> GetAllComponies()
        {
            return await _uow.Companies.FindAllAsync();
        }
    }
}
