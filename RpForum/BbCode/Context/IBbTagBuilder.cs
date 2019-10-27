using System.Collections.Generic;
using RpForum.BbCode.Context.Rules;
using RpForum.BbCode.Context.Tags;
using RpForum.BbCode.Exceptions;

namespace RpForum.BbCode.Context
{
    public interface IBbTagBuilder
    {
        BbTag GetContext(string tag);
    }
}