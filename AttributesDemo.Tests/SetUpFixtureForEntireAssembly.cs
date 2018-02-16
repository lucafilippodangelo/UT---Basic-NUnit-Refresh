using System;
using NUnit.Framework;


// Notice no containing namespace for this class

[SetUpFixture]
public class SetUpFixtureForEntireAssembly
{
    [SetUp]
    public void RunBeforeAnyTestsInEntireAssembly()
    {
        Console.WriteLine("!!!!! Before any tests in entire assembly");
    }

    [TearDown]
    public void RunAfterAnyTestsInInEntireAssembly()
    {
        Console.WriteLine("!!!!! After all tests in entire assembly");
    }
}

