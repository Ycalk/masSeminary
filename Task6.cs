using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masSeminary
{
    internal static class Task6
    {
        public static int Solution(int vertical, int horizontal)
        {
            if (vertical == horizontal)
                return vertical;
            if ((vertical == 1) || (horizontal == 1))
                return 0;

            // y = k * x = vertical/horizontal * x
            vertical--;
            horizontal--;
            var counter = vertical + horizontal - 1;

            for (var x = 1; x < horizontal; x++)
                if ((vertical * x) % horizontal == 0)
                    counter--;
            return counter ;
        }
    }
}
