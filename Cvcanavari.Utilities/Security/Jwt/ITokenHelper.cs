using System.Collections.Generic;
using Cvcanavari.Entities.Concrete;

namespace Cvcanavari.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}