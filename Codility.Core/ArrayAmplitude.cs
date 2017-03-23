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

            int min = A[0], max = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (min > A[i])
                {
                    min = A[i];
                }
                if (max < A[i])
                {
                    max = A[i];
                }
            }

            return max - min;
        }
    }
}
