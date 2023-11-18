using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masSeminary
{
    internal static class Task5
    {
        // Не корректное условие задачи:
        // Если массив неубывающий и в нем содержатся только положительные числа
        // логично, что 0-й элемент не получится представить в виде суммы других элементов.
        // Но в то же время его получится представить в виде суммы такого же элемента + ничего
        // (выглядит странно, но в теории множеств, наверное, такое возможно)
        public static int Solution(int[] mas)
        {
            for (var i = 0; i < mas.Length; i++)
            {
                if ( 
                     ( (i == 0) && (mas[i] != mas[i + 1])              ) ||
                     ( (i == mas.Length - 1) && (mas[i] != mas[i - 1]) ) ||
                     ( (mas[i] != mas[i+1]) && (mas[i] != mas[i - 1])  )
                   )
                {
                    return mas[i];
                }
            }
            return -1;
        }
    }
}
