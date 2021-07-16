using System;

namespace DesignPatterns.Prototypes.Cloneable
{
    public class Address : ICloneable, IDeepCloneable<Address>
    {
        public string Street { get; set; }

        public int Number { get; set; }

        public Address(string street, int number)
        {
            Street = street;
            Number = number;
        }

        public object Clone()
        {
            return new Address((string) Street.Clone(), Number);
        }

        public Address DeepClone()
        {
            return new((string) Street.Clone(), Number);
        }
    }
}