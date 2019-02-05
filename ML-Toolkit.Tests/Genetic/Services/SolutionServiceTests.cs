using NUnit.Framework;
using ML_Toolkit.Genetic.Models;
using ML_Toolkit.Genetic.Services;

namespace ML_Toolkit.Tests.Genetic.Services
{
    public class SolutionServiceTests
    {
        
        [Test]
        public void RandomizeSolutionSizeTest()
        {
            Solution solution = SolutionService.NewRandom(8);

            Assert.AreEqual(8, solution.Value.Length);
        }

        [Test]
        public void RandomizeSolutionTest()
        {
            const int size = 8;
            Solution solution1 = SolutionService.NewRandom(size);
            Solution solution2 = SolutionService.NewRandom(size);

            Assert.AreNotEqual(solution1, solution2);
        }
    }
}