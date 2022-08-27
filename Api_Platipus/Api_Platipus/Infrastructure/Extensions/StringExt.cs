
using System.Linq;

namespace Api_Platipus.Infrastructure.Extensions
{
    public static class StringExt
    {
        public static string ReverseString(this string str)
        {
            var charArray = str.Reverse().ToArray();
            return new string(charArray);
        }
    }
}
