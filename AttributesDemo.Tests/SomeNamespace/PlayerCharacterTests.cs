using NUnit.Framework;
using System;

//LD STEP3 
namespace AttributesDemo.Tests.SomeNamespace
{
    [TestFixture]
    public class PlayerCharacterTests
    {
        private PlayerCharacter sut;

        [SetUp]
        public void BeforeEachTest()
        {
            Console.WriteLine("Before {0}", TestContext.CurrentContext.Test.Name);

            sut = new PlayerCharacter();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine("After {0}", TestContext.CurrentContext.Test.Name);
        }


        #region Fixture

        [TestFixtureSetUp]
        public void BeforeAnyTestStarted()
        {
            Console.WriteLine("*** Before PlayerCharacterTests");
        }

        [TestFixtureTearDown]
        public void AfterAllTestsFinished()
        {
            Console.WriteLine("*** After PlayerCharacterTests");
        } 

        #endregion


        [Test]
        public void ShouldHaveNoEmptyDefaultWeapons()
        {       
            //LD the "All" mean that all the elements in the collection are involved in the check
            Assert.That(sut.Weapons, Is.All.Not.Empty);
        }


        [Test]
        public void ShouldHaveALongBow()
        {
            //LD "Contains"
            Assert.That(sut.Weapons, Contains.Item("Long Bow"));
        }


        [Test]
        public void ShouldHaveAtLeastOneKindOfSword()
        {
            Assert.That(sut.Weapons, Has.Some.ContainsSubstring("Sword"));
        }


        [Test]
        public void ShouldHaveTwoBows()
        {
            Assert.That(sut.Weapons, Has.Exactly(2).EndsWith("Bow"));
        }


        [Test]
        public void ShouldNotHaveMoreThanOneTypeOfAGivenWeapon()
        {            
            Assert.That(sut.Weapons, Is.Unique);
        }


        [Test]
        public void ShouldNotHaveAStaffOfWonder()
        {
            Assert.That(sut.Weapons, Has.None.EqualTo("Staff Of Wonder"));            
        }     


        [Test]
        public void ShouldHaveDefaultsWeaponsInAlphabeticalOrder()
        {           
            Assert.That(sut.Weapons, Is.Ordered);
        }
    }
}

