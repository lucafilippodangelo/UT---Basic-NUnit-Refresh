using System;
using NUnit.Framework;

namespace AttributesDemo.Tests.SomeNamespace
{
    [SetUpFixture]
    public class SetUpFixtureForSpecificNamespace
    {
        [SetUp]
        public void RunBeforeAnyTestsInSomeNamespace()
        {
            Console.WriteLine("#### Before any tests in SomeNamespace");
        }

        [TearDown]
        public void RunAfterAnyTestsInSomeNamespace()
        {
            Console.WriteLine("#### After all tests in SomeNamespace");
        }
    }
}
