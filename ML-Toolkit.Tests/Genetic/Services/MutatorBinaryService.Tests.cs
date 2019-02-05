using NUnit.Framework;
using ML_Toolkit.Genetic.Models;
using ML_Toolkit.Genetic.Services;

namespace ML_Toolkit.Tests.Genetic.Services
{
    public class MutatorBinaryServiceTests
    {
        [Test]
        public void BinaryMutatorTest()
        {
            Solution solution = SolutionService.NewRandom(10);
            Solution mutated = new MutatorBinaryService(1).Mutate(solution);

            Assert.AreNotEqual(solution, mutated);
        }
    }
}