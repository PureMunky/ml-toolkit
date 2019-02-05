using System;
using System.Security.Cryptography;
using ML_Toolkit.Genetic.Models;

namespace ML_Toolkit.Genetic.Services
{
    public static class SolutionService
    {
        private static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        public static Solution NewRandom(int length)
        {
            Solution solution = new Solution();
            byte[] randomSolution = new byte[length/8];

            rng.GetBytes(randomSolution);

            solution.Value = new System.Collections.BitArray(randomSolution);

            return solution;
        }
    }
}