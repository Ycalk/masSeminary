using System;
using System.ComponentModel;
using masSeminary;
namespace masSeminary
{
    internal class Program
    {
        private static void Main()
        {
            
        }

        private static void T1()
        {
            var mas = new[] { 1, 2, 3, 4, 5 };
            Task1.Solution(mas, 1);
            foreach (var i in mas)
                Console.Write(i + " ");
        }

        private static void T2()
        {
            var first = new[] { 1, 1, 2, 3, 7, 7, 7, 7, 9, 12 };
            var second = new[] { 1, 3, 5, 7, 7, 8, 12 };
            var Solution = new Task2(first, second);
            foreach (var i in Solution.Difference)
                Console.Write(i + " ");
        }

        private static void T3()
        {
            var num = Task3.Solution(3, 8, new[] { 1, 2, 2, 1, 1, 0, 2, 1, 0, 1});
            Console.WriteLine(num);
        }

        private static void T4()
        {
            Console.WriteLine(Task4.Solution(1,13));
        }

        private static void T5()
        {
            Console.WriteLine(Task5.Solution(new[] { 1, 1, 2, 2, 2, 3, 4 }));
        }

        private static void T6()
        {
            Console.WriteLine(Task6.Solution(5, 7));
        }
    }
}
