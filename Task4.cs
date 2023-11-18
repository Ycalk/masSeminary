using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masSeminary
{
    internal static class Task4
    {
        private static void GetRecurringPart (StringBuilder result, int dividend, int divisor)
        {
            var recurringPart = new StringBuilder();
            var remainders = new List<int>();

            while (dividend != 0)
            {
                if (remainders.Contains(dividend))
                {
                    var recurringPartResult = recurringPart.ToString();
                    var index = remainders.IndexOf(dividend);

                    recurringPartResult = recurringPartResult[..index] + "(" +
                                          recurringPartResult[index..] + ")";

                    result.Append(recurringPartResult);
                    return;
                }
                remainders.Add(dividend);
                dividend *= 10;
                recurringPart.Append(dividend / divisor);
                dividend %= divisor;
            }
            result.Append(recurringPart);
        }

        public static string Solution (int dividend, int divisor)
        {
            var result = new StringBuilder();

            result.Append(dividend / divisor);
            dividend %= divisor;

            if (dividend == 0)
                return result.ToString();

            result.Append('.');
            GetRecurringPart(result, dividend, divisor);

            return result.ToString();
        }
    }
}
