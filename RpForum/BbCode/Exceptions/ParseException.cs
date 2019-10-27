using System;

namespace RpForum.BbCode.Exceptions
{
    public class ParseException : InvalidOperationException
    {
        public ParseException(string message) : base(message)
        {
            
        }
    }
}