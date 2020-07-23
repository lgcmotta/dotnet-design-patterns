using DesignPatterns.Builder.Faceted;
using NUnit.Framework;

namespace DesignPatterns.Tests.Builder.Faceted
{
    public class FacetedBuilderTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void CreatePersonWithAddressInfo()
        {
            var person = new PersonBuilder()
                .Lives
                .Address("Groove Street")
                .City("Los Santos")
                .WithPostCode("00000-000")
                .Build();

            Assert.IsNotNull(person);
        }


        [Test]
        public void CreatePersonWithJobInfo()
        {
            var person = new PersonBuilder()
                .Works
                .AsA("Developer")
                .At("No original ideas inc.")
                .Earning(100000)
                .Build();

            Assert.IsNotNull(person);
        }


        [Test]
        public void CreatePersonWithAddressInfoAndThenJobInfo()
        {
            var person = new PersonBuilder()
                .Lives
                .Address("Groove Street")
                .City("Los Santos")
                .WithPostCode("00000-000")
                .Works
                .AsA("Developer")
                .At("No original ideas inc.")
                .Earning(100000)
                .Build();

            Assert.IsNotNull(person);
        }        
        
        [Test]
        public void CreatePersonWithJobInfoAndThenAddressInfo()
        {
            var person = new PersonBuilder()
                .Works
                .AsA("Developer")
                .At("No original ideas inc.")
                .Earning(100000)
                .Lives
                .Address("Groove Street")
                .City("Los Santos")
                .WithPostCode("00000-000")
                .Build();

            Assert.IsNotNull(person);
        }
    }
}