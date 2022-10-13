using System;

namespace ConcatenationofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetConcatenation(new int[] { 1, 2, 3, });
        }

        public static int[] GetConcatenation(int[] nums)
        {
            int[] copied = new int[nums.Length * 2];
            Console.WriteLine(nums.Length);
            nums.CopyTo(copied, 0);
            nums.CopyTo(copied, nums.Length);
            nums = null;
            return copied;
        }
    }
}
