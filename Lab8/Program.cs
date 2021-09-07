using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            //b1
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số lượng phần tử: ");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[] arr = new int[n];

            NhapMang(arr);

            Console.WriteLine();

            SapXepDoanKL(arr);

            Console.WriteLine();

            Console.WriteLine("Mảng sau khi sắp xếp");

            XuatMang(arr);


            //b2
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.Write("Nhập số lượng phần tử: ");

            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //int[] arr = new int[n];

            //NhapMang(arr);

            //Console.WriteLine();

            //SapXepGiamDanSNT(arr);

            //Console.WriteLine();

            //XuatMang(arr);


            //b3
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.Write("Nhập số lượng phần tử: ");

            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //int[] arr = new int[n];

            //NhapMang(arr);

            //Console.WriteLine();

            //TimLonThuK(arr);


            //b4
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.Write("Nhập số lượng phần tử: ");

            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //int[] arr = new int[n];

            //NhapMang(arr);

            //Console.WriteLine();

            //DemX(arr);


            //b5
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.Write("Nhập số lượng phần tử: ");

            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //int[] arr = new int[n];

            //NhapMang(arr);

            //Console.WriteLine();

            //Console.Write("Nhập K: ");
            //int k = int.Parse(Console.ReadLine());
            //Console.Write("Nhập L: ");
            //int l = int.Parse(Console.ReadLine());

            //SapXepTrongKL(arr, k, l);

            //SapXepNgoaiKL(arr, k, l);

            //Console.WriteLine();

            //Console.WriteLine("Mảng sau khi sắp xếp");

            //XuatMang(arr);



            //b6
            //Console.OutputEncoding = Encoding.UTF8;

            //Console.Write("Nhập số lượng phần tử: ");

            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //int[] arr = new int[n];

            //NhapMang(arr);

            //Console.WriteLine();

            //ViTriPTNhoNhat(arr);
        }
        public static void NhapMang(int[] arr)
        {
            Console.WriteLine("Nhập mảng số nguyên");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("a[{0,2}]: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public static void XuatMang(int[] arr)
        {
            Console.WriteLine("Xuất mảng số nguyên");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("a[{0,2}]: {1}", i + 1, arr[i]);
            }
        }
        static void SapXepDoanKL(int[] arr)
        {
            Console.Write("Nhập K: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Nhập L: ");
            int l = int.Parse(Console.ReadLine());

            for (int i = k - 1; i <= l - 1; i++)
            {
                for (int j = i + 1; j <= l - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static bool KiemTraSNT(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            for (int i = 3; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void SapXepGiamDanSNT(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j] && KiemTraSNT(arr[i]) == true && KiemTraSNT(arr[j]) == true)
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void TimLonThuK(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            Console.Write("Nhập K: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine($"Phần tử lớn thứ {k} trong mảng là: {arr[k - 1]}");


        }
        static void DemX(int[] arr)
        {
            Console.Write("Nhập giá trị x:");
            int x = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    count++;
            }

            Console.WriteLine($"Số lần xuất hiện của giá trị {x} trong mảng là {count}");
        }
        static void SapXepNgoaiKL(int[] arr, int k, int l)
        {

            for (int i = 0; i < k - 1; i++)
            {
                for (int j = i + 1; j < k - 1; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }


            for (int i = l; i > l - 1 && i < arr.Length; i++)
            {
                for (int j = i + 1; j > l - 1 && j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

        }

        static void SapXepTrongKL(int[] arr, int k, int l)
        {
            for (int i = k - 1; i <= l - 1; i++)
            {
                for (int j = i + 1; j <= l - 1; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void ViTriPTNhoNhat(int[] arr)
        {
            int min = arr[0];
            int vtMin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    vtMin = i;
                }
            }
            Console.WriteLine($"Vị trí phần tử nhỏ nhất trong mảng là: {vtMin + 1}");
        }
    }
}
