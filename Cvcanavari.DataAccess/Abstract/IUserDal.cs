using System.Collections.Generic;
using System.Threading.Tasks;
using Cvcanavari.Entities.Concrete;

namespace Cvcanavari.DataAccess.Abstract
{
    public interface IUserDal : IGenericDal<User>
    {
        Task<List<OperationClaim>> GetClaims(User user);
    }
}