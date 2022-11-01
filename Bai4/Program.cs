using System;
using System.IO;
namespace Bai4
{
    class Program
    {
        static void matrix (){
            System.Console.WriteLine("Nhap kich thuoc ma tran");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n,n];
            Random rd = new Random();
            for(int i=0;i<n;i++){
                System.Console.WriteLine("\n");
                for(int j =0;j<n;j++){
                    matrix[i,j] = rd.Next(0,20);
                    System.Console.Write(matrix[i,j]+"  ");
                }
            }
            int cp=0,ct=0;
            for(int i=0;i<n;i++){
                for(int j =0;j<n;j++){
                    if(i==j){
                        cp+=matrix[i,j];
                    }
                    if((i+j) == (n-1)){
                        ct+=matrix[i,j];
                    }
                }
            }
            int c = Math.Abs(cp-ct);
            System.Console.WriteLine("\n"+c);
        }
        static void Main(string[] args)
        {
            matrix();
        }
    }
}
