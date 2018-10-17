using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonoOptionParserSandbox
{
    public static class Extensions
    {
        public static List<string> AsDelimitedToList(this string input, char delimiter = ',')
        {
            return input.Split(delimiter).ToList();
        }

        public static string[] AsDelimitedArray(this string input, char delimiter = ',')
        {
            return input.Split(delimiter);
        }

        public static FunctionResult<int> ParseInt32(this string input)
        {
            var parseSuccess = Int32.TryParse(input, out int parseResult);

            if(!parseSuccess)
            {
                return FunctionResult<int>.Success(parseResult);
            }

            return FunctionResult<int>.Failure();
        }
    }
}
