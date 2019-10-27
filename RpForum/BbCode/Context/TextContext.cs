using System.Linq;

namespace RpForum.BbCode.Context
{
    public class TextContext : ParseContext
    {
        public TextContext()
        {
            
        }

        public TextContext(string text) : base()
        {
            Text = text;
        }

        public string Text { get; set; }

        public override string ToHtml()
        {
            return string.Join("", InnerContexts.Select(i => i.ToHtml()));
        }
    }
}