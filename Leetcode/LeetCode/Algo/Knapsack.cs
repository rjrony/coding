﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Algo
{
	public class Knapsack
	{
        static int unboundedKnapsack(int k, int[] arr)
        {
            // dp[i] is going to store maximum value
            // with knapsack capacity i.
            int[] dp = new int[k + 1];
            int n = arr.Length;
            // Fill dp[] using above recursive formula
            for (int i = 0; i <= k; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[j] <= i)
                    {
                        dp[i] = Math.Max(dp[i], dp[i - arr[j]] + arr[j]);
                    }
                }
            }
            return dp[k];

        }

        public void Test()
        {

            int t = Convert.ToInt32(Console.ReadLine());
            while (t-- != 0)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                    ;
                int result = unboundedKnapsack(k, arr);

                Console.WriteLine(result);

                //textWriter.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
