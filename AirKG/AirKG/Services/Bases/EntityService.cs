using AirKG.Context;
using AirKG.Extension;
using AirKG.Interface;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirKG.Services.Bases
{
    public abstract class EntityService<TEntity> : ContextHasService
    where TEntity : class, IEntity<int>
    {
        private readonly IMapper _mapper;

        protected EntityService(AirKGDbContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }

        public virtual async Task<TEntity> Add<T>(T model)
        {
            var entity = _mapper.Map<T, TEntity>(model);
            await Context.Set<TEntity>().AddAsync(entity);
            await SaveChanges();

            return entity;
        }

        public async Task<List<T>> GetAsync<T>(Func<TEntity, bool> predicate = null)
        {
            var items = Context.Set<TEntity>().AsQueryable();
            if (predicate != null)
            {
                items = items.Where(predicate).AsQueryable();
            }
            return _mapper.Map<List<T>>(await items.ToListAsync());
        }

        public virtual async Task<T> ById<T>(int id) where T : class, IEntity<int>
        {
            return _mapper.Map<T>(await Context.Set<TEntity>().FindAsync(id));
        }

        public virtual async Task Edit<T>(T model) where T : IEntity<int>
        {
            if (Context.Set<TEntity>().Any(x => x.Id == model.Id))
            {
                Context.Set<TEntity>().Update(_mapper.Map<TEntity>(model));
            }

            await SaveChanges();
        }

        public virtual async Task Delete(int id)
        {
            Context.Set<TEntity>().Remove(await Context.Set<TEntity>().ById(id));
            await SaveChanges();
        }
    }
}
