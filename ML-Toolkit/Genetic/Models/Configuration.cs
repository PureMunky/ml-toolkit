using System;

namespace ML_Toolkit.Genetic.Models
{
    public class Configuration
    {

        #region Public Delegates
        public delegate double DFitness(Solution solution);
        public delegate string DInterpret(Solution solution);
        public delegate Solution DMutate(Solution solution);
        public delegate Solution DMate(Solution[] parents);
        #endregion

        #region Public Properties
        public DFitness Fitness = null;
        public DInterpret Interpret = null;
        public DMutate Mutate = null;
        public DMate Mate = null;
        
        public int PopulationSize = 1000;
        public int SolutionSize = 8;
        public int MaxGenerationCount = 1000;
        #endregion
    }
}