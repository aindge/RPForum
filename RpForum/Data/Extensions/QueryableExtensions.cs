using System.Linq;
using System.Threading.Tasks;
using RpForum.Common;

namespace RpForum.Data.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> PageWith<T>(this IQueryable<T> query, PageInfo page)
        {
            return page is null ? query : query.Skip(page.PageNumber).Take(page.PageSize);
        }
    }
}