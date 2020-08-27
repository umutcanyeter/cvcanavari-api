using Cvcanavari.DataAccess.Abstract;
using Cvcanavari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cvcanavari.DataAccess.Concrete.Repository
{
    public class EfCvDal : EfGenericRepository<Cv>, ICvDal
    {
    }
}
