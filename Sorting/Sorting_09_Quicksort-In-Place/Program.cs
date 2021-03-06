﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_09_Quicksort_In_Place
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var input = System.Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] iInput = Array.ConvertAll(sInput, int.Parse);

            QuickSort(iInput, 0, iInput.Length - 1);
            Console.ReadLine();
        }

        public static void QuickSort(int[] iInput, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(iInput, start, end);
                Console.WriteLine(string.Join(" ", iInput));
                QuickSort(iInput, start, pivot - 1);
                QuickSort(iInput, pivot + 1, end);
            }
        }

        public static int Partition(int[] iInput, int start, int end)
        {
            int pivot = iInput[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (iInput[i] <= pivot)
                {
                    int temp = iInput[i];
                    iInput[i] = iInput[pIndex];
                    iInput[pIndex] = temp;
                    pIndex++;
                }
            }

            int anotherTemp = iInput[pIndex];
            iInput[pIndex] = iInput[end];
            iInput[end] = anotherTemp;
            return pIndex;
        }
    }
}
