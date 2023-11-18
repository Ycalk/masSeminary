using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masSeminary
{
    internal static class Task3
    {
        public static string Solution (int A, int B, int[] num)
        {
            var decimalNum = 0;
            var newNum = new List<int>();

            for (var i = 0; i < num.Length; i++)
                decimalNum += num[i] * (int)Math.Pow(A, num.Length - i - 1);

            while (decimalNum > 0)
            {
                newNum.Add(decimalNum % B);
                decimalNum /= B;
            }
            newNum.Reverse();

            return string.Join("", newNum);
        }
    }
}
