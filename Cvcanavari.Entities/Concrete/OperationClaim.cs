using Cvcanavari.Entities.Abstract;

namespace Cvcanavari.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        /* Roles
         * -Company
         * -Employee
         * -Admin
         */
        
    }
}