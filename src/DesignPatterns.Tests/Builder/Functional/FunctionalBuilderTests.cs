using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DesignPatterns.Builder.Functional;
using NUnit.Framework;

namespace DesignPatterns.Tests.Builder.Functional
{
    public class FunctionalBuilderTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateAPerson()
        {
            var person = new PersonBuilder()
                .Called("Jane")
                .WorkAsA("Developer")
                .Build();

            Assert.IsNotNull(person);
        }

        [Test]
        public void CreateABook()
        {
            var book = new BookBuilder()
                .WithTitle("Agile Principles, Patterns, and Practices in C#")
                .WrittenBy("Micah Martin and Robert Cecil Martin")
                .PublishedIn(DateTime.Parse("2006-07-20 00:00:00.000"));

            Assert.IsNotNull(book);
        }

    }
}