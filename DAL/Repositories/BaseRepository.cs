﻿using L2.DAL.Interfaces;

namespace L2.DAL.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly AppDbContext _appDbContext;

        public BaseRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity is null");
            }
            await _appDbContext.AddAsync(entity);
            await _appDbContext.SaveChangesAsync();

            return entity;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _appDbContext.Set<TEntity>();
        }

        public async Task<TEntity> RemoveAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity is null");
            }
             _appDbContext.Remove(entity);
            await _appDbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity is null");
            }
             _appDbContext.Update(entity);
            await _appDbContext.SaveChangesAsync();

            return entity;
        }
    }
}
