namespace DesignPatterns.Builder.Functional
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorkAsA(this PersonBuilder builder, string position) =>
            builder.AppendAction(person => person.Position = position);
    }
}