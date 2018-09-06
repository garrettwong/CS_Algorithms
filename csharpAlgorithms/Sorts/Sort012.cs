using System;


namespace csharpAlgorithms.Sorts
{
	/// <summary>
	/// Question 43: Given an array that contains only 0, 1 or 2, sort it without using any sorting function
	/// input: 0, 1, 1, 0, 2, 1
	/// output: 0, 0, 1, 1, 1, 2
	/// </summary>
	public class Sort012
	{
		public void Swap(int[] arr, int i, int j)
		{
			int temp = arr[i];
			arr[i] = arr[j];
			arr[j] = temp;
		}

		/// <summary>
		/// Sort an array of 0s, 1s and 2s
		/// 	Runtime: O(N)
		/// 	Space Complexity: O(1)
		/// </summary>
		/// <returns>A sorted array.</returns>
		/// <param name="arr">An array of 0s, 1s and 2s.</param>
		/// <param name="l">L.</param>
		/// <param name="h">The height.</param>
		public void Sort(int[] arr)
		{
			if (arr == null)
			{
				return;
			}
			int start = 0,
				mid = 0,
				end = arr.Length - 1;

			while (mid <= end)
			{
				switch (arr[mid])
				{
					case 0:
						Swap(arr, start, mid);
						start++;
						mid++;
						break;
					case 1:
						mid++;
						break;
					case 2:
						Swap(arr, mid, end);
						end--;
						break;
				}
			}
		}
	}
}
