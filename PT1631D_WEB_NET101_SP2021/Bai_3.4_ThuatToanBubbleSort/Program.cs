using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._4_ThuatToanBubbleSort
{
    class Program
    {
        /* 
         * Thuật toán BubbleSort - nổi bọt
         * là một thuật toán sắp xếp đơn giản, với thao tác cơ bản là so sánh hai phần tử kề nhau, nếu chúng chưa đứng đúng thứ tự thì đổi chỗ (swap). 
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] arr = new int[] { 1, 4, 2, 4, 0 };
            Console.WriteLine("Mảng chưa sắp xếp: ");
            foreach (var k in arr)
            {
                Console.Write(k + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    Console.WriteLine(" Tại thời điểm i = " + i);
                    Console.WriteLine(" Tại thời điểm j = " + j);
                    Console.WriteLine(" So sánh giá trị {0} > {1}", arr[j], arr[j + 1]);
                    if (arr[j] > arr[j + 1]) // sắp xếp mảng tăng dần
                                             // sắp xếp mảng giảm dần thì đổi thành:
                                             // if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                    Console.WriteLine("Mảng tại thời điểm i = {0}, j = {1}: ", i, j);
                    foreach (var k in arr)
                    {
                        Console.Write(k + "\t");
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Mảng sau sắp xếp: ");
            foreach (var k in arr)
            {
                Console.Write(k + "\t");
            }

            Console.ReadLine();
        }
    }
}
