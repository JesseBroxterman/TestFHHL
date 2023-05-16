using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Web.Extensions
{
    public static class StringExtensions
    {
        public static string LikeString(this string val)
        {
            return $"%{val}%";
        }

        public static string ToSentence(this string Input)
        {
            return new string(Input.SelectMany((c, i) => i > 0 && char.IsUpper(c) ? new[] { ' ', c } : new[] { c }).ToArray());
        }
    }
}
