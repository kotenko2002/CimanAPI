using Storage.Repositories.Companies;
using System.Threading.Tasks;

namespace Storage.Uow
{
    public interface IUnitOfWork
    {
        ICompanyRepository Companies { get; }

        Task CompleteAsync();
    }
}
