using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SocialNetwork.Core.DataAccess.Interfaces;
using SocialNetwork.Core.Entities.Common;

namespace SocialNetwork.Core.DataAccess.EntityFramework
{
    public class EfRepositoryBase<T, TContext> : IRepositoryBase<T> where T : BaseEntity, IEntity where TContext : DbContext, new()
    {
        public async Task AddAsync(T model)
        {
            using TContext context = new();
            EntityEntry<T> entityEntry = await context.Set<T>().AddAsync(model);
            entityEntry.State = EntityState.Added;
            await context.SaveChangesAsync();
        }

        public async Task AddRangeAsync(List<T> models)
        {
            using TContext context = new();
            await context.Set<T>().AddRangeAsync(models);
            await context.SaveChangesAsync();
        }

        public void Delete(T model)
        {
            using TContext context = new();
            EntityEntry<T> entityEntry = context.Set<T>().Remove(model);
            entityEntry.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public async Task DeleteByIdAsync(string id)
        {
            using TContext context = new();
            T model = await context.Set<T>().FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
            Delete(model);
        }

        public void DeleteRange(List<T> models)
        {
            using TContext context = new();
            context.Set<T>().RemoveRange(models);
            context.SaveChanges();
        }
        public void Update(T model)
        {
            using TContext context = new();
            EntityEntry<T> entityEntry = context.Set<T>().Update(model);
            entityEntry.State = EntityState.Modified;
            context.SaveChanges();
        }

        public IEnumerable<T> GetList(Expression<Func<T, bool>>? method, bool tracking = true)
        {
            using TContext context = new();
            var query = context.Set<T>().AsQueryable();
            if (tracking is not true)
            {
                query = query.AsNoTracking();
            }
            return method is null ? query.ToList() : query.Where(method).ToList();
        }
        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            using TContext context = new();
            var query = context.Set<T>().AsQueryable();
            if (tracking is not true)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(x => x.Id == Guid.Parse(id));
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            using TContext context = new();
            var query = context.Set<T>().AsQueryable();
            if (tracking is not true)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(method);
        }
    }
}