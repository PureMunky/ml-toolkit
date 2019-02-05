using System;
using System.Collections;
using ML_Toolkit.Genetic.Models;

namespace ML_Toolkit.Genetic.Services
{
    public class BreederBinaryService
    {
        
        public BreederBinaryService()
        {

        }

        public Solution Mate(Solution[] parents)
        {
            Solution solution = new Solution();

            solution.Value = (BitArray)parents[0].Value.Clone();

            return solution;
        }
    }
}