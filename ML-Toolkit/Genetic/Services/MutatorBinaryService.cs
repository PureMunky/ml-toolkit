using System;
using System.Collections;
using ML_Toolkit.Genetic.Models;

namespace ML_Toolkit.Genetic.Services
{
    public class MutatorBinaryService : IMutator
    {
        private double probability = 0.0;

        public MutatorBinaryService(double probability) {
            this.probability = probability;
        }

        public Solution Mutate(Solution solution)
        {
            Solution rtnSolution = new Solution();
            rtnSolution.Value = (BitArray)solution.Value.Clone();

            for(int i = 0; i < rtnSolution.Value.Length; i++) {
                int rnd = new Random().Next(0, 100);
                if(rnd <= (this.probability * 100)) {
                    rtnSolution.Value[i] = !rtnSolution.Value[i];
                }
            }

            return rtnSolution;
        }

    }
}