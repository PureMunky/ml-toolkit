using NUnit.Framework;
using ML_Toolkit.Genetic.Models;
using ML_Toolkit.Genetic.Services;

namespace ML_Toolkit.Tests.Genetic.Services
{
    public class MutatorTransparentServiceTests
    {
        [Test]
        public void TransparentTest()
        {
            Solution solution = SolutionService.NewRandom(10);
            Solution mutated = new MutatorTransparentService().Mutate(solution);

            Assert.AreEqual(solution, mutated);
        }
    }
}