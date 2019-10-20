using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using RpForum.Data;
using RpForum.Data.Extensions;
using RpForum.Entities;

namespace RpForum.Repositories
{
    public abstract class Repository<T> where T : class, IDomainEntity, new()
    {
        protected RpContext Context { get; }

        protected Repository(RpContext context)
        {
            Context = context;
        }

        public async Task<T> Find(int id)
        {
            return await Context.Set<T>().FirstOrDefaultAsync(entity => entity.Id == id);
        }

        protected async Task<EntityEntry<T>> Create()
        {
            var entity = new T();
            return Context.Set<T>().Add(entity);
        }
    }
}