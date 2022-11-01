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

namespace Bai9
{
    class Program
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int s = 0, max = 0;
            for(int i=0;i<candles.Count;i++)
            {
                if(candles[i]>=max)
                {
                    max = candles[i];
                }
            }
            for(int i=0;i<candles.Count;i++)
            {
                if(candles[i] == max)
                {
                    s++;
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            List<int> candles = new List<int>()
            {
                3,4,5,5,6,7
            };
            int n = birthdayCakeCandles(candles);
            System.Console.WriteLine(n);
        }
    }
}
