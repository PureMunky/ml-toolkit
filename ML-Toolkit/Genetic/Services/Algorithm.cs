using System;
using ML_Toolkit.Genetic.Models;

namespace ML_Toolkit.Genetic.Services
{
    /// Genetic Algorithm Logic
    public static class Algorithm
    {

        public static Results Run(Configuration configuration)
        {
            if (configuration.Fitness == null)
                throw new ArgumentNullException("Fitness", "The Fitness function must be defined.");

            Solution solution = SolutionService.NewRandom(configuration.SolutionSize);

            return new Results()
            {
                BestSolution = solution,
                BestFitness = configuration.Fitness(solution)
            };
        }

    }
}