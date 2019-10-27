using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using RpForum.BbCode.Compiler;
using RpForum.BbCode.Parser;

namespace RpForum.BbCode.Tags
{
    public abstract class BbTag : ParseContext
    {
        public abstract IEnumerable<string> Names { get; }

        public abstract bool IsDefaultAttributeAllowed { get; }

        public bool Matches(string name)
        {
            return Names.Any(n => n == name.ToLower());
        }

        public string DefaultAttribute { get; set; }

        public void SetAttribute(string name, string value)
        {
            if (name == string.Empty && IsDefaultAttributeAllowed)
            {
                DefaultAttribute = value;
            }
            else
            {
                var attributes = GetType().GetProperties()
                    .Where(p => p.IsDefined(typeof(BbAttribute), false));

                if (attributes.FirstOrDefault(a => a.Name.ToLower() == name) is PropertyInfo prop)
                {
                    prop.SetValue(this, value);
                }
            }
        }

        public sealed override string ToHtml()
        {
            var tag = GetHtmlTag();

            tag.InnerHtml = InnerContext.ToHtml();

            return tag.ToString();
        }

        public virtual HtmlTag GetHtmlTag()
        {
            return new HtmlTagBuilder()
                .WithName(Names.First())
                .Build();
        }
    }
}