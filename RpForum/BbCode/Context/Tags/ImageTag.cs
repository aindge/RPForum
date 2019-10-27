using System.Collections.Generic;
using RpForum.BbCode.Compiler;

namespace RpForum.BbCode.Context.Tags
{
    public class ImageTag : BbTag
    {
        public override IEnumerable<string> Names => new[] {"img", "image"};

        public override bool IsDefaultAttributeAllowed => true;

        [Bb]
        public string Width { get; set; }

        [Bb]
        public string Height { get; set; }

        public HtmlTag GetHtmlTag()
        {
            var builder = HtmlTag.Create()
                .WithName("img")
                .IsVoidElement();

            if (Width != null)
            {
                builder.WithAttribute("width", Width);
            }

            if (Height != null)
            {
                builder.WithAttribute("height", Height);
            }

            return builder.Build();
        }
    }
}