namespace DesignPatterns.Builder.Faceted
{
    public class PersonBuilder
    {
        protected Person Person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(Person);

        public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);

        public Person Build()
        {
            return Person;
        }
    }
}