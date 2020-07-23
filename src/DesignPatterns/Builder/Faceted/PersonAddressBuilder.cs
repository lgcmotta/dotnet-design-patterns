namespace DesignPatterns.Builder.Faceted
{
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person) => Person = person;

        public PersonAddressBuilder City(string city)
        {
            Person.City = city;
            return this;
        }
        
        public PersonAddressBuilder Address(string streetAddress)
        {
            Person.StreetAddress = streetAddress;
            return this;
        }
        
        public PersonAddressBuilder WithPostCode(string postCode)
        {
            Person.PostCode = postCode;
            return this;
        }
    }
}