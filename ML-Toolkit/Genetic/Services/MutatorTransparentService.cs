using System;
using ML_Toolkit.Genetic.Models;

namespace ML_Toolkit.Genetic.Services
{
    public class MutatorTransparentService : IMutator
    {
        public MutatorTransparentService() {
        }
        
        public Solution Mutate(Solution solution) {
            return solution;
        }

    }
}