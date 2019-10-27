using RpForum.BbCode.Context.Tags;

namespace RpForum.BbCode.Context.Rules
{
    public interface IBbContextRule
    {
        bool Matches(string tag);

        BbTag Get(string tag);
    }
}