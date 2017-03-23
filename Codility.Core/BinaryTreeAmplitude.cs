namespace Codility.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Domain;

    public class BinaryTreeAmplitude
    {
        /// <summary>
        /// Return the amplitude of the Tree - The biggest amplitude of all paths in the tree. 
        /// The amplitude is the max difference between path nodes
        /// </summary>
        public static int Solution(Tree t)
        {
            if (t ==null || (t.R == null && t.L == null))
            {
                return 0;
            }

            var paths = new List<List<int>>();
            BinaryTreeAmplitude.CalculateAmplitude(paths, new List<int>() {t.X}, new List<int>() {t.X}, t);

            var amplitudes = new List<int>();
            paths.ForEach(p => amplitudes.Add(ArrayAmplitude.Solution(p.ToArray())));
            return amplitudes.Max();
        }

        public static void CalculateAmplitude(List<List<int>> paths, List<int> leftPath, List<int> rightPath,  Tree t)
        {
            if (t.L != null)
            {
                leftPath.Add(t.L.X);
                CalculateAmplitude(paths, leftPath, rightPath, t.L);
            }
            else
            {
                paths.Add(leftPath);
            }


            if (t.R != null)
            {
                rightPath.Add(t.R.X);
                CalculateAmplitude(paths, leftPath, rightPath, t.R);
            }
            else
            {
                paths.Add(rightPath);
            }
        }

    }
}
