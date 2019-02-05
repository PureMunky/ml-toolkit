using NUnit.Framework;
using ML_Toolkit.Genetic.Models;
using ML_Toolkit.Genetic.Services;

namespace ML_Toolkit.Tests.Genetic.Services
{
    public class SolutionServiceTests
    {
        
        [Test]
        public void RandomizeSolutionTest()
        {
            Solution solution = SolutionService.NewRandom(8);

            Assert.AreEqual(8, solution.Value.Length);
        }
    }
}