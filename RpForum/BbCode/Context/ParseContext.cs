using System.Collections;
using System.Collections.Generic;

namespace RpForum.BbCode.Context
{
    public abstract class ParseContext
    {
        public IList<ParseContext> InnerContexts { get; set; }

        public abstract string ToHtml();
    }
}