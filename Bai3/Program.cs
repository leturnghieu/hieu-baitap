using System;

namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int n;
            long sum=0;
            System.Console.WriteLine("So phan tu cua mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            long[] a = new long[n];
            for(int i=0;i<n;i++){
                a[i] = rd.Next(1,100000000);
                System.Console.Write(a[i]+"     ");
                sum+=a[i];
            }
            System.Console.WriteLine("\n"+sum);
        }
    }
}
