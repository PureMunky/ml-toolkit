using System;
using ML_Toolkit.Genetic.Models;

namespace ML_Toolkit.Genetic.Services
{
    public interface IMutator
    {
        Solution Mutate(Solution solution);
    }
}