using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Builder.Fluent;
using NUnit.Framework;

namespace DesignPatterns.Tests.Builder.Fluent
{
    public class FluentTests
    {
        private string _expectedHtml;

        [SetUp]
        public void Setup()
        {
            _expectedHtml = new StringBuilder()
                .Append("<!DOCTYPE html>\n")
                .Append("<html>\n")
                .Append("  <head>\n")
                .Append("    <title>My Home Page</title>\n")
                .Append("  </head>\n")
                .Append("  <body>\n")
                .Append("    <h1 style=\"font-weight:300\">Heading 1</h1>\n")
                .Append("    <h2 style=\"font-weight:300\">Heading 2</h2>\n")
                .Append("  </body>\n")
                .Append("</html>\n\n")
                .ToString();
        }

        [Test]
        public void CreateHtmlDocument()
        {
            var htmlDocument = new HtmlBuilder()
                .AppendHeadChild("title", "My Home Page")
                .AppendBodyChild("h1", "Heading 1", new[] {("style", "font-weight:300")})
                .AppendBodyChild("h2", "Heading 2", new[] {("style", "font-weight:300")})
                .Build();

            Assert.AreEqual(_expectedHtml.Trim(),htmlDocument.Trim());

        }
    }
}