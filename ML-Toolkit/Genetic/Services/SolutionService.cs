using System;
using ML_Toolkit.Genetic.Models;

namespace ML_Toolkit.Genetic.Services
{
    public static class SolutionService
    {
        public static Solution NewRandom(int length)
        {
            Solution solution = new Solution();

            solution.Value = new System.Collections.BitArray(length);

            return solution;
        }
    }
}