namespace RpForum.BbCode.Extensions
{
    public static class StringExtensions
    {
        public static bool IsTagString(this string str)
        {
            return str.StartsWith("[") && str.EndsWith("]");
        }
    }
}