using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Plus
{
    class Program
    {
        static void Main(string[] args)
        {
            ////b1
            //Console.WriteLine("Enter n:");
            //int n = int.Parse(Console.ReadLine());
            //for(int i = 0; i <=n; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.Write(2 * i);
            //}


            //b2
            //Console.WriteLine("Enter n:");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    if (i > 5 )
            //        Console.Write( i+2+ " ");
            //}



            //b3
            //Console.WriteLine("Enter x:");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter y:");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine("X + Y = " + (x + y));
            //Console.WriteLine("X - Y = " + (x - y));
            //Console.WriteLine("X * Y = " + (x * y));
            //Console.WriteLine("X / Y = " + (x / y));



            //b4
            //int max;
            //Console.WriteLine("Enter x:");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter y:");
            //int y = int.Parse(Console.ReadLine());
            //max = x > y ? max = x:max=y;
            //Console.WriteLine("Max" +max);


            //b5
            //Console.WriteLine("Enter x has 3 digits:");
            //int x = int.Parse(Console.ReadLine());
            //x = Math.Abs(x);

            //int max = 0;

            //for (; x > 0;)
            //{
            //    int temp = x % 10;
            //    x /= 10;
            //    if (temp > max)
            //        max = temp;
            //}
            //Console.WriteLine(max);


            //b6
            //Console.WriteLine("Enter maths:");
            //double mat = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter physical:");
            //double phy = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter chemical:");
            //double che = double.Parse(Console.ReadLine());
            //double meScore = (mat + phy + che) / 3;
            //if (meScore < 5)
            //    Console.WriteLine("Yeu");
            //else if (meScore >= 5 && meScore < 6)
            //    Console.WriteLine("TB  ");
            //else if (meScore >= 6 && meScore < 7)
            //    Console.WriteLine("TB Kha");
            //else if (meScore >= 7 && meScore < 8)
            //    Console.WriteLine("Kha");
            //else if (meScore >= 8 && meScore < 9)
            //    Console.WriteLine("Gioi");
            //else
            //    Console.WriteLine("Xuc Xich");


            //b7
            Console.WriteLine("Enter year :");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 ==0 && year % 100 != 0))
                Console.WriteLine(year + " la nam nhuan");
            else
                Console.WriteLine(year + " ko la nam nhuan");

            //b10
            //double mustpay;
            //Console.WriteLine("Enter km: ");
            //double km = double.Parse(Console.ReadLine());
            //if (km == 0)
            //    mustpay = 0;
            //if (km > 0 && km <= 1)
            //    mustpay = 5000;
            //if(km>1  && km <= 30)
            //    mustpay = 5000 +

                




            





        }
    }
}
