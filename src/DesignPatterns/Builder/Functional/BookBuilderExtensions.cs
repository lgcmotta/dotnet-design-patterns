using System;

namespace DesignPatterns.Builder.Functional
{
    public static class BookBuilderExtensions
    {
        public static BookBuilder PublishedIn(this BookBuilder builder, DateTime published) => builder.AppendAction(book => book.Published = published);
    }
}