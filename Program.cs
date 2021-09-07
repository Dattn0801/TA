using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InChuCuaSoNguyen
{
    class Program
    {
        
        static string[] a = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười" };
        public static void PrintStringNumber(int n)
        {
            if (n == 100)
                Console.WriteLine("=> " + "Một Trăm");
            else if (n < 11)
                Console.WriteLine("=> " + a[n]);
            else
            {
                
                string so = n.ToString();
                int x = int.Parse(so[0].ToString());
                int y = int.Parse(so[1].ToString());
                if (n % 10 == 0)
                    Console.WriteLine("=> " + a[x] + " Mươi ");
                else
                {
                    if (y == 5 && x != 1)
                        Console.WriteLine("=> " + a[x] + " Mươi Lăm");
                    else if (x == 1)
                    {
                        if (y == 5)
                            a[y] = "Lăm";                        
                        Console.WriteLine("=> " + a[10] + " " + a[y]);
                        if (y == 5)
                            a[y] = "Năm";                        
                    }
                    else
                    {
                        if (y == 1)
                            a[y] = "Mốt";
                        Console.WriteLine("=> " + a[x] + " Mươi " + a[y]);
                    }    
                        
                }                
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int[] arr = new int[7];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Nhập số n: ");
                arr[i] = int.Parse(Console.ReadLine());
                while (arr[i] < 0 || arr[i] > 100)
                {
                    Console.WriteLine("Nhập lại số n (n thuộc [0,100]): ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                PrintStringNumber(arr[i]);
                if (i < arr.Length-1)
                    Console.WriteLine("-------------------------");
                else
                    break;
            }
            Console.ReadKey();
        }
    }
}
