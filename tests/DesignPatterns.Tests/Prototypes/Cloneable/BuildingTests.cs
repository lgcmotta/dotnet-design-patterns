using System.Linq;
using DesignPatterns.Prototypes.Cloneable;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Prototypes.Cloneable
{
    public class BuildingTests
    {
        [Fact]
        public void CloneABuilding_Success()
        {
            var building = new Building(Enumerable.Range(1, 11).ToArray(), new Address("Ipiranga Avenue", 10));

            var buildingClone = (Building)building.Clone();

            buildingClone.Should().NotBeSameAs(building).And.BeEquivalentTo(building);
        }

        [Fact]
        public void CloneAndModifyABuilding_Success()
        {
            var building = new Building(Enumerable.Range(1, 11).ToArray(), new Address("Ipiranga Avenue", 10));

            var buildingClone = (Building)building.Clone();

            buildingClone.Floors = Enumerable.Range(1, 21).ToArray();
            
            buildingClone.Address = new Address("Fake Road", 123);

            buildingClone.Should().NotBeSameAs(building);
            
            buildingClone.Floors.Should().NotBeEquivalentTo(building.Floors);
            
            buildingClone.Address.Should().NotBeEquivalentTo(building.Address);
        }

        [Fact]
        public void DeepCloneABuilding_UsingInterface_Success()
        {
            var building = new Building(Enumerable.Range(1, 11).ToArray(), new Address("Ipiranga Avenue", 10));

            var buildingClone = building.DeepClone();

            buildingClone.Should().NotBeSameAs(building).And.BeEquivalentTo(building);
        }
        [Fact]
        public void DeepCloneAndModifyABuilding_UsingInterface_Success()
        {
            var building = new Building(Enumerable.Range(1, 11).ToArray(), new Address("Ipiranga Avenue", 10));

            var buildingClone = building.DeepClone();

            buildingClone.Floors = Enumerable.Range(1, 21).ToArray();

            buildingClone.Address = new Address("Fake Road", 123);

            buildingClone.Should().NotBeSameAs(building);

            buildingClone.Floors.Should().NotBeEquivalentTo(building.Floors);

            buildingClone.Address.Should().NotBeEquivalentTo(building.Address);
        }

        [Fact]
        public void PassingTheBuildingReferenceWillNotWork_Success()
        {
            var building = new Building(Enumerable.Range(1, 11).ToArray(), new Address("Ipiranga Avenue", 10));

            var buildingClone = building;

            buildingClone.Floors = Enumerable.Range(1, 21).ToArray();
            
            buildingClone.Address = new Address("Fake Street", 123);

            buildingClone.Should().BeSameAs(building);
            
            Assert.Equal(buildingClone.Address.Number, building.Address.Number);
            
            Assert.Equal( buildingClone.Address.Street, building.Address.Street);
            
            Assert.Equal( buildingClone.Floors, building.Floors);
            
            Assert.NotEqual("Ipiranga Avenue", building.Address.Street);
            
            Assert.NotEqual(10, building.Address.Number);
        }
    }
}