using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class QuickSort
    {
        private int pivot;
        private int swapIndex;

        public List<int> Sort(List<int> numbers, int start, int end)
        {
            if (start < end)
            {
                pivot = Partition(numbers, start, end);
                Sort(numbers, start, pivot);
                Sort(numbers, pivot+ 1, end);
            }
            return numbers;
        }

        public void Swap(List<int> numbers, int i, int j)
        {
            int tmp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = tmp;
        }

        public int Partition(List<int> numbers, int start, int end)
        {
            pivot = numbers[start];
            swapIndex = start;

            for (int i = start + 1; i < end; ++i)
            {
                if (numbers[i] < pivot)
                {
                    swapIndex++;
                    Swap(numbers, i, swapIndex);
                }
            }
            Swap(numbers, start, swapIndex);
            return swapIndex;
        }
    }
}
