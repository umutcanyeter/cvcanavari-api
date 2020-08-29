using Cvcanavari.Business.Interfaces;
using Cvcanavari.DataAccess.Abstract;
using Cvcanavari.Entities.Concrete;

namespace Cvcanavari.Business.Concrete
{
    public class OperationClaimManager : GenericManager<OperationClaim>, IOperationClaimService
    {
        private readonly IOperationClaimDal _operationClaimDal;

        public OperationClaimManager(IGenericDal<OperationClaim> genericDal, IOperationClaimDal operationClaimDal) : base(genericDal)
        {
            _operationClaimDal = operationClaimDal;
        }
    }
}