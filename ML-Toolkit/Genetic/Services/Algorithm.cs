using System;
using ML_Toolkit.Genetic.Models;

namespace ML_Toolkit.Genetic.Services
{
    /// Genetic Algorithm Logic
    public static class Algorithm
    {

        private static Solution[] CreateInitialPopulation(Configuration configuration)
        {
            Solution[] population = new Solution[configuration.PopulationSize];

            for (var i = 0; i < configuration.PopulationSize; i++)
            {
                population[i] = SolutionService.NewRandom(configuration.SolutionSize);
            }

            return population;
        }

        private static Solution[] FindNewParents(Configuration configuration, Solution[] population)
        {
            Solution[] parents = new Solution[2];

            for (int i = 0; i < population.Length; i++)
            {
                population[i].Fitness = configuration.Fitness(population[i]);
            }

            Array.Sort(population, delegate (Solution solution1, Solution solution2)
            {
                return solution1.Fitness.CompareTo(solution2.Fitness);
            });

            parents[0] = population[population.Length - 1];
            parents[1] = population[population.Length - 2];

            return parents;
        }

        private static Solution[] MateParents(Configuration configuration, Solution[] parents)
        {
            Solution[] population = new Solution[configuration.PopulationSize];

            for(int i = 0; i < configuration.PopulationSize; i++)
            {
                population[i] = configuration.Mate(parents);
            }

            return population;
        }

        public static Results Run(Configuration configuration)
        {
            if (configuration.Fitness == null)
                throw new ArgumentNullException("Fitness", "The Fitness function must be defined.");

            if(configuration.Mate == null)
                throw new ArgumentNullException("Mate", "The Mate function must be defined.");

            Solution[] population = CreateInitialPopulation(configuration);

            Solution[] parents = FindNewParents(configuration, population);

            Results results = new Results()
            {
                BestSolution = parents[0],
                BestFitness = parents[0].Fitness,
                GenerationCount = 0,
                TotalGenerations = 0
            };

            for(int i = 0; i < configuration.MaxGenerationCount; i++) {
                results.TotalGenerations = i;
                population = MateParents(configuration, parents);
                parents = FindNewParents(configuration, population);

                if(parents[0].Fitness > results.BestFitness) {
                    results.BestSolution = parents[0];
                    results.BestFitness = parents[0].Fitness;
                    results.GenerationCount = i;
                }

            }

            return results;
        }

    }
}