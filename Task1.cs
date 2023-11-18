using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masSeminary
{
    internal static class Task1
    {
        public static void Solution(int[] mas, int K)
        {
            K = K % mas.Length;
            //for (int i = 0; i + K < mas.Length; i++)
            //    (mas[i], mas[i + K]) = (mas[i + K], mas[i]);

            for (var i = 0; i < K; i++)
                for (var j = 0; j < mas.Length - 1; j++)
                    (mas[j], mas[j + 1]) = (mas[j + 1], mas[j]);
                
        }
    }
}
