using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class MergeSort
    {
        public List<int> Sort(List<int> numbers)
        {
            if (numbers.Count <= 1)
            {
                return numbers;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < numbers.Count; ++i)
            {
                if (i < numbers.Count / 2)
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);
                }
            }

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        public List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    MoveValueFromSourseToResult(left, result);
                }
                else
                {
                    MoveValueFromSourseToResult(right, result);
                }
            }

            while (left.Count > 0)
            {
                MoveValueFromSourseToResult(left, result);
            }

            while (right.Count > 0)
            {
                MoveValueFromSourseToResult(right, result);
            }

            return result;
        }

        private static void MoveValueFromSourseToResult(List<int> list, List<int> result)
        {
            result.Add(list[0]);
            list.RemoveAt(0);
        }
    }
}
