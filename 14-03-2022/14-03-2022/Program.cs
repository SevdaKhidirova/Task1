using System;

namespace _14_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "y";
            while (answer == "y")
            {
                Console.WriteLine("Birni secin:\n" +
                "1. Verilmiş ededin sade eded olub olmamasını print eden console app .\n" +
                "2.Verilmiş ededin nece mertebeli oldugunu print eden console app \n" +
                "3.Verilmiş ededin palindrom olub olmadigini print eden  console app .");
                byte choose = Convert.ToByte(Console.ReadLine());
                switch (choose)
                {
                    case 1:                       //1. Verilmiş ədədin sadə ədəd olub olmamasını print edən console app yazın.
                        Console.WriteLine("ededi daxil edin: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        bool status = false;
                        for (int i = 2; i * i <= num; i++)
                        {
                            if (num % i == 0)
                            {
                                status = true;
                                break;
                            }
                        }
                        if (status == true)
                        {
                            Console.WriteLine("murekkebdir");
                        }
                        else
                            Console.WriteLine("sadedir");
                        break;
                    case 2:                         //2.Verilmiş ədədin neçə mərtəbəli olduğunu print edən console app yazın.

                        Console.WriteLine("ededi daxil edin: ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        int count = 1;
                        if (number >= 0 && number < 10)
                        {
                            Console.WriteLine(1);
                            break;
                        }
                        else if (number < 0)
                        {
                            number *= -1;             //number = Math.Abs(number);
                        }
                        while (number > 9)
                        {
                            number /= 10;
                            count++;
                        }
                        Console.WriteLine(count);
                        break;
                    case 3:                          //3.Verilmiş ədədin palindrom olub olmadığını print edən  console app yazın.
                        Console.WriteLine("ededi daxil edin: ");
                        int numb = Convert.ToInt32(Console.ReadLine());
                        if (numb > 0 && numb < 10)
                        {
                            Console.WriteLine(numb);
                        }
                        else if (numb >= 10)
                        {
                            int copy = numb;
                            int reversed = 0; ;
                            while (copy > 0)
                            {
                                reversed = reversed * 10 + copy % 10;
                                copy /= 10;
                            }
                            Console.WriteLine(reversed);
                            if (numb == reversed)
                                Console.WriteLine("polindromdur");
                            else Console.WriteLine("deyil");
                        }
                        break;
                    default:
                        Console.WriteLine("yanlis secim ");
                        break;
                }
                Console.WriteLine("davam etmek isteyirsinizse  Y eks halda  N secin: ");
                answer = Console.ReadLine().ToLower();
            }
        }
    }
}
