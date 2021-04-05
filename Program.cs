using System;
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

        private static void BubbleSort(int[] initalArray)
        {
            for (int i = 0; i < initalArray.Length-1; i++)
            {
                for (var j = i+1; j < initalArray.Length; j++)
                { 
                    if (initalArray[i] > initalArray[j])
                    {
                        var t = initalArray[i];
                        initalArray[i] = initalArray[j];
                        initalArray[j] = t;
                    }
                }
            }
        }
    }
}