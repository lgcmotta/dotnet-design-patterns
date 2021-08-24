using DesignPatterns.Structural.Flyweights;
using FluentAssertions;
using Xunit;

namespace DesignPatterns.Tests.Structural.Flyweights
{
    public class CompanyInformationTests
    {
        [Fact]
        public void CompanyInformationShouldNotHaveMultipleAllocations()
        {
            var companyInfo1 = CompanyInformationFactory.Company;
            var companyInfo2 = CompanyInformationFactory.Company;

            companyInfo1.Should().BeSameAs(companyInfo2);
            companyInfo1.WebSite.Should().BeSameAs(companyInfo2.WebSite);
            companyInfo1.Name.Should().BeSameAs(companyInfo2.Name);
        }
    }
}