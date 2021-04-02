using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloGit
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var initialArray = new[] {1, 5, 3, 2, 5, 6};
            var sortedArray = new[] {1, 2, 3, 5, 5, 6};

            BubbleSort(initialArray);

            if (!initialArray.SequenceEqual(sortedArray)) throw new Exception("Sorting doesn't work!");
            Console.WriteLine("complete!");
        }

        private static void BubbleSort(IEnumerable<int> array)
        {
            // TODO Напиши сортировку пузырьком. Запусти проект, и проверь, что Main не падает.
        }
    }
}