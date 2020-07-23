namespace DesignPatterns.Builder.Functional
{
    public sealed class BookBuilder : FunctionalBuilder<Book, BookBuilder>
    {
        public BookBuilder WrittenBy(string author) => AppendAction(book => book.Author = author);

        public BookBuilder WithTitle(string title) => AppendAction(book => book.Title = title);
    }
}