using System.Linq;

namespace Codility.Core
{
    public class ArrayAmplitude
    {
        //The amplitude of a non-empty zero-indexed array A consisting of N numbers is defined as 
        //amplitude(A) = max { A[P] - A[Q] : 0 <= P, Q < N } 

        public static int Solution(int[] A)
        {
            if (A == null || A.Length == 0)
            {
                return 0;
            }

            if (A.Length == 1)
            {
                return A[0];
            }

            var orderedA = A.OrderBy(a => a);

            var result = (long) orderedA.Last() - (long) orderedA.First();
            return result > int.MaxValue ? 0 : (int) result;
        }
    }
}
