using System;

namespace _16_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birni secin \n" +
                "1.Cevrenin sahesi\n" +
                "2.Duzbucaqlinin sahesi\n" +
                "3.Paralelepipedin sahesi :");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Cevrenin radiusunu daxil edin :");
                int r = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(CalculateArea(r));
            }
            else if (choose == 2)
            {
                Console.WriteLine("a ve b ni daxil edin: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(CalculateArea(a, b));
            }
            else if (choose == 3)
            {
                Console.WriteLine("paralelepipedin tereflerini daxil edin: ");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(CalculateArea(a, b, c));
            }
            else Console.WriteLine("404 not found");
        }
        static int CalculateArea(int r)
        {
            int p = 3;
            return p * r * r;
        }
        static int CalculateArea (int a,int b)
        {
            return a * b;
        }
        static int CalculateArea(int a,int b,int c)
        {
            return 2 * (a * b + a * c + b * c);
        }
    }
  
}
