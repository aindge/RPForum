using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Hosting;
using RpForum.BbCode.Context;
using RpForum.BbCode.Exceptions;
using RpForum.BbCode.Extensions;
using RpForum.Common.Extensions;

namespace RpForum.BbCode.Parser
{
    public class BbCodeParser : IBbCodeParser
    {
        private readonly string _content;
        private readonly IBbTagBuilder _bbTagBuilder;

        public BbCodeParser(string content, IBbTagBuilder bbBuilder)
        {
            _content = content;
            _bbTagBuilder = bbBuilder;
        }

        public ParseContext Parse()
        {
            var tokens = Tokenize();

            var context = new TextContext();

            BuildContext(tokens, context);

            return context;
        }

        private void BuildContext(IList<string> tokens, ParseContext context)
        {
            var innerContexts = new List<ParseContext>();

            while (tokens.Any())
            {
                var current = tokens.Pop();

                ParseContext newContext;

                if (current.IsTagString())
                {
                    newContext = _bbTagBuilder.GetContext(current);
                }
                else
                {
                    newContext = new TextContext(current);
                }

                BuildContext(tokens, newContext);

                context.InnerContexts.Add(context);
            }
        }

        private IList<string> Tokenize()
        {
            var splits = Regex.Split(_content, @"(\[[^\]]*\]*)");

            return splits.ToList();
        }
    }
}