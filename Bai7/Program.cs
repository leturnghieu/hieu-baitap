using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace Bai7
{
    class Program
    {
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int countApple = 0, countOranges = 0;
        for(int i = 0;i < apples.Count; i++)
        {
            if(((apples[i] + a) >= s)&&((apples[i] + a) <= t))
            {
                countApple++;
            }
        }
        for(int i = 0; i < oranges.Count; i++)
        {
            if(((oranges[i] + b) >= s)&&((oranges[i] + b) <= t))
            {
                countOranges++;
            }
        }
        Console.WriteLine(countApple);
        Console.WriteLine(countOranges);
    }
        static void Main(string[] args)
        {
            

            int s = Convert.ToInt32(Console.ReadLine());

            int t = Convert.ToInt32(Console.ReadLine());

            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            List<int> apples = new List<int>(){5,6,7};

            List<int> oranges = new List<int>(){10,11,12} ;

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
    }
}
