using System.Collections;
using System.Collections.Generic;
using RpForum.BbCode.Context.Rules;
using RpForum.BbCode.Context.Tags;
using RpForum.BbCode.Exceptions;

namespace RpForum.BbCode.Context
{
    public class BbTagBuilder : IBbTagBuilder
    {
        private IEnumerable<IBbContextRule> Rules = new IBbContextRule[]
        {
            new BbContextRule<BoldTag>(),
            new BbContextRule<ImageTag>(),
        };

        public BbTag GetContext(string tag)
        {
            foreach (var rule in Rules)
            {
                if (rule.Matches(tag)) return rule.Get(tag);
            }

            throw new ParseException($"Unsupported BbCode tag ({tag})");
        }
    }
}