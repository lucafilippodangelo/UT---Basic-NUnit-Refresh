using NUnit.Framework;
using System;

//LD STEP1
namespace AttributesDemo.Tests.SomeNamespace
{
    [TestFixture]
    public class MemoryCalculatorTests
    {


        MemoryCalculator sut;

        [Test] 
        public void ShouldAdd()
        {
            sut.Add(10);
            sut.Add(5);

            Assert.That(sut.CurrentValue, Is.EqualTo(15));
            Console.WriteLine("Before {0}", "--> test SHOULD ADD");
            //LD I can have a look to the output in the "Output" window under "Tests".
        }


        [Test] 
        public void ShouldSubtract()
        {            
            sut.Subtract(5);

            Assert.That(sut.CurrentValue, Is.EqualTo(-5));
        }

        //LD STEP4
        // we run this code before any test in this "[TestFixture]"
        [SetUp]
        public void BeforeEachTest()
        {
            Console.WriteLine("Before {0}", TestContext.CurrentContext.Test.Name);

            sut = new MemoryCalculator();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine("After {0}", TestContext.CurrentContext.Test.Name);

            sut = null;
        }

    }
}
