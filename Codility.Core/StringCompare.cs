using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallardChalmers.Test
{
	public class StringCompare
	{
		public static int Solution(string S1, string S2)
		{
			//I think the string.Compare function would do what is required, the long hand equivalent is something like this:

			if (string.Equals(S1, S2, StringComparison.OrdinalIgnoreCase))
			{
				return 0;
			}

			List<int> S1AsciiArray = new List<int>();
			foreach (char S1Char in S1.ToLower().ToCharArray())
			{
				S1AsciiArray.Add((int)S1Char);
			}

			List<int> S2AsciiArray = new List<int>();
			foreach (char S2Char in S2.ToLower().ToCharArray())
			{
				S2AsciiArray.Add((int)S2Char);
			}

			int smallestLength = Math.Min(S1.Length, S2.Length);

			for(int index = 0; index < smallestLength; index++)
			{
				if (S1AsciiArray[index] < S2AsciiArray[index])
				{
					return -1;
				}
				if (S2AsciiArray[index] < S1AsciiArray[index])
				{
					return 1;
				}
			}
			

			return 0;
		}

	}
}
