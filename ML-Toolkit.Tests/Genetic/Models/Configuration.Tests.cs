using NUnit.Framework;
using ML_Toolkit.Genetic.Models;
using System;

namespace ML_Toolkit.Tests.Genetic
{

    [TestFixture]
    public class ConfigurationTests
    {
        [Test]
        public void NullFitnessTest()
        {
            Assert.IsNull(new Configuration().Fitness);
        }

        [Test]
        public void NullInterpretTest()
        {
            Assert.IsNull(new Configuration().Interpret);
        }

        [Test]
        public void DefaultPopulationSize(){
            Assert.AreEqual(1000, new Configuration().PopulationSize);
        }

        [Test]
        public void DefaultSolutionSize() {
            Assert.AreEqual(8, new Configuration().SolutionSize);
        }
    }
}