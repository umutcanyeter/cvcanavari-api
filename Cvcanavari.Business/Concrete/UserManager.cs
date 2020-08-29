using System.Collections.Generic;
using System.Threading.Tasks;
using Cvcanavari.Business.Interfaces;
using Cvcanavari.DataAccess.Abstract;
using Cvcanavari.Entities.Concrete;

namespace Cvcanavari.Business.Concrete
{
    public class UserManager : GenericManager<User>, IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IGenericDal<User> genericDal, IUserDal userDal) : base(genericDal)
        {
            _userDal = userDal;
        }

        public Task<List<OperationClaim>> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
    }
}