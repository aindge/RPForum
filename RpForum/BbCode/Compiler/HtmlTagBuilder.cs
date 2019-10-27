using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace RpForum.BbCode.Compiler
{
    public class HtmlTagBuilder
    {
        private readonly HtmlTag _tag = new HtmlTag();

        public HtmlTagBuilder WithName(string Name)
        {
            _tag.Name = Name;
            return this;
        }

        public HtmlTagBuilder IsVoidElement(bool isVoidElement = true)
        {
            _tag.IsVoidElement = isVoidElement;
            return this;
        }

        public HtmlTagBuilder WithAttributes(IEnumerable<KeyValuePair<string, string>> attrEnumerable)
        {
            foreach (var (key, value) in attrEnumerable)
            {
                _tag.AddAttribute(key, value);
            }

            return this;
        }

        public HtmlTagBuilder WithAttribute(string name, string value)
        {
            _tag.AddAttribute(name, value);
            return this;
        }

        public HtmlTag Build()
        {
            return _tag;
        }
    }
}