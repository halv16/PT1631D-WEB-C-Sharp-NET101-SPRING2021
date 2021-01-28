using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3._3_MangNhieuChieu
{
    class Program
    {
        /*
         * MẢNG ĐA CHIỀU
         * MẢNG 2 CHIỀU
         * Mảng 2 chiều cần quan tâm đến cột và dòng
         *
         * 1. Rectangular Array
         *  Cú pháp: <kiểu dữ liệu>[,] = new <kiểu dữ liệu>[row,column];
         *  row: Số lượng hàng kiểu số nguyên
         *  column: Số lượng cột kiểu số nguyên
         *
         *  2. Jagged Array
         *  Cú pháp: <kiểu dữ liệu>[][] = new <kiểu dữ liệu>[row][];
         *  row: Số lượng hàng kiểu số nguyên
         */

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding("UTF-8");

            ///*
            // * 1. Rectangular Array
            // */
            ////Khởi tạo 1 mảng 2 chiều 2 hàng và 3 cột
            //int[,] arrNumbers = new int[2, 3] {
            //    {1, 2, 3 },
            //    {3, 4, 5 }
            //};

            ////Gán giá trị cho mảng 2 chiều
            ////Khai báo dòng 0 đủ 3 cột
            //arrNumbers[0, 0] = 0;
            //arrNumbers[0, 1] = 0;
            //arrNumbers[0, 2] = 1;

            ////Khai báo dòng số 1, cột 0
            //arrNumbers[1, 0] = 6;

            //// Lấy giá trị mảng 2 chiều
            //// lấy phần tử hàng 1, cột 1
            //int a = arrNumbers[1, 1]; // return 4;

            //// Nhập dữ liệu vào mảng 2 chiều
            //for (int i = 0; i < arrNumbers.GetLength(0); i++)       /// i là chỉ số hàng của mảng
            //{
            //    for (int j = 0; j < arrNumbers.GetLength(1); j++)   /// j là chỉ số cột của mảng
            //    {
            //        Console.WriteLine("Nhập giá trị cho phần tử tại row: {0} - col: {1}", i, j);
            //        arrNumbers[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// In toàn bộ mảng
            //// In mảng dùng vòng lặp foreach
            //Console.WriteLine("In mang su dung foreach:");
            //foreach (var k in arrNumbers)
            //{
            //    Console.Write(k + "\t");
            //}
            //Console.WriteLine();


            //// In mảng dùng 2 vòng lặp for
            //Console.WriteLine("In mang su dung for:");
            //for (int i = 0; i < arrNumbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arrNumbers.GetLength(1); j++)
            //    {
            //        // in phần tử hàng i, cột j
            //        Console.WriteLine("Giá trị tại row: {0} - col: {1}", i, j);
            //        Console.WriteLine(arrNumbers[i, j]);
            //    }
            //}


            /*
             * 2. Jagged Array
             */
            //int[][] jaggedArray = new int[2][];
            //jaggedArray[0] = new int[2] { 1, 2 };
            //jaggedArray[1] = new int[5] { 5, 4, 3, 2, 1 };

            //jaggedArray[0][1] = 6;

            ////Console.WriteLine(jaggedArray[0][1]);
            //for (int i = 0; i < jaggedArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < jaggedArray[i].Length; j++)
            //    {
            //        Console.Write(jaggedArray[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            // Dùng mảng 2 chiều để lưu bảng cửu chương và in ra cột k 
            // k nhập từ bàn phím

            Console.WriteLine("******Menu*******");
            Console.WriteLine("Chọn kiểu mảng:");
            Console.WriteLine("1. Rectangular Array");
            Console.WriteLine("2. Jagged Array");
            Console.WriteLine("3. Thoát");
            Console.Write("Lựa chọn: ");

            int menu = int.Parse(Console.ReadLine());
            int k;
            switch (menu)
            {
                case 1:
                    Console.WriteLine("1. Rectangular Array");
                    int[,] rectArray = new int[9, 10];

                    // Gan gia tri cho mang
                    for (int i = 0; i < rectArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < rectArray.GetLength(1); j++)
                        {
                            // phan tu hang i cot j
                            rectArray[i, j] = (i + 1) * (j + 1);
                        }
                    }

                    // In mang
                    for (int i = 0; i < rectArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < rectArray.GetLength(1); j++)
                        {
                            Console.Write(rectArray[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }


                    k = 2; // cột 3
                    Console.WriteLine("In cột " + (k + 1));
                    for (int i = 0; i < rectArray.GetLength(0); i++)
                    {
                        Console.Write(rectArray[i, k] + "\t");
                    }
                    Console.WriteLine();

                    break;

                case 2:
                    Console.WriteLine("2. Jagged Array");

                    int[][] jaggedArray = new int[9][];
                    for (int i = 0; i < jaggedArray.GetLength(0); i++)
                    {
                        jaggedArray[i] = new int[10];
                        for (int j = 0; j < jaggedArray[i].Length; j++)
                        {
                            jaggedArray[i][j] = (i + 1) * (j + 1);
                        }
                    }

                    for (int i = 0; i < jaggedArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < jaggedArray[i].Length; j++)
                        {
                            Console.Write(jaggedArray[i][j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    k = 4; // cột 5
                    Console.WriteLine("In cột " + (k + 1));
                    for (int i = 0; i < jaggedArray.GetLength(0); i++)
                    {
                        Console.Write(jaggedArray[i][k] + "\t");
                    }
                    Console.WriteLine();

                    break;

                default:
                    break;
            }

            Console.WriteLine("Ket thuc chuong trinh!");

            Console.ReadLine();
        }
    }
}
