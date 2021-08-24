using System;

namespace DesignPatterns.Structural.Flyweights
{
    public class CompanyInformation
    {
        public string Name { get; set; }

        public Uri WebSite { get; set; }
    }

    public static class CompanyInformationFactory
    {
        public static readonly CompanyInformation Company = new()
        {
            Name = "Motta Inc.",
            WebSite = new Uri("https://mottainc.com")
        };
    }
}