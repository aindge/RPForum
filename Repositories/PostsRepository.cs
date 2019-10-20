using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RpForum.Data;
using RpForum.Models;

namespace RpForum.Repositories
{
    public class PostsRepository : Repository<Post>
    {
        public PostsRepository(RpContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Post>> GetByThreadId(int threadId)
        {
            return await Context.Posts.Where(p => p.Thread.Id == threadId).ToListAsync();
        }
    }
}