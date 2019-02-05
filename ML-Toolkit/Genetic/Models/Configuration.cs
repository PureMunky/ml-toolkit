using System;

namespace ML_Toolkit.Genetic.Models
{
    public class Configuration
    {

        #region Public Delegates
        public delegate double DFitness(Solution solution);
        public delegate string DInterpret(Solution solution);
        public delegate Solution DMutate(Solution solution);
        #endregion

        #region Public Properties
        public DFitness Fitness = null;
        public DInterpret Interpret = null;
        public DMutate Mutate = null;
        
        public int PopulationSize = 1000;
        public int SolutionSize = 8;
        #endregion
    }
}