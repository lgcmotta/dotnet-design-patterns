namespace DesignPatterns.Builder.Functional
{
    public sealed class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
    {
        public PersonBuilder Called(string name) => AppendAction(person => person.Name = name);
    }
}