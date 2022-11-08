using System;
using System.Collections.Generic;
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int pointAlice = 0;
            int pointBob = 0;
            System.Console.WriteLine("Nhap gia tri day a : ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Nhap gia tri day b : ");
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            
            List<int> a = new List<int>
            {
                x,y,z
            };
            List<int> b = new List<int>
            {
                m,n,p
            };
            for (int i = 0; i < 3; i++)
            {
                if(a[i] > b[i]){
                    pointAlice++;
                } else if(a[i] < b[i]){
                    pointBob++;
                }
            }
            System.Console.WriteLine(pointAlice + "-" + pointBob);
        }
    }
}
