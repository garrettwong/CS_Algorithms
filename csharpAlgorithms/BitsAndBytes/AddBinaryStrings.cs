using System;

namespace csharpAlgorithms
{
	public class AddBinaryStrings
	{
		public AddBinaryStrings() { }

		/// <summary>
		/// Adds two binary strings together.  "001" + "010" = "011"
		/// </summary>
		/// <returns>The added binary string result.</returns>
		/// <param name="binaryStr1">Binary str1.</param>
		/// <param name="binaryStr2">Binary str2.</param>
		public string Add(string binaryStr1, string binaryStr2)
		{
			int pointer1 = binaryStr1.Length - 1,
				pointer2 = binaryStr2.Length - 1;

			int carry = 0;
			string result = "";

			while (pointer1 >= 0 ||
				   pointer2 >= 0 ||
				   carry != 0)
			{
				int curSum = carry;
				carry = 0;

				curSum += (pointer1 >= 0) ? int.Parse(binaryStr1[pointer1].ToString()) : 0;
				curSum += (pointer2 >= 0) ? int.Parse(binaryStr2[pointer2].ToString()) : 0;

				if (curSum > 1)
				{
					curSum -= 2;
					carry = 1;
				}
				result = curSum.ToString() + result;

				pointer1--;
				pointer2--;
			}

			return result;
		}
	}
}
