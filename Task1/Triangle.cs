using System;

namespace Task1
{
      public class Triangle
    {  
        protected double a;
        protected double b;
        protected double c;

        public Triangle(double _a, double _b, double _c)
        {
            bool possible = checkSides(_a, _b, _c);

            if(possible)
            {
                a = _a;
                b = _b;
                c = _c;
            }else 
            {
                Console.WriteLine("impossible triangle sides");
            }
        }

        public double GetSideA() {return a;}
        public double GetSideB() {return b;}
        public double GetSideC() {return c;}

        public double GetAngleA()
        {   
            double cosinusA = (Math.Pow(b,2) + Math.Pow(c,2) - Math.Pow(a,2)) / (2*b*c);
            return Math.Acos(cosinusA);
        }

        public double GetAngleB()
        {   
            double cosinusB = (Math.Pow(a,2) + Math.Pow(c,2) - Math.Pow(b,2)) / (2*a*c);
            return Math.Acos(cosinusB);
        }

        public double GetAngleC()
        {   
            double cosinusC = (Math.Pow(a,2) + Math.Pow(b,2) - Math.Pow(c,2)) / (2*a*b);
            return Math.Acos(cosinusC);
        }

        public double GetPerimeter()
        {
            return a + b + c;
        }
        
        public void setSides(double _a, double _b, double _c)
        {
            bool possible = checkSides(a,b,c);

            if(possible)
            {
                a = _a;
                b = _b;
                c = _c;
            }else 
            {
                Console.WriteLine("impossible triangle sides");
            }
        }

        

        public static bool checkSides(double a, double b, double c)
        {
            if(0 >= a || 0 >= b || 0 >= c) return false;

            if(a >= b + c  || b >= a + c  || c >= a + b) return false;

            return true;
        }
    }
}
