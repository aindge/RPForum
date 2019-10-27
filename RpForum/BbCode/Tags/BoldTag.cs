using System.Collections.Generic;

namespace RpForum.BbCode.Tags
{
    public class BoldTag : BbTag
    {
        public override IEnumerable<string> Names => new [] {"b", "bold"};
        public override bool IsDefaultAttributeAllowed => false;
    }
}