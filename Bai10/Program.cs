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

namespace Bai10
{
    class Program
    {
        public static StringBuilder caesarCipher(string text, int k)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i<text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    char ch = (char)(((int)text[i] + k - 65) % 26 + 65);
                    result.Append(ch);
                }
                else
                {
                    char ch = (char)(((int)text[i] + k - 97) % 26 + 97);
                    result.Append(ch);
                }
            }
        return result;
        }
        static void Main(string[] args)
        {
            int k = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            
            System.Console.WriteLine(caesarCipher(s,k));
        }
    }
}
