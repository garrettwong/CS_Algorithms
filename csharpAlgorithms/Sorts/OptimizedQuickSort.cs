﻿using System;


namespace csharpAlgorithms
{
    /// <summary>
    /// Quick Sort | Runtime: O(n log(n)), average, O(n^2), worst case memory: O(log(n))
    /// Reference: CCI_6th
    /// </summary>
	public class OptimizedQuickSort
	{
		private void _swap(int[] arr, int a, int b)
		{
			int temp = arr[a];
			arr[a] = arr[b];
			arr[b] = temp;
		}
		public OptimizedQuickSort()
		{

		}

		public void QuickSort(int[] arr)
		{
			_quickSort(arr, 0, arr.Length - 1);
		}

        private void _quickSort(int[] arr, int left, int right)
        {

            int index = _partition(arr, left, right);

            if (left < index - 1) // Sort left half
            {
                _quickSort(arr, left, index - 1);
            }
            if (index < right) // Sort right half
            {
                _quickSort(arr, index, right);
            }
        }

        private int _partition(int[] arr, int left, int right)
        {
            int pivotValue = arr[(left + right) / 2]; // Pick pivot point
            while (left <= right)
            {
                // find element on left that should be on right
                while (arr[left] < pivotValue) left++;

                while (arr[right] > pivotValue) right--;

                // swap elements
                if (left <= right)
                {
                    _swap(arr, left, right);
                    left++;
                    right--;
                }
            }
            return left;
        }
	}
}
