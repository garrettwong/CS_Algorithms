using System;
using csharpAlgorithms.Searching;

namespace csharpAlgorithms
{
	public class SequentialSearch : ISearch
    {
		public SequentialSearch()
		{
		}

        /// <summary>
        /// Find the index of a particular value in an array
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="val"></param>
        /// <returns></returns>
		public int FindIndex(int[] arr, int val)
		{
			for(var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == val)
                {
                    return i;
                }
            }
            return -1;
		}
	}
}
