namespace RpForum.BbCode.Parser
{
    public abstract class ParseContext
    {
        public ParseContext InnerContext { get; set; }

        public abstract string ToHtml();
    }
}