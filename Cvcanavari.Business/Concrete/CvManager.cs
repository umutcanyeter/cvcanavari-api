using Cvcanavari.Business.Interfaces;
using Cvcanavari.DataAccess.Abstract;
using Cvcanavari.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cvcanavari.Business.Concrete
{
    public class CvManager : GenericManager<Cv>, ICvService
    {
        private readonly ICvDal _cvDal;

        public CvManager(IGenericDal<Cv> genericDal, ICvDal cvDal) : base(genericDal)
        {
            _cvDal = cvDal;
        }
    }
}
