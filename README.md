# UT-Basic-NUnit-Refresh

This quick project to refresh some basics of NUnit

## Main Topics

- basic settings
- asserts
  - what makes a good test?
  - Nunit assert types
- aunit attributes
- data driven tests

## Project Description

### Nunit basics

Basic settings: here how to mock classes for "NUnit". From a "Test Project": [TestFixture] for classes -> [Test] for methods

what are "asserts"?:
asserts tell to the test runner whether a test has passed or failed
ASSERT.that("method to call","expected result")

What Makes a good test?
a good test is indipendent and isolated (the test has to run with other tests and still get the same result. test "a" and "b" have to run in any sequence without compromise results of eachother)
test single behaviour/ logical thing repeatable (the test has to give the same result in the time with the same input data)

Settings
 - install "NUnit Test Adapter"
 - I have in the project "IdentityTest" a couple of new projects:
   - "TestLibrary" that contain the classes
   - "TestLibrary.Test" that contain the test

### first test

//LD STEP1 I add the tests and open "Test"->"Window"->"Test Explorer"

### Nunit assert

Focus on different type of asserts:
 - string equality --> "Assert.That("variable With a String", Is.EqualTo("ciao mamma").IgnoreCase)"
 - asserting numeric equality --> when I deal with "floating" numbers like double, I have to use "Assert.That(resultVariable, Is.EqualTo(3.3).Within(0.01))" in order to add tollerance
 - asserting datetime equality --> also here I can use "Within"
 - asserting with ranges--> Is.InRange(x,y)
 - asserting null and booleans -> Is.Not.Empty
 - asserting on collection --> I added comments in the project, search for "//LD"
   - //LD STEP2 (definition)
   - //LD STEP3 (test)
 - asserting reference equality --> here I test if two references point to the same object, with "Assert.That(objectOne, Is.SameAs(objectTwo))"
 - asserting object TYPE and properties --> so we assert that object are of the correct type and that them have the correct properties.
   - I use "Is.TypeOf<AnObjectType>" when I want check if an object just created is of that specific type
   - I use "Is.InstanceOf<ASuperClass>" to see if a specific instance is inheriting from a specific superclass
   - I use "HasProperty" to check that a specific object has a specific property.
 - asserting that the code return the correct exception

### NUnit Attributes

Is possible run code before and after each TEST
 - //LD STEP4 the first attribute is "[Setup]"
   - the framework runs this code before any test in the specific "[TestFixture]". 

To run code before and after each fixture, namespace, assembly:
 - [TestFixtureSetup]

### Data Driven Tests

the purpose is: run the same test with multiple test case data. What we do is just see what's the behaviour of the test with different input data.

- //LD STEP6

 ```
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
     ```

is possible: reuse "TestCase" with [TestCaseSource]

- //LD STEP7 is possible [Ignore] tests by the attribute.