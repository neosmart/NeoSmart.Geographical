using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoSmart.Data.Geographical
{
    class RoughlyEqual : IEqualityComparer<string>
    {
        public static string GetKey(string input)
        {
            for (int i = 0; i < input.Length; ++i)
            {
                char c = input[i];
                if (char.ToLowerInvariant(c) != c && char.IsLetterOrDigit(c))
                {
                    return new string(input.ToLowerInvariant().Where(char.IsLetterOrDigit).ToArray());
                }
            }

            return input;
        }

        public bool Equals(string x, string y)
        {
            if ((object)x == (object)y)
            {
                return true;
            }

            if (x == null || y == null)
            {
                return false;
            }

            return x == y ||
                x.ToLowerInvariant().Where(char.IsLetterOrDigit)
                .SequenceEqual(y.ToLowerInvariant().Where(char.IsLetterOrDigit));
        }

        public int GetHashCode(string obj)
        {
            throw new NotImplementedException();
        }
    }
}
