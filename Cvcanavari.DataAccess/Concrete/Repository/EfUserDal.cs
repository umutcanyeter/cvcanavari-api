using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cvcanavari.DataAccess.Abstract;
using Cvcanavari.DataAccess.Concrete.Context;
using Cvcanavari.Entities.Concrete;

namespace Cvcanavari.DataAccess.Concrete.Repository
{
    public class EfUserDal : EfGenericRepository<User>, IUserDal
    {
        public async Task<List<OperationClaim>> GetClaims(User user)
        {
            await using (var context = new CvcanavariDbContext())
            {
                var result = from operationClaim in context.OperationClaims
                    join userOperationClaim in context.UserOperationClaims
                        on operationClaim.Id equals userOperationClaim.OperationClaimId
                    where userOperationClaim.UserId == user.Id
                    select new OperationClaim() {Id = operationClaim.Id, Name = operationClaim.Name};
                return result.ToList();
            }
        }
    }
}