﻿using NUnit.Framework;

namespace AttributesDemo.Tests.DataDrivenTests
{
    [TestFixture]
    public class MemoryCalculatorDataDrivenTests
    {
        //LD STEP6
        [TestCase(-5, -10, 15)]
        [TestCase(-5, -5, 10)]
        [TestCase(5, 0, -5)] //LD we subtract "firstNum","secondNum"
        public void ShouldSubtractTwoNegativeNumbers(int firstNum, int secondNum, int expectedNum)
        {
            var sut = new MemoryCalculator();

            sut.Subtract(firstNum);
            sut.Subtract(secondNum);

            Assert.That(sut.CurrentValue, Is.EqualTo(expectedNum));
        }


    }
}
