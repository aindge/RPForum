using System;
using RpForum.BbCode.Context.Tags;

namespace RpForum.BbCode.Context.Rules
{
    public class BbContextRule<T> : IBbContextRule where T : BbTag, new()
    {
        public bool Matches(string tag)
        {
            throw new System.NotImplementedException();
        }

        public BbTag Get(string tag)
        {
            var context = new T();
            var attributes = tag.Trim('[', ']').Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in attributes)
            {
                var attributePairs = item.Split("=");

                if (attributePairs.Length < 2) continue;

                context.SetAttribute(attributePairs[0], attributePairs[1]);
            }

            return context;
        }
    }
}