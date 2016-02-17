using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClearMeasureInterview.PrintNumLib;
using NUnit.Framework;

namespace ClearMeasureInterview.Tests
{
    [TestFixture]
    public class PrintNumTest
    {

        // Object Construction Tests
        [Test]
        public void Check_No_Dictionary()
        {
            int testUpperBound = 20;
            var fizzbuzzResults = new FizzBuzz(testUpperBound)
                                              .CalculateFizzBuzzNumbers()
                                              .ToArray();

            Assert.AreEqual(testUpperBound, fizzbuzzResults.Length);
        }

        [Test]
        public void Check_Null_Dictionary()
        {
            int testUpperBound = 20;
            var fizzbuzzResults = new FizzBuzz(testUpperBound, null)
                                              .CalculateFizzBuzzNumbers()
                                              .ToArray();

            Assert.AreEqual(testUpperBound, fizzbuzzResults.Length);
        }


        // Edge Case Tests
        [Test]
        public void Check_Upperbound_Less_Than_One()
        {
            int testUpperBound = -1;

            Assert.Throws(typeof(ArgumentException), 
                          new TestDelegate(() => new FizzBuzz(testUpperBound)));        
        }


        // Result Tests        
        [Test]
        public void Check_Appropriate_Result()
        {
            var fizzbuzzResults = new FizzBuzz(10).CalculateFizzBuzzNumbers()
                                                  .ToArray();

            Assert.AreEqual("1", fizzbuzzResults[0]);
            Assert.AreEqual("2", fizzbuzzResults[1]);
            Assert.AreEqual("3", fizzbuzzResults[2]);
            Assert.AreEqual("4", fizzbuzzResults[3]);
            Assert.AreEqual("5", fizzbuzzResults[4]);
        }

        [Test]
        public void Check_Result_With_Dictionary()
        {
            var fizzbuzzResults = new FizzBuzz(10, new Dictionary<int, string>
                                  {
                                      {3, "Grape"},
                                      {4, "Fruit"}
                                  })
                                  .CalculateFizzBuzzNumbers()
                                  .ToArray();

            Assert.AreEqual("Grape", fizzbuzzResults[2]);
            Assert.AreEqual("Fruit", fizzbuzzResults[3]);
            Assert.AreEqual("5", fizzbuzzResults[4]);
        }

        [Test]
        public void Check_Multiples_In_Dictionary()
        {
            var fizzbuzzResults = new FizzBuzz(100, new Dictionary<int, string>
                                  {
                                      {3, "Fizz"},
                                      {5, "Buzz"},
                                      {15, "Foo"}
                                  })
                                  .CalculateFizzBuzzNumbers()
                                  .ToArray();

            Assert.AreEqual("Foo", fizzbuzzResults[14]);
        }
    }
}
