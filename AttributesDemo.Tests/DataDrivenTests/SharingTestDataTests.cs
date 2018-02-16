using NUnit.Framework;
using System.Collections;

namespace AttributesDemo.Tests.DataDrivenTests
{
    [TestFixture]
    public class SharingTestDataTests
    {
        //LD STEP7
        [TestCaseSource(typeof(ExampleTestCaseSource))]
        public void ShouldSubtractNegativeNumbers(int firstNum, int secondNum, int expectedNum)
        {
            var sut = new MemoryCalculator();

            sut.Subtract(firstNum);
            sut.Subtract(secondNum);

            Assert.That(sut.CurrentValue, Is.EqualTo(expectedNum));
        }
    }

    //LD STEP7
    public class ExampleTestCaseSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new[] { -5, -10, 15 };
            yield return new[] { -5, -5, 10 };
            yield return new[] { -5, 0, 5 };
            yield return new[] { 0, 0, 0 };
        }
    }


}
