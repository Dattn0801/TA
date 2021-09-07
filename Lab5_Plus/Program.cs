using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Plus
{
    class Program
    {
        static void Main(string[] args)
        {
            ////b1
            //Console.WriteLine("Enter n: ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter string :");
            //string c1 = Console.ReadLine();
            //Console.WriteLine("Result :");
            //for(int i= 0; i <n; i++)
            //{
            //    Console.WriteLine(c1);
            //}

            ////b2
            //Console.WriteLine("Enter n :");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Result :");
            //for (int  i = 2; i < n; i++)
            //{
            //    if (i % 2 == 0)
            //        Console.WriteLine(i);
            //}

            ////b3
            //Console.WriteLine("Enter n :");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Result :");
            //for (int i = 1; i < n; i++)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //}

            //b4
            //Console.WriteLine("Enter n :");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Result :");
            //for (int i = 1; i < n; i++)
            //{
            //        Console.WriteLine(i);
            //}


            //b5
            //Console.WriteLine("Enter times :");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter numbers, 1 time 1 num  :");
            //int k;
            //for(int i = 0;i <n;i++)
            //{

            //}

            //b8
            //Console.WriteLine("Enter n:");
            //int n = int.Parse(Console.ReadLine());
            //for(int i =1; i <=10; i++)
            //{
            //    Console.WriteLine("{0} x {1} = {2}",n,i,n*i);
            //}

            //b9
            //Console.WriteLine("PRINT MULTICATION TABLE :");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(" Cửu Chương : " + i);
            //    for (int j = 1; j < 10; j++)
            //    {
            //        Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
            //    }   
            //}


            //b10       
            //Console.WriteLine("Enter n:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter m:");
            //int m = int.Parse(Console.ReadLine());
            //while (n > m)
            //{
            //    Console.WriteLine("ReEnter :");
            //    Console.WriteLine("Enter n:");
            //     n = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter m:");
            //     m = int.Parse(Console.ReadLine());
            //}


            //b11
            //Console.WriteLine("Enter n:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter m:");
            //int m = int.Parse(Console.ReadLine());
            //while (n  > m &&  m % 7 == 0)
            //{
            //    Console.WriteLine("ReEnter :");
            //    Console.WriteLine("Enter n:");
            //    n = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter m:");
            //    m = int.Parse(Console.ReadLine());
            //}


            //b12


            //b29 a
            //Console.WriteLine("Enter number of row :");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("\n");
            //}

            //b29 b
            //Console.WriteLine("Enter h :");
            //int h = int.Parse(Console.ReadLine());
            //if (h > 0)
            //{
            //    for(int i = 1; i <= h; i++)
            //    {
            //        for(int j = 1; j<=h; j++)
            //        {
            //            if( j <= h - i)         
            //                Console.Write(" ");
            //            else
            //                Console.Write("*");

            //        }
            //        Console.WriteLine("\n");
            //    }
            //}
            //else
            //    Console.WriteLine("Nhap h >0");


            //b29c


            //b29d



            //b29 e
            //Console.WriteLine("Enter number of row :");
            //int n = int.Parse(Console.ReadLine());
            //for(int i =1; i<=n; i++)
            //{
            //    for(int j = 1; j <=i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("\n");
            //}


            //b29f


            //b29g


            //b29h

            //b29 i
            //Console.WriteLine("Enter h :");
            //int h = int.Parse(Console.ReadLine());
            //if (h > 0)
            //{
            //    for (int i = 1; i <= h; i++)
            //    {
            //        for (int j = 1; j < 2*h; j++)
            //        {
            //            if (Math.Abs(h-j)<i)
            //                Console.Write("*");
            //            else
            //                Console.Write(" ");

            //        }
            //        Console.WriteLine("\n");
            //    }
            //}
            //else
            //    Console.WriteLine("Nhap h >0");


            //b29j
            Console.WriteLine("Enter h :");
            int h = int.Parse(Console.ReadLine());
            if (h > 0)
            {
                for (int i = h; i >=1; i--)
                {
                    for (int j = 1; j <= h-i; j++)
                        Console.Write(" ");
                    for (int k = 1; k <= i; k++)
                        Console.Write("* ");
                    Console.Write("\n");
                }
            }
            else
                Console.WriteLine("Nhap h >0");

            //b29k
            //Console.WriteLine("Enter h :");
            //int h = int.Parse(Console.ReadLine());
            //if (h > 0)
            //{
            //    for (int i = 1; i <= h; i++)
            //    {
            //        for (int j = 1; j < 2 * h; j++)
            //        {
            //            if (Math.Abs(h - j) == i - 1 || i ==h)
            //                Console.Write(" * ");
            //            else
            //                Console.Write("   ");

            //        }
            //        Console.WriteLine("\n");
            //    }
            //}
            //else
            //    Console.WriteLine("Nhap h >0");


            //b29m



        }
    }
}
