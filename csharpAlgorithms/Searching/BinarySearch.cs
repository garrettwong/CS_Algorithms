using System;
using csharpAlgorithms.Searching;

namespace csharpAlgorithms
{
	public class BinarySearch : ISearch
	{
		public BinarySearch()
		{
		}

		/// <summary>
		/// Assumption is that the array is sorted
		/// </summary>
		/// <returns>The index.</returns>
		/// <param name="arr">Sorted array.</param>
		/// <param name="val">Value.</param>
		public int FindIndex(int[] arr, int val)
		{
			int lo = 0;
			int hi = arr.Length - 1;

			return _binarySearch(arr, val, lo, hi);
		}

		private int _binarySearch(int[] arr, int val, int lo, int hi)
		{
			if (lo <= hi)
			{
				int midIndex = (lo + hi) / 2;
				int midValue = arr[midIndex];

				if (val == midValue)
				{
					return midIndex;
				}
				else if (val > midValue) // look on the right
				{
					return _binarySearch(arr, val, midIndex + 1, hi);
				}
				else // look on the left
				{
					return _binarySearch(arr, val, lo, midIndex - 1);
				}
			}

			return -1;
		}

		/// <summary>
		/// Returns the index of the range in which the val searched for occurs
		/// FindRangeSearch([(1,3), (4,6), (7,9)], 6) would return 1
		/// </summary>
		/// <returns>The range search.</returns>
		/// <param name="range">A sorted array of ranges</param>
		/// <param name="val">Value.</param>
		public int FindRangeIndex(Range[] arr, int val)
		{
			int lo = 0;
			int hi = arr.Length - 1;

			return _rangeBinarySearch(arr, val, lo, hi);
		}

		private int _rangeBinarySearch(Range[] arr, int val, int lo, int hi)
		{
			if (lo <= hi)
			{
				int midIndex = (lo + hi) / 2;
				Range midValue = arr[midIndex];

				if (midValue.Start <= val && val <= midValue.End)
				{
					return midIndex;
				}
				else if (val <= midValue.Start) // search left
				{
					return _rangeBinarySearch(arr, val, lo, midIndex - 1);
				}
				else // search right
				{
					return _rangeBinarySearch(arr, val, midIndex + 1, hi);
				}
			}

			return -1;
		}
	}
    public class BinarySearch<T> where T : IComparable<T>
    {
        public BinarySearch()
        {
        }

        /// <summary>
        /// Assumption is that the array is sorted
        /// </summary>
        /// <returns>The index.</returns>
        /// <param name="arr">Sorted array.</param>
        /// <param name="val">Value.</param>
        public int FindIndex(T[] arr, T val)
        {
            int lo = 0;
            int hi = arr.Length - 1;

            return _binarySearch(arr, val, lo, hi);
        }

        private int _binarySearch(T[] arr, T val, int lo, int hi)
        {
            if (lo <= hi)
            {
                int midIndex = (lo + hi) / 2;
                T midValue = arr[midIndex];

                if (val.CompareTo(midValue) == 0)
                {
                    return midIndex;
                }
                else if (val.CompareTo(midValue) > 0) // look on the right
                {
                    return _binarySearch(arr, val, midIndex + 1, hi);
                }
                else // look on the left
                {
                    return _binarySearch(arr, val, lo, midIndex - 1);
                }
            }

            return -1;
        }

        /// <summary>
        /// Returns the index of the range in which the val searched for occurs
        /// FindRangeSearch([(1,3), (4,6), (7,9)], 6) would return 1
        /// </summary>
        /// <returns>The range search.</returns>
        /// <param name="range">A sorted array of ranges</param>
        /// <param name="val">Value.</param>
        public int FindRangeIndex(Range[] arr, int val)
        {
            int lo = 0;
            int hi = arr.Length - 1;

            return _rangeBinarySearch(arr, val, lo, hi);
        }

        private int _rangeBinarySearch(Range[] arr, int val, int lo, int hi)
        {
            if (lo <= hi)
            {
                int midIndex = (lo + hi) / 2;
                Range midValue = arr[midIndex];

                if (midValue.Start <= val && val <= midValue.End)
                {
                    return midIndex;
                }
                else if (val <= midValue.Start) // search left
                {
                    return _rangeBinarySearch(arr, val, lo, midIndex - 1);
                }
                else // search right
                {
                    return _rangeBinarySearch(arr, val, midIndex + 1, hi);
                }
            }

            return -1;
        }
    }
    
    public class Range
	{
		public int Start { get; set; }
		public int End { get; set; }
	}
}
