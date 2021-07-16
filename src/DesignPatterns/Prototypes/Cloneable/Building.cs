using System;

namespace DesignPatterns.Prototypes.Cloneable
{
    public class Building : ICloneable, IDeepCloneable<Building>
    {
        public int[] Floors { get; set; }

        public Address Address { get; set; }

        public Building(int[] floors, Address address)
        {
            Floors = floors;
            Address = address;
        }

        public object Clone()
        {
            return new Building((int[]) Floors.Clone(), (Address) Address.Clone());
        }

        public Building DeepClone()
        {
            return new ((int[]) Floors.Clone(), Address.DeepClone());
        }
    }
}