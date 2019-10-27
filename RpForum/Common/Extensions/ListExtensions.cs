using System.Collections.Generic;

namespace RpForum.Common.Extensions
{
    public static class ListExtensions
    {
        public static T Pop<T>(this IList<T> list)
        {
            var first = list[0];
            list.RemoveAt(0);
            return first;
        }
    }
}