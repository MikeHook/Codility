using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Core
{
    public class Lesson1BinaryGap
    {
        public static int Solution(int N)
        {
            var NString = Convert.ToString(N, 2);
            var NArray = NString.ToCharArray();

            if (NString.Contains("0") == false || NString.Contains("1") == false)
            {
                return 0;
            }

            if (NArray.Count(c => c == '1') < 2)
            {
                return 0;
            }

            var oneIndexes = new List<int>();
            for (int i = 0; i < NArray.Length; i++)
            {
                if (NArray[i] == '1')
                {
                    oneIndexes.Add(i);
                }
            }

            var gaps = new List<int>();
            for (int i = oneIndexes.Count - 1; i >= 1; --i)
            {
                gaps.Add(oneIndexes[i] - oneIndexes[i - 1]);
            }

            return gaps.OrderBy(x => x).Last() - 1;
        }
    }
}
