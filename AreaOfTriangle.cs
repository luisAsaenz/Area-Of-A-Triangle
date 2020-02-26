using System;

namespace AreaOfTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side A is ");
            int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
         
            Console.Write("Side B is ");
            int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));
           
            Console.Write("Side C is ");
            int c = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            
            Console.Write("Side P is ");
            int p = (a + b + c) / 2;
            Console.WriteLine(p);

            if (p > 0)
            {
                double area = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
                Console.WriteLine("Area of the triangle is " + area);
            }

        }
    }
}
