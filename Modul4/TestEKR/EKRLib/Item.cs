using System;

namespace EKRLib
{
    public class Item
    {
        public double Weight { get; set; }

        public int CompareTo(Item obj)
        {

        }

        public override string ToString()
            => $"Weight: {Weight:f3}";
        
        public static explicit operator double(Item item)
            => item.Weight;
    }
}
