using Cvcanavari.Business.Interfaces;
using Cvcanavari.DataAccess.Abstract;
using Cvcanavari.Entities.Concrete;

namespace Cvcanavari.Business.Concrete
{
    public class UserOperationClaimManager : GenericManager<UserOperationClaim>, IUserOperationClaimService
    {
        private readonly IUserOperationClaimDal _operationClaimDal;

        public UserOperationClaimManager(IGenericDal<UserOperationClaim> genericDal, IUserOperationClaimDal operationClaimDal) : base(genericDal)
        {
            _operationClaimDal = operationClaimDal;
        }
    }
}