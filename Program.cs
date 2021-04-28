using System;
namespace CsharpIntermediateLevel
{
    class MethodOverloading
    {
        public static int Area(int s=4)
        {
            return s * s;
        }
        public static double Area(double s=5.6)
        {
            return s * s;
        }
        public static int Area(int l, int b)
        {
            return l * b;
        }
        public static double Area(double l, int b)
        {
            return l * b;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Area(4.5));
            Console.WriteLine(Area(3));
            Console.WriteLine(Area(4.56, 3));
            Console.WriteLine(Area(4, 3));


        }
    }
}
