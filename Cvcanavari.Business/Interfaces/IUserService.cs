using System.Collections.Generic;
using System.Threading.Tasks;
using Cvcanavari.Entities.Concrete;

namespace Cvcanavari.Business.Interfaces
{
    public interface IUserService : IGenericService<User>
    {
        Task<List<OperationClaim>> GetClaims(User user);
    }
}