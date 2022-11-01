using System;

namespace BaiTapC_
{
    class Program
    {
        static int solveMeFirst(int a, int b)
        { 
            return a+b;
        }
        static void Main(string[] args)
        {
            int val1,val2;
            int sum = 0;
            do
            {
                Console.WriteLine("Nhap so 2 so tu nhien: ");
                val1 = Convert.ToInt32(Console.ReadLine());
                val2 = Convert.ToInt32(Console.ReadLine());
                
            } while (val1<1 || val1>1000 || val2<1 || val2>100);
            
            sum = solveMeFirst(val1,val2);
            Console.WriteLine(sum);
        }
    }
}
