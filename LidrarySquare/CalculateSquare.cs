namespace LidrarySquare
{
    public static class CalculateSquare
    {
        public static double Cricle(double radius)
        {
            if(radius <= 0)
                return 0;
            return Math.PI * Pow2(radius);
        }

        public static double Triangle(double a, double b, double c)
        {
            if (CheckTriangle(a, b, c))
            {
                double p = (a + b + c) / 2; //полупериметр для формулы Герона
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
            {
                return 0;
            }
        }

        public static bool IsRightTriangle(double a, double b, double c) //прямоугольный треугольник или нет
        {
            if (CheckTriangle(a, b, c))
            {
                double largest = a;
                double side1 = b;
                double side2 = c;
                if (b > largest)
                {
                    side1 = largest;
                    largest = b;
                }
                if (c > largest)
                {
                    side2 = largest;
                    largest = c;
                }
                if (Pow2(largest) == Pow2(side1) + Pow2(side2))
                {
                    System.Diagnostics.Debug.WriteLine("Треугольник прямоугольный");
                    return true;
                }
                else return false;
            }
            else
            {
                return false;
            }
        }

        static bool CheckTriangle(double a, double b, double c) //существует ли треугольник
        {
            if (a > 0 && b > 0 && c > 0) //существует ли треугольник с такими сторонами
            {
                if (a < b + c && b < c + a && c < a + b) 
                {
                    return true;
                }
            }
            
            
            return false;
        }

        static double Pow2(double num)
        {
            return Math.Pow(num, 2);
        }
    }
}