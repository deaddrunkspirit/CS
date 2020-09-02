using System;
using System.Collections.Generic;
using System.Text;

namespace EKRLib
{
    public class Box : Item
    {
        private double A, B, C;
        
        public double GetLondestSide()
            => (A > B && A > C) ? A : (B > A && B > C) ? B : C;

        public override string ToString()
            => base.ToString() + $"A: {A:f3}, B: {B:f3}, C: {C:f3}";
    }
}
