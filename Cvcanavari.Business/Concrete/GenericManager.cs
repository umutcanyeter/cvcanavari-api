using Cvcanavari.Business.Interfaces;
using Cvcanavari.DataAccess.Abstract;
using Cvcanavari.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cvcanavari.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity>
        where TEntity : class, IEntity, new()
    {

        private readonly IGenericDal<TEntity> _genericDal;
        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }
        public async Task Add(TEntity entity)
        {
            await _genericDal.Add(entity);
        }

        public async Task Delete(TEntity entity)
        {
            await _genericDal.Delete(entity);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _genericDal.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _genericDal.GetById(id);
        }

        public async Task<List<TEntity>> GetListByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return await _genericDal.GetListByFilter(filter);
        }

        public async Task<TEntity> GetOneByFilter(Expression<Func<TEntity, bool>> filter)
        {
            return await _genericDal.GetOneByFilter(filter);
        }

        public async Task Update(TEntity entity)
        {
            await _genericDal.Update(entity);
        }
    }
}
