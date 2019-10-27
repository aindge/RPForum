using System.Collections.Generic;
using System.Text;

namespace RpForum.BbCode.Compiler
{
    public class HtmlTag
    { 
        public HtmlTag()
        {
            Attributes = new Dictionary<string, string>();
        }

        public HtmlTag(string name, bool isVoidElement) : base()
        {
            Name = name;
            IsVoidElement = isVoidElement;
        }

        public string Name { get; set; }

        public Dictionary<string, string> Attributes { get; set; }

        public bool IsVoidElement { get; set; }

        public string InnerHtml { get; set; }

        public void AddAttribute(string name, string value)
        {
            
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"<{Name} ");

            foreach (var (key, value) in Attributes)
            {
                sb.Append($"{key}=\"{value}\" ");
            }

            sb.Append(!IsVoidElement ? $">{InnerHtml}</{Name}>" : " />");

            return sb.ToString();
        }

        public static HtmlTagBuilder Create()
        {
            return new HtmlTagBuilder();
        }
    }
}