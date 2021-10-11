using System;

namespace Task1
{
    public class RightTriangle : Triangle
    {
        public double Square
        {
            get{return a*a*Math.Sqrt(3)/4;}
        }
        public RightTriangle(double side) : base(side, side, side)
        {

        }
        
    }
}
