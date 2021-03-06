﻿using Cvcanavari.DataAccess.Abstract;
using Cvcanavari.DataAccess.Concrete.Context;
using Cvcanavari.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Cvcanavari.DataAccess.Concrete.Repository
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity>
        where TEntity : class, IEntity, new()
    {
        public async Task Add(TEntity entity)
        {
            using var context = new CvcanavariDbContext();
            context.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            using var context = new CvcanavariDbContext();
            context.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            using var context = new CvcanavariDbContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            using var context = new CvcanavariDbContext();
            return await context.Set<TEntity>().FindAsync(id);
        }

        public async Task<List<TEntity>> GetListByFilter(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new CvcanavariDbContext();
            return await context.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<TEntity> GetOneByFilter(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new CvcanavariDbContext();
            return await context.Set<TEntity>().FirstOrDefaultAsync(filter);
        }

        public async Task Update(TEntity entity)
        {
            using var context = new CvcanavariDbContext();
            context.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
