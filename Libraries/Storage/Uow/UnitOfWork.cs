using Microsoft.Extensions.Logging;
using Storage.Configuration;
using Storage.Repositories.Companies;
using System;
using System.Threading.Tasks;

namespace Storage.Uow
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly CimanDBContext _context;
        private readonly ILogger _logger;

        public ICompanyRepository Companies { get; private set; }
        public UnitOfWork(CimanDBContext context, ILoggerFactory logger)
        {
            _context = context;
            _logger = logger.CreateLogger("logs");

            Companies = new CompanyRepository(_context, _logger);
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
