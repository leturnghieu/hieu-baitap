using System;

namespace Bai8
{
    class Program
    {
        public static void kangaroo(int x1, int v1, int x2, int v2)
    {
        int i = 1;
        int x3 = 0, x4 = 0, flag = 0;
        while(i>0)
        {
            x1+=v1;
            x2+=v2;
            x3=x1;
            x4=x2;
            if(((x1 < x2) && (x3 > x4)) || ((x2 < x1) && (x4 > x3)) || ((x1 < x2)&&(v1 < v2)) || ((x1 > x2)&&(v1 > v2)))
            {
                flag = 1;
                i = 0;
            }
            if(x3 == x4)
            {
                flag = 2;
                i = 0;
            }
            
        }
        if(flag == 2)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
        static void Main(string[] args)
        {
            int x1 = Convert.ToInt32(Console.ReadLine());

            int v1 = Convert.ToInt32(Console.ReadLine());

            int x2 = Convert.ToInt32(Console.ReadLine());

            int v2 = Convert.ToInt32(Console.ReadLine());

            kangaroo(x1,v1,x2,v2);
        }
    }
}
