using System;
using System.Collections.Generic;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            again:
            Console.Write("Enter Array Size: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 1 || n > 1000)
            {
                Console.WriteLine("size range [1, 1000]");
                goto again;
            }
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                again1:
                int v = 0;
                Console.Write("Enter Array Value: ");
                v = Convert.ToInt32(Console.ReadLine());
                if (v < 0 || v > 10000)
                {
                    Console.WriteLine("size range [0, 10000]");
                    goto again1;
                }
                array[i] = v;
            }
            int result = 0;
            result = solution(array);
            Console.WriteLine($"{result}");
        }

        public static int solution (int[] A)
        {
            Dictionary<int, int> count =
                       new Dictionary<int, int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (count.ContainsKey(A[i])){
                    count[A[i]] += 1;
                }
                else
                {
                    count.Add(A[i], 1);
                }           
            }

            int maxKey = 0, max = 0;

            foreach (KeyValuePair<int, int> ele in count)
            {
                if (ele.Value > max)
                {
                    max = ele.Value;
                    maxKey = ele.Key;
                }
            }
            return maxKey;
        }
    }
}
