using Entities.Companies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Storage.Configuration;
using Storage.Configuration.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Storage.Repositories.Companies
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(CimanDBContext context, ILogger logger) : base(context, logger)
        {

        }
    }
}
