using System;
using System.Linq;

namespace Duong_Khac_Nguyen_Array
{
    internal class Program
    {
        //Ham tim so lan lap lai
        static int CountDuplicates(int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }
            return count;
        }
        // Ham tim so duy nhat
        static bool Co_Duplicate(int[] arr, int index)
        {
            for (int i = 0; i < index; i++)
            {
                if (arr[i] == arr[index])
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap vao so a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Nhap vao so b = ");
                int b = int.Parse(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Khong dung dinh dang nhap vao!: {0}", fe.Message);
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("Khong duoc chia cho 0 ({0})", de.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Loi !", ex.ToString());
            }

            Console.WriteLine("Xu li cac lenh tiep theo");
            //
            //int s = 0;
            //int Max = 0;

            //Console.Write("Nhap vao so luong phan tu n = ");
            //int n = int.Parse(Console.ReadLine());
            //int[] A = new int[n];

            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write("Nhap gia tri cho phan tu A[{0}] = ", i);
            //    A[i] = int.Parse(Console.ReadLine());
            //}


            ////// Bài 1
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.Write(A[i] + "    ");
            //}

            //// Bài 2
            //Array.Reverse(A);
            //Console.WriteLine();
            //for (int j = 0; j < A.Length; j++)
            //{
            //    Console.Write(A[j] + "    ");
            //}

            // Bài 3
            //int duplicateCount = CountDuplicates(A);
            //Console.WriteLine("So luong phan tu giong nhau trong mang: " + duplicateCount);

            //Bài 4
            //Console.WriteLine("Cac phan tu duy nhat trong mang:");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    bool Co_Duplicate = false;
            //    for (int j = 0; j < A.Length; j++)
            //    {
            //        if (i != j && A[i] == A[j])
            //        {
            //            Co_Duplicate = true;
            //            break;
            //        }
            //    }

            //    if (!Co_Duplicate)
            //    {
            //        Console.WriteLine(A[i]);
            //    }
            //}

            //Bài 5

            // dem so phan tu chan va le
            //int chanCount = 0;
            //int leCount = 0;

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] % 2 == 0)
            //    {
            //        chanCount++;
            //    }
            //    else
            //    {
            //        leCount++;
            //    }
            //}

            //// khoi tao mang chan va le
            //int[] chan = new int[chanCount];
            //int[] le = new int[leCount];

            //// chia phan tu mang chan va le
            //int chanIndex = 0;
            //int leIndex = 0;

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] % 2 == 0)
            //    {
            //        chan[chanIndex] = A[i];
            //        chanIndex++;
            //    }
            //    else
            //    {
            //        le[leIndex] = A[i];
            //        leIndex++;
            //    }
            //}

            //// in mang chan
            //Console.WriteLine("Mang chan:");
            //for (int i = 0; i < chan.Length; i++)
            //{
            //    Console.WriteLine(chan[i]);
            //}

            //// in mang le
            //Console.WriteLine("Mang le:");
            //for (int i = 0; i < le.Length; i++)
            //{
            //    Console.WriteLine(le[i]);
            //}

            ////Bài 6

            //// Sap xep tang dan
            //Array.Sort(A);

            //// Dao nguoc thu tu
            //Array.Reverse(A);

            //// in mang giam dan
            //Console.WriteLine("Mang theo gia tri giam dan:");
            //for (int i = 0; i < A.Length; i++)
            //{
            //    Console.WriteLine(A[i]);
            //}

            //Bài 7

            //int max1 = int.MinValue; // Giá trị lớn nhất
            //int max2 = int.MinValue; // Giá trị lớn thứ hai

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (A[i] > max1)
            //    {
            //        max2 = max1;
            //        max1 = A[i];
            //    }
            //    else if (A[i] > max2 && A[i] < max1)
            //    {
            //        max2 = A[i];
            //    }
            //}

            //if (max2 == int.MinValue)
            //{
            //    Console.WriteLine("Khong ton tai gia tri lon thu hai trong mang.");
            //}
            //else
            //{
            //    Console.WriteLine("Gia tri lon thu hai trong mang la: " + max2);
            //}
            //


            //LinQ

            //var sochan = A.Where(x => x %2 == 0).ToArray();
            //var sole = A.Where(x=> x %2 != 0).ToArray();

            ////In phan tu chan
            //Console.WriteLine("mang so chan");
            //foreach( var  item in sochan)
            //{ 
            //    Console.WriteLine(item + "\t");  
            //}

            ////In phan tu le
            //Console.WriteLine("mang so le");
            //foreach (var item in sole)
            //{
            //    Console.WriteLine(item + "\t");
            //}

            // In ra so phan tu duy nhat
            //var unique = A.Distinct();
            //Console.WriteLine("cac phan tu duy nhat la");
            //foreach (int i in unique) Console.Write(i+"\t");

            // In ra so lan trung lap

            //var dup = A.GroupBy(x => x).Select(x=>new { Value = x.Key, Count = x.Count() });
            //foreach(var i in dup)
            //{
            //    Console.WriteLine("Gia tri {0} lap lai {1} lan ", i.Value, i.Count);
            //}

            Console.ReadKey();
        }
    }
}