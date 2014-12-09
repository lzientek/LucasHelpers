using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasHelpers.StringHelper
{
    public static class SubstrExtensions
    {
        /// <summary>
        /// substring if needed and add a text at the end
        /// </summary>
        /// <param name="str"></param>
        /// <param name="maxSize">maximum size of the string</param>
        /// <param name="addToEnd">string to add at the end if needed</param>
        /// <returns>the new string with his new number of chars.</returns>
        public static string MaxLength(this string str, int maxSize, string addToEnd ="")
        {
            return string.IsNullOrEmpty(str)?str
                : str.Length <= maxSize ? str
                : string.Format("{0}{1}", str.Substring(0, maxSize), addToEnd);
        }
    }
}
