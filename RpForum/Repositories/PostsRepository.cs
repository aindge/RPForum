using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RpForum.Common;
using RpForum.Data;
using RpForum.Data.Extensions;
using RpForum.Entities;
using RpForum.ViewModels.Posts;

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

        public async Task Submit(EditPostViewModel viewModel)
        {
            Require.IsValid(viewModel);

            var post = await FindAsync(viewModel.Id);

            Require.NotNull(post, $"The post ID {viewModel.Id} wasn't found in the database'");

            post.Content = viewModel.Content;

            await Context.SaveChangesAsync();
        }
    }
}