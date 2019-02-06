using NUnit.Framework;
using ML_Toolkit.Genetic.Models;
using ML_Toolkit.Genetic.Services;
using System;

namespace ML_Toolkit.Tests.Genetic
{
    [TestFixture]
    public class AlgorithmTests
    {

        public double testFitness(Solution solution){
            return 0.0;
        }

        public double binaryFitnessTest(Solution solution) {
            int sum = 0;
            for(int i = 0; i < solution.Value.Length; i++) {
                sum += (solution.Value[i] ? 1 : 0);
            }
            return sum;
        }

        [Test]
        public void BaseConstructorMissingFitnessTest()
        {
            try
            {
                Algorithm.Run(new Configuration());
                Assert.Fail();
            }
            catch(ArgumentNullException e)
            {
                Assert.AreEqual("Fitness", e.ParamName);
            }
        }

        [Test]
        public void BaseConstructorMissingMateTest()
        {
            try{
                Algorithm.Run(new Configuration() {
                    Fitness = testFitness
                });
                Assert.Fail();
            }
            catch(ArgumentNullException e)
            {
                Assert.AreEqual("Mate", e.ParamName);
            }
        }

        [Test]
        public void RunTest()
        {
            Results results = Algorithm.Run(new Configuration() {
                Fitness = testFitness,
                Mate = new BreederTransparentService().Mate
            });

            Assert.AreEqual(0.0, results.BestFitness);
        }

        [Test]
        public void BinaryRunTest()
        {
            Results results = Algorithm.Run(new Configuration() {
                Fitness = binaryFitnessTest,
                Mate = new BreederBinaryService().Mate
            });

            Assert.IsTrue(results.BestFitness > 5);
            Assert.AreEqual(999, results.TotalGenerations);
        }
    }

}