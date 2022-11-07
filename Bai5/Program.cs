using System;

namespace Bai5
{
    class Program
    {
        static void arr (){
            System.Console.WriteLine("Nhap phan tu cua mang: ");
            
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Random rd  = new Random();
            for(int i=0; i < n;i++)
            {
                a[i] = rd.Next(-10, 10);
                System.Console.WriteLine(a[i] + " ");
            }
            int b = 0, m = 0, w = 0;
            for(int i = 0; i < n; i++)
            {
                if(a[i] > 0)
                {
                    b++;
                }
                if(a[i] < 0)
                {
                    m++;
                }
                if(a[i] == 0)
                {
                    w++;
                }
            }
            float am,duong,k;
            am = (float)m/n;
            duong = (float)b/n;
            k = (float)w/n;
            System.Console.WriteLine("{0:F4}", duong);
            System.Console.WriteLine("{0:F4}", am);
            System.Console.WriteLine("{0:F4}", k);
        }
        static void Main(string[] args)
        {
            arr();
        }
    }
}
