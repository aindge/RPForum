using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RpForum.Common;
using RpForum.Data;
using RpForum.Data.Extensions;
using RpForum.Entities;

namespace RpForum.Repositories
{
    public class PostsRepository : Repository<Post>
    {
        public PostsRepository(RpContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Post>> GetByThreadId(int threadId, PageInfo page = null)
        {
            return await Context.Posts
                                .Where(p => p.Thread.Id == threadId)
                                .OrderBy(p => p.CreateDate)
                                .PageWith(page).ToListAsync();
        }
    }
}