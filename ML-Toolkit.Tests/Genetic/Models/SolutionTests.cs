using System.Collections;
using NUnit.Framework;
using ML_Toolkit.Genetic.Models;

namespace ML_Toolkit.Tests.Genetic.Models
{
    public class SolutionTests
    {
        
        [Test]
        public void BaseConstructor()
        {
            Solution solution = new Solution();

            Assert.AreEqual(null, solution.Value);
            Assert.AreEqual(0.0, solution.Fitness);
        }
    }
}