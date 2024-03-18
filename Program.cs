using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duong_Khac_Nguyen_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int s = 0;
            int Max = 0;

            Console.Write("Nhap vao so luong phan tu n =");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];

            for (int i = 0; i < A.Length; i++)
            {
             Console.Write("nhap gia tri cho phan tu A[{0}] = ", i);
             A[i] = int.Parse(Console.ReadLine());
            }

            //Tinh tong
            //for (int i = 0; i < A.Length; i++)
            //{
            //    s = s + A[i];
            //}
            //Console.WriteLine("Tong phan tu la s = {0}",s);

            //tim so lon nhat
            for (int i = 0;i < A.Length; i++)
            {
                if (Max < A[i]) Max= A[i];
            }
            Console.WriteLine("So lon nha la {0}", Max);
            //sap xep
            for (int i = 0; i < A.Length-1; i++)
            {
                int count = 0;
                for (int j = 0; j < A.Length - 1; j++)
                {
                    int Temp = 0;
                   
                    if (A[j] > A[j + 1])
                    {
                        count++;
                        Temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = Temp;
                    }
                    Console.WriteLine("A[{0}] = {1}",j,A[j]);
                    if (j == A.Length - 2)
                    {
                        Console.WriteLine("A[{0}] = {1}", n-1, A[n-1]);
                        Console.WriteLine();
                    }                                      

                }
                if (i == A.Length - 2 && count == 0) { break; }
            }
            for (int i = 0; i < A.Length; i++) { Console.WriteLine(A[i]); }

                //////////////////////////////////
                Console.ReadKey();
        }
    }
}
