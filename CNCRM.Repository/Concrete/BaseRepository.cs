﻿using CNCRM.Entity.Abstract;
using CNCRM.Entity.Context;
using CNCRM.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CNCRM.Repository.Concrete
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IBaseEntity
    {
        protected readonly CNCRMContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;
        public BaseRepository(CNCRMContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public void Complete()
        {
            _dbContext.SaveChanges();
        }


        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        public void DeleteAndComplete(TEntity entity)
        {
            Delete(entity);
            Complete();
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public TEntity GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void InsertAndComplete(TEntity entity)
        {
            Insert(entity);
            Complete();
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public void UpdateAndComplete(TEntity entity)
        {
            Update(entity);
            Complete();
        }
    }
}
