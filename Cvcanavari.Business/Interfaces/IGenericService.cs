using Cvcanavari.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cvcanavari.Business.Interfaces
{
    public interface IGenericService<TEntity> where TEntity : class, IEntity, new()
    {
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
        Task<List<TEntity>> GetAll();
        Task<List<TEntity>> GetListByFilter(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> GetById(int id);
        Task<TEntity> GetOneByFilter(Expression<Func<TEntity, bool>> filter);
    }
}
