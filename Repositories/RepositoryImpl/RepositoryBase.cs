﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Repositories.Common.Interface;
using Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.RepositoryImpl
{
    public class RepositoryBase<TDomain, TPersistence, TDbContext> : IEFRepository<TDomain, TPersistence>
       where TDbContext : DbContext, IUnitOfWork
       where TPersistence : class, TDomain
       where TDomain : class
    {
        private readonly TDbContext _dbContext;
        private readonly IMapper _mapper;
        public RepositoryBase(TDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _mapper = mapper;
        }

        public IUnitOfWork UnitOfWork => _dbContext;

        protected virtual DbSet<TPersistence> GetSet()
        {
            return _dbContext.Set<TPersistence>();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public virtual void Add(TDomain entity)
        {
            GetSet().Add((TPersistence)entity);
        }

        public virtual void Remove(TDomain entity)
        {
            GetSet().Remove((TPersistence)entity);
        }

        public virtual void Update(TDomain entity)
        {
            GetSet().Update((TPersistence)entity);
        }

        protected virtual IQueryable<TPersistence> CreateQuery()
        {
            return GetSet();
        }

        public virtual async Task<bool> AnyAsync(Expression<Func<TPersistence, bool>> filterExpression
            , CancellationToken cancellationToken = default)
        {
            return await QueryInternal(filterExpression).AnyAsync(cancellationToken);
        }

        public virtual async Task<int> CountAsync(Expression<Func<TPersistence, bool>> filterExpression
            , CancellationToken cancellationToken = default)
        {
            return await QueryInternal(filterExpression).CountAsync(cancellationToken);
        }

        public virtual async Task<List<TDomain>> FindAllAsync(CancellationToken cancellationToken = default)
        {
            return await QueryInternal(x => true).ToListAsync<TDomain>(cancellationToken);
        }

        public virtual async Task<TDomain?> FindAsync(Expression<Func<TPersistence, bool>> filterExpression
            , CancellationToken cancellationToken = default)
        {
            return await QueryInternal(filterExpression).SingleOrDefaultAsync<TDomain>(cancellationToken);
        }

        protected virtual IQueryable<TPersistence> QueryInternal(Expression<Func<TPersistence, bool>>? filterExpression)
        {
            var queryable = CreateQuery();
            if (filterExpression != null)
            {
                queryable = queryable.Where(filterExpression);
            }
            return queryable;
        }
    }
}
