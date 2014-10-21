using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Linq.Expressions;

namespace EATurner.Data.Repository
{
    /// <summary>
    /// Generic Repository for EF 6
    /// </summary>
    /// <typeparam name="TEntity">The Entity</typeparam>
    public class GenericRepository<TEntity> where TEntity : class
    {
        readonly DbContext _context;
        readonly DbSet<TEntity> _dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public GenericRepository(DbContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        /// <summary>
        /// Firsts the specified filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns></returns>
        public virtual TEntity First(
            Expression<Func<TEntity, bool>> filter = null, 
            string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (filter != null) return query.First(filter);

            return query.First();
        }

        /// <summary>
        /// Firsts the or default.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns></returns>
        public virtual TEntity FirstOrDefault(
            Expression<Func<TEntity, bool>> filter = null, 
            string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (filter != null) return query.FirstOrDefault(filter);

            return query.FirstOrDefault();
        }

        /// <summary>
        /// Checks Any records exists or not
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        public virtual bool Any(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null) return query.Any(filter);

            return query.Any();
        }

        /// <summary>
        /// Gets Entity with specified specified filter.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns></returns>
        public virtual IQueryable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
                return orderBy(query);

            return query;
        }

        /// <summary>
        /// Gets the entity with filter
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="orderBy">The order by.</param>
        /// <param name="includeProperties">The include properties.</param>
        /// <returns></returns>
        public virtual IQueryable<TEntity> Where(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
                return orderBy(query);

            return query;
        }

        /// <summary>
        /// Gets the query.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        public virtual IQueryable<TEntity> GetQuery(Expression<Func<TEntity, bool>> filter = null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (filter != null)
                query = query.Where(filter);

            return query;
        }

        /// <summary>
        /// Gets the Entity by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// Inserts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        /// <summary>
        /// Deletes the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public virtual void DeleteById(object id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        /// <summary>
        /// Deletes the specified entity to delete.
        /// </summary>
        /// <param name="entityToDelete">The entity to delete.</param>
        public virtual void Delete(TEntity entityToDelete)
        {
            if (_context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// Updates the specified entity to update.
        /// </summary>
        /// <param name="entityToUpdate">The entity to update.</param>
        public virtual void Update(TEntity entityToUpdate)
        {
            _dbSet.Attach(entityToUpdate);
            _context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}