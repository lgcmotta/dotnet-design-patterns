﻿using DesignPatterns.Creational.Builders;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Creational.Builders
{
    public class ShoppingListBuilderTests
    {
        [Fact]
        public void CreatingInstanceShoppingListBuilder_DefaultConstructor()
        {
            using var shoppingListBuilder = new ShoppingListBuilder();

            shoppingListBuilder.Should().NotBeNull();
        }

        [Fact]
        public void CreatingInstanceShoppingListBuilder_NonDefaultConstructor()
        {
            using var shoppingListBuilder = new ShoppingListBuilder(new ShoppingListSectionBuilder());

            shoppingListBuilder.Should().NotBeNull();
        }

        [Fact]
        public void EmptyShoppingListCreated()
        {
            using var shoppingListBuilder = new ShoppingListBuilder();

            var shoppingList = shoppingListBuilder.Build();

            shoppingList.Should().NotBeNull();
            shoppingList.Title.Should().BeNullOrEmpty();
            shoppingList.Sections.Should().BeNullOrEmpty();
        }
        
        [Fact]
        public void AddingTitleToShoppingList()
        {
            using var shoppingListBuilder = new ShoppingListBuilder();

            var shoppingList = shoppingListBuilder.WithTitle("Monthly shopping").Build();

            shoppingList.Title
                .Should()
                .NotBeNullOrEmpty()
                .And
                .BeEquivalentTo("Monthly shopping");
        }

        [Fact]
        public void AddingSingleSectionToShoppingList()
        {
            using var shoppingListBuilder = new ShoppingListBuilder();

            var shoppingList = shoppingListBuilder
                .AppendGroup(builder => builder.WithDescription("Laundry items"))
                .Build();

            shoppingList.Sections
                .Should()
                .NotBeNullOrEmpty()
                .And
                .HaveCount(1)
                .And
                .ContainSingle(section => section.Description == "Laundry items");
        }

        [Fact]
        public void AddingMultipleSectionsToShoppingList()
        {
            using var shoppingListBuilder = new ShoppingListBuilder();

            var shoppingList = shoppingListBuilder
                .AppendGroup(builder => builder.WithDescription("Laundry items"))
                .AppendGroup(builder => builder.WithDescription("Food"))
                .AppendGroup(builder => builder.WithDescription("Bathroom items"))
                .Build();

            shoppingList.Sections.Should()
                .NotBeNullOrEmpty()
                .And
                .HaveCount(3)
                .And
                .BeEquivalentTo(expectations:
                    new object[]
                    {
                        new Section() {Description = "Laundry items"},
                        new Section() {Description = "Food"},
                        new Section() {Description = "Bathroom items"}
                    });
        }

        [Fact]
        public void CreatingMultipleInstancesOfShoppingList_NotTheSameInstance()
        {
            using var shoppingListBuilder = new ShoppingListBuilder();

            var shoppingList1 = shoppingListBuilder.Build();
            
            var shoppingList2 = shoppingListBuilder.Build();

            shoppingList1.Should().NotBeSameAs(shoppingList2);  
        }

        [Fact]
        public void CreatingMultipleShoppingLists_WithoutCleaningTheBuilder()
        {
            using var shoppingListBuilder = new ShoppingListBuilder();

            var shoppingList1 = shoppingListBuilder.WithTitle("Shopping List 1").Build();

            var shoppingList2 = shoppingListBuilder.Build();

            shoppingList1.Title.Should().BeSameAs(shoppingList2.Title);
        }

        [Fact]
        public void CreatingMultipleShoppingLists_CleaningTheBuilder()
        {
            using var shoppingListBuilder = new ShoppingListBuilder();

            var shoppingList1 = shoppingListBuilder.WithTitle("Shopping List 1").Build();

            shoppingListBuilder.Clear();

            var shoppingList2 = shoppingListBuilder.Build();

            shoppingList1.Title.Should().NotBeSameAs(shoppingList2.Title);
        }

        [Fact]
        public void CreatingMultipleShoppingList_OverridingLastCall()
        {
            using var shoppingListBuilder = new ShoppingListBuilder();

            var shoppingList1 = shoppingListBuilder.WithTitle("Shopping List 1").Build();

            var shoppingList2 = shoppingListBuilder.WithTitle("Shopping List 2").Build();

            shoppingList1.Title.Should().NotBeSameAs(shoppingList2.Title);

            Assert.Equal("Shopping List 1", shoppingList1.Title);
            
            Assert.Equal("Shopping List 2", shoppingList2.Title);
        }
    }
}